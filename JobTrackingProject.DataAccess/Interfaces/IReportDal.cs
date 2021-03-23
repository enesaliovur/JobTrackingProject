using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface IReportDal : IGenericDal<Report>
    {
        public Report GetDutyAndId(int id);

        public int GetTotalReports();
    }
}
