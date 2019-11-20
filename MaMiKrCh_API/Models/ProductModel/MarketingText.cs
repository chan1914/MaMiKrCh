using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaMiKrCh_API.Models.ProductModel
{
	public class MarketingText:MarketingMaterial
	{
		public string Text { get; set; }

		public override string ToHtml()
		{
			string htmlView = string.Empty;

			htmlView += $"<p>{Text}</p>";

			return htmlView;
		}
	}
}
