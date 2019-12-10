using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrChFrontEnd.Models.ProductsModel
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string SalesPitch { get; set; }
		public ICollection<MarketingMaterial> MarketingMaterials { get; set; }

		public Product()
		{
			MarketingMaterials = new List<MarketingMaterial>();
		}
	}
}
