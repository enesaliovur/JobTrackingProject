using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface IDutyService : IGenericService<Duty>
    {
        public List<Duty> GetImportanceAndUnfinished();
        public List<Duty> GetAllTable();

        public List<Duty> GetDutyOfAppUser(int id);
        public Duty GetImportanceAndId(int id);
        public Duty GetReportsAndId(int id);
        public List<Duty> GetAllTable(Expression<Func<Duty, bool>> filter);
        public List<Duty> GetAllTableAndFinished(out int totalPage, int id, int activePage=1);
        public int GetUnassignedDuty();
        public int GetFinishedDuty();
    }
}
