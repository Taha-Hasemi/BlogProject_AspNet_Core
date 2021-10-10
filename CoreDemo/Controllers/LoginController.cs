using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            var value = writerManager.GetWriter(writer);
            if (value != null)
            {
                HttpContext.Session.SetInt32("WriterID", writer.WriterID);
                HttpContext.Session.SetString("WriterName", writer.WriterName);
                HttpContext.Session.SetString("WriterMail", writer.WriterMail);
                return RedirectToAction("Index", "Blog");
            }
            return View();
        }
    }
}
