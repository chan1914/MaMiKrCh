using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaMiKrCh_API.Models.ProductModel;

namespace MaMiKrCh_API.EFContext
{
	public class ProductContext : DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<MarketingText> MarketingTexts { get; set; }
		public DbSet<MarketingMaterial> MarketingMaterials { get; set; }
	}
}
