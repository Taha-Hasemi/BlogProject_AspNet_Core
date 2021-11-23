using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageRepository());

        public IActionResult InBox()
        {
            int id = Convert.ToInt32(User.Identity.Name);
            var values = messageManager.ListForInBox(id);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = messageManager.GetByID(id);
            return View(value);
        }
    }
}
