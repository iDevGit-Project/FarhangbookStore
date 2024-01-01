using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class ProductController : Controller
	{
		private ICategoryService _Categoryservice;

        public ProductController(ICategoryService CategoryService)
        {
			_Categoryservice = CategoryService;
        }
        public IActionResult Index()
		{
			return View();
		}
	}
}
