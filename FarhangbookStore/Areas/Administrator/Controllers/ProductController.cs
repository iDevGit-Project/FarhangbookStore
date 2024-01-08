using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.Services.EntitiesService;
using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
	[Area("Administrator")]
	public class ProductController : Controller
	{
        #region متد مربوط به پیکربندی کلیه آیتم های مربوط به کالای کتاب

        private IProductService _productService;
		private ICategoryService _Categoryservice;
		public ProductController(IProductService productService, ICategoryService Categoryservice)
		{
			_productService = productService;
			_Categoryservice = Categoryservice;
		}
		public IActionResult ShowAllPropertyname()
		{
			return View(_productService.ShowAllProperty());
		}

		#endregion

        #region متد مربوط به پیکربندی محصولات
        public IActionResult ShowallProduct()
        {
            return View(_productService.ShowallProduct());
        }
        #endregion

		#region متد ثبت خصوصیات و ویژه گی ها

		[HttpGet]		
		public IActionResult AddProprtyName()
		{
			// از این متد برای نمایش زیردسته ها در هنگام ثبت خصوصیات و ویژه گی ها برای زیردسته استفاده می شود
            ViewBag.Category = _Categoryservice.Showsubcategory();
            return View();
        }

		[HttpPost]
        public IActionResult AddProprtyName(TBL_PropertyName propertyName, List<int> Categoryid)
        {
			if (!ModelState.IsValid)
			{
                ViewBag.Category = _Categoryservice.Showsubcategory();
			}
            if (_productService.ExistPropertyName(propertyName.PropertyTitle, 0))
            {
                ModelState.AddModelError("PropertyTitle", "خصوصیات تکراری است .");
                return View(propertyName);
            }
            int nameid = _productService.AddProprtyName(propertyName);
            if (nameid <= 0)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowAllPropertyname));
            }
            List<TBL_PropertyName_Category> Addpc = new List<TBL_PropertyName_Category>();

            foreach (var item in Categoryid)
            {
                Addpc.Add(new TBL_PropertyName_Category
                {
                    Categoryid = item,
                    PropertyNameId = nameid,

                });
            }

            bool res = _productService.AddPropertyForCategory(Addpc);
            TempData["Result"] = res ? "true" : "false";
            return RedirectToAction(nameof(ShowAllPropertyname));
        }

        #endregion

        #region متد ویرایش خصوصیات و ویژه گی های موجود در دسته بندی ها
        [HttpGet]
        public IActionResult UpdatePropertyName(int id)
        {
            ViewBag.Category = _Categoryservice.Showsubcategory();
            ViewBag.Property = _productService.ShowPropertyNameForUpdate(id);
            return View(_productService.FindPropertyBuyeid(id));
        }

        [HttpPost]
        public IActionResult UpdatePropertyName(TBL_PropertyName propertyName, List<int> Categoryid)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Category = _Categoryservice.Showsubcategory();
                ViewBag.Property = _productService.ShowPropertyNameForUpdate(propertyName.PropertyNameId);
                return View();
            }
            if (_productService.ExistPropertyName(propertyName.PropertyTitle, propertyName.PropertyNameId))
            {
                ModelState.AddModelError("PropertyTitle", "خصوصیات تکراری است .");
                return View(propertyName);
            }
            bool updateprop = _productService.UpdatePropertyName(propertyName);
            if (!updateprop)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowAllPropertyname));
            }
            bool deleteprop = _productService.DeleteProperyForCategory(propertyName.PropertyNameId);
            if (!deleteprop)
            {
                TempData["Result"] = "false";
                return RedirectToAction(nameof(ShowAllPropertyname));
            }
            List<TBL_PropertyName_Category> categories = new List<TBL_PropertyName_Category>();
            foreach (var item in Categoryid)
            {
                categories.Add(new TBL_PropertyName_Category
                {
                    Categoryid = item,
                    PropertyNameId = propertyName.PropertyNameId,

                });
            }
            bool addpropertyforcategory = _productService.AddPropertyForCategory(categories);
            TempData["Result"] = addpropertyforcategory ? "true" : "false";
            return RedirectToAction(nameof(ShowAllPropertyname));
        }
        #endregion

    }
}
