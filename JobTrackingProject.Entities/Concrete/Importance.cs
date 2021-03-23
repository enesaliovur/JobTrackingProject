using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Entities.Concrete
{
    public class Importance : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        
        public List<Duty> Duties { get; set; }

    }
}
