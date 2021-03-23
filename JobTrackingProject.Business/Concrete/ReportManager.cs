using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void Add(Report entity)
        {
            _reportDal.Add(entity);
        }

        public void Delete(Report entity)
        {
            _reportDal.Delete(entity);
        }

        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }

        public Report GetDutyAndId(int id)
        {
            return _reportDal.GetDutyAndId(id);
        }

        public Report GetId(int id)
        {
          return _reportDal.GetId(id);
        }

        public int GetTotalReports()
        {
            return _reportDal.GetTotalReports();
        }

        public void Update(Report entity)
        {
            _reportDal.Update(entity);
        }
    }
}
