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
		public ICollection<Product> GetProducts()
		{
			List<Product> products = new List<Product>();

			//products.Add();

			return products.ToList();
		}





    }
}