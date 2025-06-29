using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Customer_Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double TotalPrice { get; set; }

        public Order(int orderId, string customerName, double totalPrice)
        {
            OrderId = orderId;
            CustomerName = customerName;
            TotalPrice = totalPrice;
        }
        public override string ToString()
        {
            return $"OrderID: {OrderId}, Customer: {CustomerName}, Total: ₹{TotalPrice}";
        }
    }
}
