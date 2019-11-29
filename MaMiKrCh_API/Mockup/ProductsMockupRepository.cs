using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaMiKrCh_API.Models;
using MaMiKrCh_API.Models.ProductModel;

namespace MaMiKrCh_API.Mockup
{
	public class ProductsMockupRepository
	{
		public IEnumerable<Product> products
		{
			get
			{
				return new List<Product>
				{
					new Product
					{
						Name = "CD-ORD",
						SalesPitch = "Læse- og skriveværktøjet CD-ORD er kendt for at forløse ordblinde " +
						"børn og voksnes potentiale for at læse, skrive og lære.",
						
						
					}
				};
			}
		}
	}
}
