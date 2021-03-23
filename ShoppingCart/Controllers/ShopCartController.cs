using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    public class ShopCartController : Controller
    {
        private static List<Product> products = new List<Product>();
        private static Cart c1 = new Cart();


        // GET: ShopCartController
        public ActionResult Index()
        {
            if (products.Count==0)
            {
                Product p1 = new Product() { ProdCode = "123", Description = "Chocolate", Price = 2.50 };
                Product p2 = new Product() { ProdCode = "145", Description = "Beer", Price = 2.00 };
                Product p3 = new Product() { ProdCode = "134", Description = "Crisps", Price = 1.50 };
                products.Add(p1);
                products.Add(p2);
                products.Add(p3);
            }
            //Cart c1 = new Cart();
            //c1.AddItem(p1);
            //c1.AddItem(p2);
            //c1.AddItem(p2);
            //c1.AddItem(p3);
            //return View(products);
            ViewBag.count = c1.GetCount();
            ViewBag.total = c1.CalculateTotal();
            
            //double total = c1.CalcTotal();
            //ViewBag.total = total;
            return View(products);
        }

        // GET: ShopCartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AddToCart(string code)
        {
            //Cart c1 = new Cart();

            Product p = products.FirstOrDefault(c => c.ProdCode.Equals(code));
            if (p != null)
            {
                c1.AddItem(p);
            }
            return RedirectToAction("Index");
        }
        

        // GET: ShopCartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopCartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopCartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopCartController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopCartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopCartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
