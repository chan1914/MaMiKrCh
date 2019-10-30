﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrCh.Models.ProductModel
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SalesPitch { get; set; }

		public List<IMarketingMaterial> MarketingMaterials { get; set; }

	}
}
