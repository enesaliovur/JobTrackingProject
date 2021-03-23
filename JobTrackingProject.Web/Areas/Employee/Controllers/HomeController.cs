using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Member.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class HomeController : Controller
    {
        private readonly INotificationService _notificationService;
        private readonly IDutyService _dutyService;

        private UserManager<AppUser> _userManager;



        public HomeController(INotificationService notificationService, IDutyService dutyService, UserManager<AppUser> userManager)
        {
            _notificationService = notificationService;
            _dutyService = dutyService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.OkunmayanBildirimSayisi = _notificationService.GetUnread(user.Id).Count;
            ViewBag.Görev = _dutyService.GetAll().Count;
           
                


            return View();

        }
    }


}