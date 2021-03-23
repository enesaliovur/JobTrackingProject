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

namespace JobTrackingProject.Web.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class DutyController : Controller
    {
        private readonly IDutyService _dutyService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IReportService _reportService;




        public DutyController(IDutyService dutyService, UserManager<AppUser> userManager, IReportService reportService)
        {
            _dutyService = dutyService;
            _userManager = userManager;
            _reportService = reportService;
        }
        public async Task<IActionResult> Index(int activePage=1)
        {
            int totalPage;
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var duties = _dutyService.GetAllTableAndFinished(out totalPage, user.Id, activePage);
            ViewBag.totalPage = totalPage;
            ViewBag.activePage = activePage;
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
    }
}
