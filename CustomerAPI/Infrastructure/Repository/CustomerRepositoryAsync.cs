using Core.Contract;
using Core.Entity;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CustomerRepositoryAsync : BaseRepositoryAsync<Customer>, ICustomerRepositoryAsync
    {
        public CustomerRepositoryAsync(EShopDbContext _c) : base(_c)
        {
        }
    }
}
