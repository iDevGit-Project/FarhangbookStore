using FarhangbookStore.Services.EntitiesService;
using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class ProductController : Controller
	{
		#region متد مربوط به پیکربندی خصوصیات و ویژه گی ها

		private IProductService _productService;
		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		public IActionResult ShowAllPropertyname()
		{
			return View(_productService.ShowAllProperty());
		}

		#endregion

		#region متد ثبت خصوصیات و ویژه گی ها

		#endregion
	}
}
