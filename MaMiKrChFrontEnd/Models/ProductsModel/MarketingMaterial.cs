using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrChFrontEnd.Models.ProductsModel
{
	public abstract class MarketingMaterial
	{
		public Product Product { get; set; }
		[Key]
		public int Id { get; set; }

		public abstract string ToHtml();
	}
}
