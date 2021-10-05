using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Layout
{
    public class WriterLastPosts : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = blogManager.ListBlogByWriter(id);
            return View(values);
        }
    }
}
