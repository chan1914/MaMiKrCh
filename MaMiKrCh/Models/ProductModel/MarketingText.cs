using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrCh.Models.ProductModel
{
	public class MarketingText:IMarketingMaterial
	{

		public string Text { get; set; }
		
		public int Id { get; set; }

		public string ToHtml()
		{
			throw new NotImplementedException();
		}
	}
}
