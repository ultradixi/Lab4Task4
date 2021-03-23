using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {
        private List<Item> Items;
        public Cart()
        {
            Items = new List<Item>();
        }

        public void AddItem(Product p)
        {
            Item found = Items.SingleOrDefault(i => i.ProdCode == p.ProdCode);
            if (found == null)
            {
                Items.Add(new Item() { ProdCode = p.ProdCode, Description = p.Description, Price = p.Price, Quantity = 1 });
            }
            else
            {
                found.Quantity++;
            }
        }
        public double CalculateTotal()
        {
            return Items.Sum(p => p.Price * p.Quantity);
        }
        public int GetCount()
        {
            return Items.Sum(c => c.Quantity);
        }
    }
}
