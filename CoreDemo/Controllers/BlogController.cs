using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = blogManager.GetBlogWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            //ViewBag.BlogID = id;
            var value = blogManager.GetBlogWithCommentsAndCategory(id);
            return View(value);
        }
        public IActionResult BlogByWriter()
        {
            var values = blogManager.GetBlogWithCategoryByWriter(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> categoryValues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }
                                                 ).ToList();
            ViewBag.CategoryValues = categoryValues;

            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Now;
                blog.WriterID = 1;
                blogManager.Add(blog);
                return RedirectToAction("BlogByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blog = blogManager.GetByID(id);
            blogManager.Delete(blog);
            return RedirectToAction("BlogByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var values = blogManager.GetByID(id);

            List<SelectListItem> categoryValues = (from x in categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString(),
                                                       Selected = false
                                                   }
                                                 ).ToList();
            ViewBag.CategoryValues = categoryValues;

            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            blogManager.Update(blog);
            return RedirectToAction("BlogByWriter", "Blog");
        }
    }
}
