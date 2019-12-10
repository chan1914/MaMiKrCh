using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaMiKrChFrontEnd.Models;
using MaMiKrChFrontEnd.Models.API;
using Microsoft.AspNetCore.Mvc;

namespace MaMiKrChFrontEnd.Controllers
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