using Microsoft.AspNetCore.Mvc;

namespace Foo.Web.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
