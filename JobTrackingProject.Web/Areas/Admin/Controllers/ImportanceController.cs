using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ImportanceController : Controller
    {
        private readonly IImportanceService _urgencyService;

        public ImportanceController(IImportanceService urgencyService)
        {
            _urgencyService = urgencyService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "Urgency";
            List<Importance> importances = _urgencyService.GetAll();
            List<ImportanceViewModel> models = new List<ImportanceViewModel>();

            foreach (var importance in importances)
            {
                ImportanceViewModel model = new ImportanceViewModel
                {
                    Id = importance.Id,
                    Description = importance.Description
                };
                models.Add(model);

            }

            return View(models);
        }




        public IActionResult AddImportance()
        {
            TempData["Active"] = "Importance";
            return View(new AddImportanceViewModel());
        }

        [HttpPost]
        public IActionResult AddImportance(AddImportanceViewModel model)
        {
            if (ModelState.IsValid)
            {
                Importance importance = new Importance
                {

                    Description = model.Description

                };
                _urgencyService.Add(importance);
                return RedirectToAction("Index");

            }
            return View(model);
        }


        public IActionResult UpdateImportance(int id)
        {
            TempData["Active"] = "Importance";
            var importance = _urgencyService.GetId(id);
            UpdateImportanceViewModel model = new UpdateImportanceViewModel
            {
                Id = importance.Id,
                Description = importance.Description
            };

            return View(model);
        }

        [HttpPost]

        public IActionResult UpdateImportance(UpdateImportanceViewModel model)
        {
            if (ModelState.IsValid)
            {
                Importance importance = new Importance
                {
                    Id = model.Id,
                    Description = model.Description
                };
                _urgencyService.Update(importance);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteImportance(int id)
        {
            var importance = _urgencyService.GetId(id);
            _urgencyService.Delete(importance);
            return RedirectToAction("Index");
        }
    }
}
