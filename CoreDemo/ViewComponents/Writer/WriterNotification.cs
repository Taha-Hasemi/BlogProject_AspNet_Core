﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = notificationManager.GetListForWriter();
            return View(values);
        }
    }
}
