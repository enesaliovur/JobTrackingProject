using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using JobTrackingProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class DutyManager : IDutyService
    {
        private readonly IDutyDal _dutyDal;

        public DutyManager(IDutyDal dutyDal)
        {
            _dutyDal = dutyDal;
        }

        public void Add(Duty entity)
        {
            _dutyDal.Add(entity);
        }

        public void Delete(Duty entity)
        {
            _dutyDal.Delete(entity);
        }

        public List<Duty> GetAll()
        {
            return _dutyDal.GetAll();
        }

        public List<Duty> GetAllTable()
        {
            return _dutyDal.GetAllTable();
        }

        public List<Duty> GetAllTable(Expression<Func<Duty, bool>> filter)
        {
            return _dutyDal.GetAllTable(filter);
        }

        public List<Duty> GetAllTableAndFinished(out int totalPage, int id, int activePage)
        {
            return _dutyDal.GetAllTableAndFinished(out totalPage, id, activePage);
        }

        public List<Duty> GetDutyOfAppUser(int id)
        { 
            return _dutyDal.GetDutyOfAppUser(id);
        }

        public int GetFinishedDuty()
        {
            return _dutyDal.GetFinishedDuty();
        }

        public Duty GetId(int id)
        {
            return _dutyDal.GetId(id);
        }

        public Duty GetImportanceAndId(int id)
        {
            return _dutyDal.GetImportanceAndId(id);
        }

        public List<Duty> GetImportanceAndUnfinished()
        {
            return _dutyDal.GetImportanceAndUnfinished();
        }

        public Duty GetReportsAndId(int id)
        {
           return _dutyDal.GetReportsAndId(id);
        }

        public int GetUnassignedDuty()
        {
            return _dutyDal.GetUnassignedDuty();
        }

        public void Update(Duty entity)
        {
            _dutyDal.Update(entity);

        }
    }
}
