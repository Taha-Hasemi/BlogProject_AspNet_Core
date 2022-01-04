using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents.Widget
{
    public class StatisticsRow4 : ViewComponent
    {
        AdminManager adminMangaer = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            int id = int.Parse(User.Identity.Name);
            id = 2;
            ViewBag.AdminValues = adminMangaer.GetByID(id);

            return View();
        }
    }
}
