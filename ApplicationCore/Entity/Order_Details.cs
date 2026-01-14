using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPI.ApplicationCore.Entity
{
    public class Order_Details
    {            public int Id { get; set; }

            public int OrderId { get; set; }      // FK
            public Order Order { get; set; } = null!;

            public int ProductId { get; set; }
            public int Qty { get; set; }
            public decimal Price { get; set; }
            public decimal Discount { get; set; }
       
    }
}
