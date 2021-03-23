using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Web.Areas.Admin.Models;
using JobTrackingProject.Web.Areas.Employee.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class AssignDutyController : Controller
    {
        private readonly IDutyService _dutyService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IReportService _reportService;
        private readonly INotificationService _notificationService;

        public AssignDutyController(IDutyService dutyService, UserManager<AppUser> userManager, IReportService reportService, INotificationService notificationService)
        {
            _dutyService = dutyService;
            _userManager = userManager;
            _reportService = reportService;
            _notificationService = notificationService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var duties = _dutyService.GetAllTable(I => I.AppUserId == user.Id && !I.Condition);
            List<ListDutyViewModel> models = new List<ListDutyViewModel>();
            foreach (var duty in duties)
            {
                ListDutyViewModel model = new ListDutyViewModel
                {
                    Id = duty.Id,
                    Description = duty.Description,
                    Name = duty.Name,
                    CreationDate = duty.CreationDate,
                    Condition = duty.Condition,
                    Reports = duty.Reports,
                    Importance = duty.Importance,
                    AppUser = duty.AppUser,
                };
                models.Add(model);

            }


            return View(models);
        }

        public IActionResult AddReport(int id)
        {
            var duty = _dutyService.GetImportanceAndId(id);

            AddReportViewModel model = new AddReportViewModel()
            {
                DutyId = id,
                Duty = duty

            };
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> AddReport(AddReportViewModel model)
        {
            if (ModelState.IsValid)
            {
                Report report = new Report
                {

                    DutyId = model.DutyId,
                    Description = model.Description,
                    Details = model.Details
                };

                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);
                foreach (var admin in adminUserList)
                {
                    Notification notification = new Notification
                    {
                        Description = $"{activeUser.Name} {activeUser.Surname} yeni bir rapor yazdı",
                        AppUserId=admin.Id,

                    };
                    _notificationService.Add(notification);
                }

                _reportService.Add(report);
                return RedirectToAction("Index");



            }
            return View(model);
        }
        public IActionResult UpdateReport(int id)
        {
            var report = _reportService.GetDutyAndId(id);
            UpdateReportViewModel model = new UpdateReportViewModel
            {
                DutyId = report.DutyId,
                Description = report.Description,
                Details = report.Details,
                Duty = report.Duty,
                Id = report.Id
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateReport(UpdateReportViewModel model)
        {
            if (ModelState.IsValid)
            {
                var report = _reportService.GetId(model.Id);

                report.Description = model.Description;
                report.Details = model.Details;
                _reportService.Update(report);
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public async Task<IActionResult> DutyComplete(int id)
        {
            var duty = _dutyService.GetId(id);
            duty.Condition = true;
            _dutyService.Update(duty);

            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
            var activeUser = await _userManager.FindByNameAsync(User.Identity.Name);
            foreach (var admin in adminUserList)
            {
                Notification notification = new Notification
                {
                    Description = $"{activeUser.Name} {activeUser.Surname} {duty.Name} görevini tamamladı ",
                    AppUserId = admin.Id,

                };
                _notificationService.Add(notification);
            }
            return RedirectToAction("Index");
        }
    }
}
