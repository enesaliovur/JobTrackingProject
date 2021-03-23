using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfReportRepository : EfGenericRepository<Report>, IReportDal
    {
        public Report GetDutyAndId(int id)
        {
            using var context = new JobTrackingProjectContext();
            return context.Reports.Include(I => I.Duty).ThenInclude(I=>I.Importance).Where(I => I.Id == id).FirstOrDefault();
        }

        public int GetTotalReports()
        {
            using var context = new JobTrackingProjectContext();
            return context.Reports.Count();
        }
    }
}
