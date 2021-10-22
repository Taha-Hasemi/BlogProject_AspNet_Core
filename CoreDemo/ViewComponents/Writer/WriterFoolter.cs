using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterFoolter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
