using NUnit.Framework;
using MaMiKrCh_API.Controllers;

namespace TestApiController
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			ProductController productController = new ProductController();
			Assert.AreEqual("Test produckt 1", productController.GetProducts());
			
		}
	}
}