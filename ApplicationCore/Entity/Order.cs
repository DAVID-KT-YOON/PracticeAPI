using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAPI.ApplicationCore.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateOnly Order_Date {  get; set; }
        public int CustomerId {  get; set; }
        public string CustomerName { get; set; }
        public int PaymentMethodId {  get; set; }
        public string PaymentName {  get; set; }
        public string ShippingAddress {  get; set; }
        public string ShippingMethod {  get; set; }
        public int BillAmount {  get; set; }
        public string Order_Status {  get; set; }
        public ICollection<Order_Details> OrderDetails { get; set; }
    }
}
