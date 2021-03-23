using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Employee.Models
{
    public class AddReportViewModel
    {

        
 

        [Required(ErrorMessage ="Açıklama alanı boş geçilemez")]
        [Display(Name ="Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Detay")]
        [Required(ErrorMessage = "Detay alanı boş geçilemez")]
        public string Details { get; set; }
        public Duty Duty { get; set; }
        public int DutyId { get; set; }
      
    }
}
