using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaMiKrCh.Models;
using MaMiKrCh.Models.ProductModel;

namespace MaMiKrCh.Mockup
{
	public class MockupProducts
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
