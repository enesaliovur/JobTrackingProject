using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Interfaces
{
    public interface INotificationService : IGenericService<Notification>
    {
        public List<Notification> GetUnread(int AppUserId);
    }
}
