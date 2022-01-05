using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetWriterListAsJson()
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());

            var writerValues = writerManager.GetList();

            var writerValuesAsJson = JsonConvert.SerializeObject(writerValues);

            return Json(writerValuesAsJson);
        }
        public IActionResult GetWriterListByIdAsJson(int writerID)
        {
            WriterManager writerManager = new WriterManager(new EfWriterRepository());

            var writerValues = writerManager.GetByID(writerID);

            var writerValuesAsJson = JsonConvert.SerializeObject(writerValues);

            return Json(writerValuesAsJson);
        }
    }
}
