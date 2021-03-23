using JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Repositories
{
    public class EfNotificationRepository : EfGenericRepository<Notification>, INotificationDal
    {
        public List<Notification> GetUnread(int AppUserId)
        {
            using var context = new JobTrackingProjectContext();
            return context.Notifications.Where(I => I.AppUserId == AppUserId && !I.Condition).ToList();
        }
    }
}
