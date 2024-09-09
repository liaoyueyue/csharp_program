﻿using Microsoft.AspNetCore.Mvc;
using StuInfoManageSystem.Models;
using StuInfoManageSystem.Repositories;
using StuInfoManageSystem.Services;
using StuInfoManageSystem.ViewModels;

namespace StuInfoManageSystem.Controllers
{
    public class MajorController(MajorService majorService) : Controller
    {
        public IActionResult Index()
        {
            return View(majorService.GetList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MajorViewModel model)
        {
            if (ModelState.IsValid)
            {
                majorService.Insert(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(Guid id)
        {

            MajorViewModel model;
            try
            {
                model = majorService.Get(id);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MajorViewModel model)
        {
            if (ModelState.IsValid)
            {
                majorService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
