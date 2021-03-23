using JobTrackingProject.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Entities.Concrete
{
    public class AppUser : IdentityUser<int>,IEntity
    {

        public string Name { get; set; } 
        public string Surname { get; set; }

        public string ImageUrl { get; set; } = "default.png";
        public List<Duty> Duties { get; set; }

        public List<Notification> Notifications { get; set; }
    }
}
