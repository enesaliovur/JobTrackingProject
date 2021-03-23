using JobTrackingProject.Business.Interfaces;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification entity)
        {
             _notificationDal.Add(entity);
        }

        public void Delete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public List<Notification> GetAll()
        {
            return _notificationDal.GetAll();
        }

        public Notification GetId(int id)
        {
            return _notificationDal.GetId(id);
        }

        public List<Notification> GetUnread(int AppUserId)
        {
            return _notificationDal.GetUnread(AppUserId);
        }

        public void Update(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}
