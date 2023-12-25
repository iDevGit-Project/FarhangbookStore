using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class CategoryController : Controller
    {
        #region متد های کلاس سازنده کنترلر دسته بندی
        private readonly IUnitOfWork _iuw;
        private readonly IToastNotification _toastNotification;

        public CategoryController(IUnitOfWork iuw, IToastNotification toastNotification)
        {
            _iuw = iuw;
            _toastNotification = toastNotification;
        }
        #endregion

        #region متد مربوط به ثبت دسته بندی
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddCategory(TBL_ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                _iuw.productCategoryUW.Create(model);
                _toastNotification.AddSuccessToastMessage("ثبت دسته بندی با موفقیت انجام شد.", new NotyOptions()
                {
                    ProgressBar = true,
                    Timeout = 1000,
                    Layout = "topCenter",
                    Theme = "metroui"
                });
                _iuw.Save();
                return RedirectToAction("AddCategory", "Category");
            }

            return View(model);
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }
    }
}
