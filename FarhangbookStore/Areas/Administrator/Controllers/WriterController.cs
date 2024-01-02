using FarhangbookStore.DataModel.Entities;
using FarhangbookStore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FarhangbookStore.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class WriterController : Controller
    {
        #region متد مربوط به پیکربندی نویسنده گان - ناشران
        private IWriterService _writerService;
        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        #endregion
        public IActionResult ShowAllWriter()
        {
            return View(_writerService.ShowAllWriter());
        }

        [HttpGet]
        public IActionResult AddWriter()
        {
            return PartialView("_ModalAddWriter");
        }

        [HttpPost]
        public IActionResult AddWriter(TBL_ProductWriter productWriter)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(ShowAllWriter));
            }
            if (_writerService.ExistWriter(productWriter.WriterFaTitle, productWriter.WriterEnTitle, 0))
            {
                return Json(5);
            }
            int getUpdateWriteid = _writerService.AddWriter(productWriter);
            int sendjson = getUpdateWriteid > 0 ? 1 : 4;
            return Json(sendjson);
        }
    }
}
