using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Page404(int code)
        {
            return View();
        }
    }
}
