using Microsoft.AspNetCore.Mvc;

namespace StuInfoManageSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
