using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Models
{
    public class UpdateDutyViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Görev Adı Boş Geçilemez")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Aciliyet Durumu Seçiniz")]

        [Display(Name = "Aciliyet")]
        public int ImportanceId { get; set; }

        [Required(ErrorMessage = "Açıklama Alanı Boş Geçilemez")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
}
