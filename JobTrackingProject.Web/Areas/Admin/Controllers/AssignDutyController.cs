using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AssignDutyController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IDutyService _dutyService;
        private readonly UserManager<AppUser> _userManager;
        private readonly INotificationService _notificationService;

        public AssignDutyController(IAppUserService appUserService, IDutyService dutyService, UserManager<AppUser> userManager, INotificationService notificationService)
        {
            _appUserService = appUserService;
            _dutyService = dutyService;
            _userManager = userManager;
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "DutyAssignment";

            List<Duty> duties = _dutyService.GetAllTable();
            List<ListDutyViewModel> models = new List<ListDutyViewModel>();
             
            foreach(var duty in duties)
            {
                ListDutyViewModel model = new ListDutyViewModel
                {
                    Id=duty.Id,
                    Description=duty.Description,
                    Reports=duty.Reports,
                    Name=duty.Name,
                    AppUser=duty.AppUser,
                    CreationDate=duty.CreationDate,
                    Importance=duty.Importance

                };
                models.Add(model);
            }
                
           

            return View(models);
        }

        public IActionResult ListEmployees(int id,string s,int activePage=1)
        {
            TempData["Active"] = "DutyAssignment";


            int totalPages;
            var duty = _dutyService.GetImportanceAndId(id);
            
            var emplooyes = _appUserService.GetMember(out totalPages,s,activePage) ;
          
            ViewBag.TotalPages = totalPages;
            ViewBag.search = s;

            List<AppUserViewModel> appUserListModels = new List<AppUserViewModel>();

            foreach (var item in emplooyes)
            {
                AppUserViewModel userModel = new AppUserViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    ImageUrl = item.ImageUrl,
                    Email = item.Email
                };
                appUserListModels.Add(userModel);
            }
            ViewBag.Employees = appUserListModels;
            DutyViewModel model = new DutyViewModel
            {
                Id = duty.Id,
                Description = duty.Description,
                CreationDate = duty.CreationDate,
                Name = duty.Name,
                Importance = duty.Importance
            };
            return View(model);
        }

      
        public IActionResult AssignEmplooyes(AssignEmployeesViewModel model)
        {
            var user = _userManager.Users.First(I => I.Id == model.EmplooyeId);
            var duty = _dutyService.GetImportanceAndId(model.DutyId);
            AppUserViewModel userModel = new AppUserViewModel
            {
                Id=user.Id,
                Name=user.Name,
                Surname=user.Surname,
                Email=user.Email,
                ImageUrl=user.ImageUrl
            };

            DutyViewModel dutyModel = new DutyViewModel
            {
                Id = duty.Id,
                Name=duty.Name,
                Importance=duty.Importance,
                Condition=duty.Condition,
                CreationDate=duty.CreationDate,
                Description=duty.Description
            };

            ListAssignEmployeesViewModel listAssignEmployeesViewModel = new ListAssignEmployeesViewModel
            {
                AppUserViewModel=userModel,
                DutyViewModel=dutyModel
            };

            return View(listAssignEmployeesViewModel);
        } 

        [HttpPost]
        public IActionResult ListEmployees(AssignEmployeesViewModel model)
        {
            var updateDuty = _dutyService.GetId(model.DutyId);
            updateDuty.AppUserId = model.EmplooyeId;

           
            _dutyService.Update(updateDuty);

            
                Notification notification = new Notification
                {
                   AppUserId = model.EmplooyeId,
                   Description=$"{updateDuty.Name} adlı iş için görevlendirildiniz"

                };
                _notificationService.Add(notification);
            

            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            var duty = _dutyService.GetReportsAndId(id);
            ListDutyViewModel model = new ListDutyViewModel
            {
                Id=duty.Id,
                Description=duty.Description,
                Condition=duty.Condition,
                Reports=duty.Reports,
                Name=duty.Name,
                AppUser=duty.AppUser
                
            };
            return View(model);
        }
    }
}
