using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaMiKrCh.Models.ProductModel;

namespace MaMiKrCh.Data
{
	public class ProductContext:DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<MarketingText> MarketingTexts { get; set; }
		public DbSet<MarketingMaterial> MarketingMaterials { get; set; }
	}
}