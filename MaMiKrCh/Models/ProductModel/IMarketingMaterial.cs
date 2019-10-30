using System.ComponentModel.DataAnnotations;

namespace MaMiKrCh.Models.ProductModel
{
	public interface IMarketingMaterial
	{
		
		int Id { get; set; }

		string ToHtml();
	}
}