using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Widget
{
    public class StatisticsRow1 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            ContactManager contactManager = new ContactManager(new EfContactRepository());
            CommentManager commentManager = new CommentManager(new EfCommentRepository());

            ViewBag.blogsCount = blogManager.GetList().Count();
            ViewBag.messagesCount = contactManager.GetList().Count();
            ViewBag.commentsCount = commentManager.GetList().Count();

            return View();
        }
    }
}
