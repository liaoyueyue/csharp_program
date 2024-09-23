using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StuInfoManageSystem.Identity;
using StuInfoManageSystem.Services;
using StuInfoManageSystem.ViewModels;

namespace StuInfoManageSystem.Controllers
{
    [Authorize(Roles = nameof(UserRole.Admin))]
    public class ClassController(ClassService classService) : Controller
    {
        public IActionResult Index()
        {
            return View(classService.GetList());
        }

        public IActionResult Delete(Guid id)
        {
            try
            {
                classService.Delete(id);
                return Ok("删除成功");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Add()
        {
            return View(classService.GetSelectListModel());
        }

        [HttpPost]
        public IActionResult Add(ClassViewModel model)
        {
            if (ModelState.IsValid)
            {
                classService.Insert(model);
                return RedirectToAction("Index");
            }
            ClassViewModel selectListModel = classService.GetSelectListModel();
            model.Majors = selectListModel.Majors;
            model.Grades = selectListModel.Grades;
            return View(model);
        }

        public IActionResult Edit(Guid id)
        {
            ClassViewModel model;
            try
            {
                model = classService.GetEditModel(id);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ClassViewModel model)
        {
            if (ModelState.IsValid)
            {
                classService.Update(model);
                return RedirectToAction("Index");
            }
            ClassViewModel selectListModel = classService.GetSelectListModel();
            model.Majors = selectListModel.Majors;
            model.Grades = selectListModel.Grades;
            return View(model);
        }
    }
}
