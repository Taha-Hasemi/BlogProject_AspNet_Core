using Microsoft.AspNetCore.Mvc;
using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class AddComment : ViewComponent
    {
        [HttpGet]
        public IViewComponentResult Invoke(int blogID)
        {
            EntityLayer.Concrete.Comment comment = new EntityLayer.Concrete.Comment();
            ViewBag.BlogID = blogID;
            return View(comment);
        }
    }
}
