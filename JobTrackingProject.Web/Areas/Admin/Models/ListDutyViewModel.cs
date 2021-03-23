using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Models
{
    public class ListDutyViewModel
    {
        public int Id { get; set; }
        public Importance Importance { get; set; }

        public string Name { get; set; }

        public bool Condition { get; set; }

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<Report> Reports { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
