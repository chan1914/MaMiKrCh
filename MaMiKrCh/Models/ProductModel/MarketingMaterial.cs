namespace MaMiKrCh.Models.ProductModel
{
	public abstract class MarketingMaterial
	{
		public int Id { get; set; }

		public abstract string ToHtml();
	}
}