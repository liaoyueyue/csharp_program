using Microsoft.AspNetCore.Mvc;
using StuInfoManageSystem.Services;
using StuInfoManageSystem.ViewModels;

namespace StuInfoManageSystem.Controllers
{
    public class GradeController(GradeService gradeService) : Controller
    {
        public IActionResult Index()
        {
            return View(gradeService.GetList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(GradeViewModel model)
        {
            if (ModelState.IsValid)
            {
                gradeService.Insert(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(Guid id)
        {
            GradeViewModel model;
            try
            {
                model = gradeService.Get(id);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(GradeViewModel model)
        {
            if (ModelState.IsValid)
            {
                gradeService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
