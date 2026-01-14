using CustomerAPI.Core.Contract;
using CustomerAPI.Infrastructure.Data;
using CustomerAPI.Infrastructure.Data;
using CustomerAPI.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
            var connectionString =
    Environment.GetEnvironmentVariable("EShop")
    ?? builder.Configuration.GetConnectionString("EShopDb");

            builder.Services.AddDbContext<EShopDbContext>(options =>
                options.UseSqlServer(connectionString));

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
