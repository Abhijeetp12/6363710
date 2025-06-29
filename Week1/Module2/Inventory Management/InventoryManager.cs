using System;
using System.Collections.Generic;
using Inventory_Management;

public class InventoryManager
{
    private Dictionary<string, Product> inventory = new Dictionary<string, Product>();

    public void AddProduct(Product p)
    {
        inventory[p.ProductId] = p;
    }

    public void UpdateProduct(string id, int qty, double price)
    {
        if (inventory.ContainsKey(id))
        {
            inventory[id].Quantity = qty;
            inventory[id].Price = price;
        }
    }

    public void DeleteProduct(string id)
    {
        inventory.Remove(id);
    }

    public void DisplayInventory()
    {
        foreach (var item in inventory.Values)
            Console.WriteLine(item);
    }
}