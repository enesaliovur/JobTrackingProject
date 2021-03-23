using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserViewModel model = new AppUserViewModel
            {
                Id=user.Id,
                Name=user.Name,
                Email=user.Email,
                Surname=user.Surname,
                ImageUrl=user.ImageUrl

            };
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Index(AppUserViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (model.Picture != null)
            {
                //Uygulamanın calistigi yer
                var uygulamaninCalistigiYer = Directory.GetCurrentDirectory();
                var uzanti = Path.GetExtension(model.Picture.FileName);
                var pictureName = Guid.NewGuid() + uzanti;
                var kaydedilecekYer = uygulamaninCalistigiYer + "/wwwroot/img/" + pictureName;
                //uyg//wwwroot/img/resimad.uzanti

                using var stream = new FileStream(kaydedilecekYer, FileMode.Create);
                user.ImageUrl = pictureName;

                await model.Picture.CopyToAsync(stream);
            }

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
          
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

    }
}
