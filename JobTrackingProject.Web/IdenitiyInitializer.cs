using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web
{
    public class IdenitiyInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                AppRole role = new AppRole
                {
                    Name = "Admin"
                   
                };
                await roleManager.CreateAsync(role);
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                AppRole role = new AppRole
                {
                    Name = "Member"

                };
                await roleManager.CreateAsync(role);
            }

            var adminUser = await userManager.FindByNameAsync("enesaliovur");
            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    Name = "Enes Ali",
                    Surname = "Övür",
                    UserName = "enesaliovur",
                    Email = "enesaliovur@gmail.com"
                };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");

            }
        }
    }
}
