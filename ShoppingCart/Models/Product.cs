using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Product
    {
        public string ProdCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
    public class Item : Product
    {
        public int Quantity { get; set; }
    }
}
