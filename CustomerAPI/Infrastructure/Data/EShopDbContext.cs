using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EShopDbContext:DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> option) : base(option)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
 