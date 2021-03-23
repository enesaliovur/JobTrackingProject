using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Models
{
    public class UpdateImportanceViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}
