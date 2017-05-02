using CoffeeTracker.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTracker.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}