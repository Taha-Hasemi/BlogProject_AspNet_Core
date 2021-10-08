using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.About
{
    public class AboutSocialMedia : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
