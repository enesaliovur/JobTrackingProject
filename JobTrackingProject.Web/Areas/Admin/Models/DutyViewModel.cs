using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Models
{
    public class DutyViewModel
    {
        public int Id { get; set; }
        public Importance Importance { get; set; }
        public int ImportanceId { get; set; }
        public string Name { get; set; }

        public bool Condition { get; set; }


        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
