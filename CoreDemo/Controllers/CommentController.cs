using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            Comment comment = new Comment();
            return PartialView(comment);
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment comment)
        {
            comment.BlogID = 4;
            comment.CommentStatus = true;
            comment.CommentDate = DateTime.Now;
            commentManager.AddComment(comment);
            return RedirectToAction("BlogReadAll","Blog",new { id = comment.BlogID });
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.ListByBlog(id);
            return PartialView(values);
        }
    }
}
