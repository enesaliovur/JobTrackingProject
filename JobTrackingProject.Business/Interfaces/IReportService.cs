using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface IReportService : IGenericService<Report>
    {
        public Report GetDutyAndId(int id);
        public int GetTotalReports();
    }
}
