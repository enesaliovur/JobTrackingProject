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
    [Authorize(Roles = "Admin")]
    public class NotificationController : Controller
    {


        private readonly INotificationService _notificationService;
        private readonly UserManager<AppUser> _userManager;

        public NotificationController(INotificationService notificationService, UserManager<AppUser> userManager)
        {
            _notificationService = notificationService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name);
            var notifications = _notificationService.GetUnread(user.Id);

            List<NotificationViewModel> models = new List<NotificationViewModel>();

            foreach (var notification in notifications)
            {
                NotificationViewModel model = new NotificationViewModel
                {
                    Id = notification.Id,
                    Description = notification.Description
                };
                models.Add(model);
            }
            return View(models);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var notification = _notificationService.GetId(id);
            notification.Condition = true;
            _notificationService.Update(notification);
            return RedirectToAction("Index");
        }
    }
}
