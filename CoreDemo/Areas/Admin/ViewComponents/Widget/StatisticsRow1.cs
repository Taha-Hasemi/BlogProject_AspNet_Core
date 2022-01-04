using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Widget
{
    public class StatisticsRow1 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            ContactManager contactManager = new ContactManager(new EfContactRepository());
            CommentManager commentManager = new CommentManager(new EfCommentRepository());

            ViewBag.blogsCount = blogManager.GetList().Count();
            ViewBag.messagesCount = contactManager.GetList().Count();
            ViewBag.commentsCount = commentManager.GetList().Count();

            string apiKey = "3fd1d250fdd52185a4274ebddc679a9b";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=Tabriz&mode=xml&units=metric&appid=" + apiKey;

            XDocument xmlDoc = XDocument.Load(connection);

            ViewBag.Temperature = xmlDoc.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
