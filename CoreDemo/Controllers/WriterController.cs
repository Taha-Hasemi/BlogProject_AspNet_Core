using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult WriterProfile()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult EditWriterProfile()
        {
            int id = Convert.ToInt32(User.Identity.Name);
            var value = writerManager.GetByID(id);
            return View(value);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult EditWriterProfile(Writer writer)
        {
            WriterValidator validations = new WriterValidator();
            ValidationResult result = validations.Validate(writer);
            if (result.IsValid)
            {
                writerManager.Update(writer);
                return View();
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
