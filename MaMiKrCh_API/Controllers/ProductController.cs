using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MaMiKrCh_API.Models.ProductModel;

namespace MaMiKrCh_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
		[HttpGet]
		[Route("GetProducts")]
		public ActionResult<List<Product>> GetProducts()
		{
			List<Product> products = new List<Product>();

			//products.Add();
			products.Add(new Product
			{
				Name = "Test produckt 1",
				SalesPitch = "Køb produkt 1, fordi jeg siger det!"
			});
			products.Add(new Product
			{
				Name = "Test produckt 2",
				SalesPitch = "Køb produkt 2, fordi Allan siger du skal!"
			});

			return products.ToList();
		}





    }
}