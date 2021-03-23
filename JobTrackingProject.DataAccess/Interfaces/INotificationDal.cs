using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        List<Notification> GetUnread(int AppUserId);

    }
}
