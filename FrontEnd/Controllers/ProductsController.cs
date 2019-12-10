using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using FrontEnd.Models.API;

namespace FrontEnd.Controllers
{
    public class ProductsController : Controller
    {
		private ProductAPIHelper productAPIHelper = new ProductAPIHelper();
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult ProductList()
		{
			ICollection<Product> products;
			products = productAPIHelper.GetAllProducts().Result;
			return View(products);
		}
    }
}