using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
namespace InventoryAPI.helper
{
    public class RabbitMqQueue
    {
        ConnectionFactory connectionFactory;
        public RabbitMqQueue()
        {
            connectionFactory = new ConnectionFactory();
        }
        public void ReadMessage() {
            connectionFactory.Uri = new Uri("amqp://guest:guest@rabbitmq:5672");
            connectionFactory.ClientProvidedName = "Inventory Service";

            var connection = connectionFactory.CreateConnection();


            var channel = connection.CreateModel();
            string exchange = "OrderAPIExchange";
            string routingKey = "order-api-routing-key";
            string queueName = "order-api-queue";

            channel.ExchangeDeclare(exchange, ExchangeType.Direct);
            channel.QueueDeclare(queueName,false,false,false,null);
            channel.QueueBind(queueName, exchange, routingKey, null);
            channel.BasicQos(0, 1, false);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, args) => {
                var body = args.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);

                Console.WriteLine($"Received: {message}");
                channel.BasicAck(args.DeliveryTag, false);
            };
            string str = channel.BasicConsume(queueName, false, consumer);
            channel.BasicCancel(str);
            channel.Close();
            connection.Close();
        }
    }
}
