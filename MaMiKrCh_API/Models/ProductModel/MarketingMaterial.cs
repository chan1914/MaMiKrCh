using System.ComponentModel.DataAnnotations;

namespace MaMiKrCh.Models.ProductModel
{
	public abstract class MarketingMaterial
	{
		public Product Product { get; set; }
		[Key]
		public int Id { get; set; }

		public abstract string ToHtml();
	}
}