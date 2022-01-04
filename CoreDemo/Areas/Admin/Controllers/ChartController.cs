using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

            List<Category> categoryValues = categoryManager.GetCategoriesWithBlogs();

            return Json(new { jsonList = categoryValues });
        }
    }
}
