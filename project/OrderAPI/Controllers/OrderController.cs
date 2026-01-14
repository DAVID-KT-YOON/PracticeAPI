using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Helper;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        Notification notification;
        public OrderController()
        {
            notification = new Notification();   
        }
        [HttpPost]
        public IActionResult CreateOrder(string message)
        {
            notification.AddMessageToQueue(message);
            return Ok();
        }
    }
}
