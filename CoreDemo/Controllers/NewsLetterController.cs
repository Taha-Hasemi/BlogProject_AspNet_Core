using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubScribeMail(NewsLetter newsLetter)
        {
            try
            {
                newsLetter.MailStatus = true;
                await newsLetterManager.InsertNewsLetterMail(newsLetter);
                return Json(new ResultModel { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new ResultModel { Success = false, Message = ex.Message });
            }
        }
    }
}
