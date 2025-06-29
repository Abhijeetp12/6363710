
using System;
using System.Collections.Generic;

namespace Inventory_Management
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(string id, string name, int qty, double price)
        {
            ProductId = id;
            ProductName = name;
            Quantity = qty;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ProductId} | {ProductName} | Qty: {Quantity} | Price: Rs.{Price}";
        }
    }
}