using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public async Task<IActionResult> Index(Writer writer)
        {
            writer.WriterName = writer.WriterMail;
            var value = writerManager.Get(writer);
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,value.WriterName),
                    new Claim(ClaimTypes.Email,value.WriterMail),
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Blog");
            }
            return View();



            //if (value != null)
            //{
            //    HttpContext.Session.SetInt32("WriterID", value.WriterID);
            //    HttpContext.Session.SetString("WriterName", value.WriterName);
            //    HttpContext.Session.SetString("WriterMail", value.WriterMail);
            //    return RedirectToAction("Index", "Blog");
            //}
            //return View();
        }
    }
}
