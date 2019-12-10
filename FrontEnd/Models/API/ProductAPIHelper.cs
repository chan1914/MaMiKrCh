using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace FrontEnd.Models.API
{
	public class ProductAPIHelper
	{
		public IConfiguration Configuration { get; set; }

		public ProductAPIHelper()
		{
			Configuration = Startup.Configuration;
		}

		public async Task<ICollection<Product>> GetAllProducts()
		{
			string conStr = Configuration.GetConnectionString("ProductAPIConnection") + "api/Product/GetProducts";
			List<Product> products;
			using(HttpClient httpClient = new HttpClient())
			{
				using (var response = httpClient.GetAsync(
					conStr))
				{
					string apiResponse = await response.Result.Content.ReadAsStringAsync();
					products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
				}
			}
			return products;
		}
	}
}
