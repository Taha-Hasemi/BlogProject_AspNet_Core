using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Widget
{
    public class StatisticsRow2 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());

            ViewBag.getLastThreeBlog = blogManager.GetLastThreeBlog();
            ViewBag.getLastThreeNotification = notificationManager.GetLastThreeNotification();

            return View();
        }
    }
}
