using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Layout
{
    public class LayoutLogin : ViewComponent
    {
        readonly UserManager<User> _userManager;

        public LayoutLogin(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult();

                ViewBag.Name = user.Name;
            }

            return View();
        }
    }
}
