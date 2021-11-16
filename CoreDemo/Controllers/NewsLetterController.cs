using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        public IActionResult Index()
        {
            return View();
        }

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
