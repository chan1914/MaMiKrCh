using System.ComponentModel.DataAnnotations;

namespace MaMiKrCh_API.Models.ProductModel
{
	public abstract class MarketingMaterial
	{
		public Product Product { get; set; }
		
		[Key]
		public int Id { get; set; }

		public abstract string ToHtml();
	}
}