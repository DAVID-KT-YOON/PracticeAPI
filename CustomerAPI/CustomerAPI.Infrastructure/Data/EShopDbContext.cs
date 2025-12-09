using CustomerAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAPI.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
