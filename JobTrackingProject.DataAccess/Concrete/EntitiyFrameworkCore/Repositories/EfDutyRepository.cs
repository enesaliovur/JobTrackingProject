using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfDutyRepository : EfGenericRepository<Duty>, IDutyDal
    {
        public List<Duty> GetImportanceAndUnfinished()
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Include(I => I.Importance).Where(I => !I.Condition).OrderByDescending(I => I.CreationDate).ToList();



        }
        public List<Duty> GetAllTable()
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Include(I => I.Importance).Include(I => I.Reports).Include(I => I.AppUser).Where(I => !I.Condition).
              OrderByDescending(I => I.CreationDate).ToList();
        }

        public Duty GetImportanceAndId(int id)
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Include(I => I.Importance).FirstOrDefault(I => !I.Condition && I.Id == id);
        }

        public List<Duty> GetDutyOfAppUser(int id)
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Where(I => I.AppUserId == id).ToList();
        }

        public Duty GetReportsAndId(int id)
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Include(I => I.AppUser).Include(I => I.Reports).Where(I => I.Id == id).FirstOrDefault();
        }

        public List<Duty> GetAllTable(Expression<Func<Duty, bool>> filter)
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Include(I => I.Importance).Include(I => I.Reports).Include(I => I.AppUser).Where(filter).
              OrderByDescending(I => I.CreationDate).ToList();
        }

        public List<Duty> GetAllTableAndFinished(out int totalPage, int id, int activePage)
        {
            using var context = new JobTrackingProjectContext();
            var returnValue = context.Duties.Include(I => I.Importance).Include(I => I.Reports).Include(I => I.AppUser).Where(I => I.AppUserId == id && I.Condition).
                 OrderByDescending(I => I.CreationDate);
            totalPage = (int)Math.Ceiling((double)returnValue.Count() / 3);
            return returnValue.Skip((activePage - 1) * 3).Take(3).ToList();
        }

        public int GetUnassignedDuty()
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Count(I => I.AppUserId == null && !I.Condition);
        }

        public int GetFinishedDuty()
        {
            using var context = new JobTrackingProjectContext();
            return context.Duties.Count(I => I.Condition);
        }
    }
}
