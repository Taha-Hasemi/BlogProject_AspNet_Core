using BusinessLayer.Concrete;
using CoreDemo.Areas.Admin.Models;
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

            var values = categoryManager.GetCategoriesWithBlogs();

            List<CategoryClassForCharts> categoryValues = new List<CategoryClassForCharts>();

            foreach (var item in values)
            {
                CategoryClassForCharts categoryClassForCharts = new CategoryClassForCharts()
                {
                    categoryname = item.CategoryName,
                    categorycount = item.Blogs.Count
                };

                categoryValues.Add(categoryClassForCharts);
            }

            return Json(new { jsonList = categoryValues });
        }
    }
}
