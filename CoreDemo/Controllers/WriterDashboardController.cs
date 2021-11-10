using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterDashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.AllBlogsCount = blogManager.GetAllBlogsCount();
            ViewBag.WriterBlogsCount = blogManager.GetWriterBlogsCount(1);
            ViewBag.CategoryCount = categoryManager.GetCategoryCount();
            return View();
        }
    }
}
