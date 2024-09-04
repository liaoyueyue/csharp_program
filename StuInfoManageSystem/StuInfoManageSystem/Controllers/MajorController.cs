using Microsoft.AspNetCore.Mvc;
using StuInfoManageSystem.Models;
using StuInfoManageSystem.Repositories;

namespace StuInfoManageSystem.Controllers
{
    public class MajorController(MajorRepo majorRepo) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Major model)
        {
            majorRepo.Insert(model);
            return RedirectToAction("Index");
        }
    }
}
