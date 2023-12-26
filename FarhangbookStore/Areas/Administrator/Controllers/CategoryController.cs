using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CategoryController : Controller
    {
        #region متد های کلاس سازنده کنترلر دسته بندی

        private ICategoryService _Categoryservice;
        public CategoryController(ICategoryService Categoryservice)
        {
            _Categoryservice = Categoryservice;
        }
        public IActionResult showAllCategory()
        {
            return View(_Categoryservice.ShowAllCategory());
        }
        #endregion

        #region متد مربوط به ثبت دسته بندی
        [HttpGet]
        public IActionResult AddCategory(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(TBL_ProductCategory category)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.id = category.SubCategory;
                return View(category);
            }

            if (_Categoryservice.ExistCategory(category.CategoryFaTitle, category.CategoryEnTitle, 0))
            {
                ModelState.AddModelError("CategoryFaTitle", "خطا... دسته بندی وارد شده تکراری است .");
                ViewBag.id = category.SubCategory;
                return View(category);
            }

            int cateid = _Categoryservice.AddCategory(category);
            TempData["Result"] = cateid > 0 ? "true" : "false";

            return RedirectToAction(nameof(AddCategory));
        }
        #endregion

        #region متد مربوط به نمایش زیردسته ها
        [HttpGet]
        public IActionResult ShowAllSubCategory(int id)
        {
            ViewBag.id = id;
            return View(_Categoryservice.showAllSubCategory(id));
        }

        [HttpGet]
        public IActionResult ShowAllSubCategorythree(int id)
        {
            ViewBag.id = id;
            return View(_Categoryservice.showAllSubCategory(id));
        }
        #endregion
    }
}
