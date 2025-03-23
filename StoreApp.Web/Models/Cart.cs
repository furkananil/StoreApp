using System;
using StoreApp.Data.Conrete;

namespace StoreApp.Web.Models;

public class Cart
{
    public List<CartItem> Items { get; set; } = new();
    
    public void AddItem(Product product, int quantity)
    {
        var item = Items.Where(i => i.Product.Id == product.Id).FirstOrDefault();

        if(item == null)
        {
            Items.Add(new CartItem { Product = product, Quantity = quantity });
        }
        else
            item.Quantity += quantity;

    }
    public void RemoveItem(Product product)
    {
        Items.RemoveAll(i => i.Product.Id == product.Id);
    }

    public decimal CalculateTotal()
    {
        return Items.Sum(i => i.Product.Price * i.Quantity);
    }

    public void Clear()
    {
        Items.Clear();
    }
}

public class CartItem
{
    public int CartItemId { get; set; }
    public Product Product { get; set; } = new();
    public int Quantity { get; set; }
}
