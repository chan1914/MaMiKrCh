using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrCh.Models.ProductModel
{
	public class MarketingText:MarketingMaterial
	{
		public string Text { get; set; }

		public override string ToHtml()
		{
			throw new NotImplementedException();
		}
	}
}
