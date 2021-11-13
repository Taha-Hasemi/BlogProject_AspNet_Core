using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetListForWriter()
        {
            return _notificationDal.List(x => x.NotificationStatus).OrderByDescending(x => x.NotificationID).ToList();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
