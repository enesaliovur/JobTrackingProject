using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Entities.Concrete
{
    public class Notification : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public bool Condition { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
