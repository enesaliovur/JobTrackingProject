using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DutyController : Controller
    {
       private readonly IDutyService _dutyService;
       private readonly IImportanceService _importanceService;

        public DutyController(IDutyService dutyService, IImportanceService importanceService)
        {
            _dutyService = dutyService;
            _importanceService = importanceService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "Duty";
            List<Duty> duties = _dutyService.GetImportanceAndUnfinished();
            List<DutyViewModel> models = new List<DutyViewModel>();

            foreach (var duty in duties)
            {
                DutyViewModel model = new DutyViewModel
                {
                    Id = duty.Id,
                    Importance=duty.Importance,
                   
                    ImportanceId = duty.ImportanceId,
                    Description = duty.Description,
                    Name = duty.Name,
                    Condition = duty.Condition,
                    CreationDate = duty.CreationDate

                };
                models.Add(model);
            }

            return View(models);
        }
        public IActionResult AddDuty()
        {
            ViewBag.Importances = new SelectList(_importanceService.GetAll(), "Id", "Description");
            return View(new AddDutyViewModel());
        }

        [HttpPost]
        public IActionResult AddDuty(AddDutyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Duty duty = new Duty
                {
                    Name=model.Name,
                    Description=model.Description,
                    ImportanceId = model.ImportanceId
                };
                _dutyService.Add(duty);
                return RedirectToAction("Index");
            }
            return View(model);

        }

        public IActionResult UpdateDuty(int id)
        {
           
            var duty = _dutyService.GetId(id);
            ViewBag.Importances = new SelectList(_importanceService.GetAll(), "Id", "Description",duty.ImportanceId);
            UpdateDutyViewModel model = new UpdateDutyViewModel
            {
                Name = duty.Name,
                Description = duty.Description,
                ImportanceId = duty.ImportanceId
            };
            return View(model);
        }

        [HttpPost]
      
        public IActionResult UpdateDuty(UpdateDutyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Duty duty = new Duty
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    ImportanceId = model.ImportanceId
                };
                _dutyService.Update(duty);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteDuty(int id)
        {
            var duty = _dutyService.GetId(id);
            _dutyService.Delete(duty);
            return RedirectToAction("Index");
        }
    }


}
