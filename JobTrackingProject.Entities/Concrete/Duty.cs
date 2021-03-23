using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobTrackingProject.Entities.Concrete
{
    public class Duty : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool Condition { get; set; }

        [Column(TypeName ="ntext")]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int ImportanceId { get; set; }
        public Importance Importance { get; set; }

        public List<Report> Reports { get; set; }
    }
}
