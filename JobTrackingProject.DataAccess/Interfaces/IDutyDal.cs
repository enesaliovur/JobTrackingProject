using JobTrackingProject.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface IDutyDal : IGenericDal<Duty>
    {
        public List<Duty> GetImportanceAndUnfinished();

        public List<Duty> GetAllTable(Expression<Func<Duty,bool>>filter);
        public List<Duty> GetAllTable();
        public List<Duty> GetAllTableAndFinished(out int totalPage, int id, int activePage);
        public Duty GetImportanceAndId(int id);

        public List<Duty> GetDutyOfAppUser(int id);

        public Duty GetReportsAndId(int id);

        public int GetUnassignedDuty();

        public int GetFinishedDuty();
    }
}
