using Microsoft.EntityFrameworkCore;
using OrderAPI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPI.Infrastructure.Data
{
    public class EShopDbContext:DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> option) : base(option)
        {
        }
        DbSet<Order> Orders {  get; set; }
        DbSet<Order_Details> Order_Details { get; set; }
    }
}
