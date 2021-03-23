using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.Web.Areas.Admin.Models
{
    public class AppUserViewModel
    {

      
        public int Id { get; set; }
        [Display(Name ="Ad")]
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad gereklidir")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email gereklidir")]
        public string Email { get; set; }
        [Display(Name = "Fotoğraf")]
        [Required(ErrorMessage = "Fotoğraf gereklidir")]
        public string ImageUrl { get; set; }
        public IFormFile Picture { get; set; }

        public List<Notification> Notifications { get; set; }

    }
}
