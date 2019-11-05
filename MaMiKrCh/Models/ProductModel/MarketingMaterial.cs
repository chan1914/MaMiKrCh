namespace MaMiKrCh.Models.ProductModel
{
	public abstract class MarketingMaterial
	{
		public Product Product { get; set; }
		public int Id { get; set; }

		public abstract string ToHtml();
	}
}