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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetByID(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageID == id).First();
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListMessageByReceiverAndSenderForInBox(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && x.RecieverID == id);
        }

        public List<Message> GetListMessageByReceiverAndSenderForNotification(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && !x.MessageReadStatus && x.RecieverID == id);
        }

        public List<Message> GetListMessageByReceiverAndSenderForSendBox(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && x.RecieverID == id);
        }

        public List<Message> ListForInBox(int id)
        {
            return _messageDal.List(x => x.RecieverID == id && x.MessageStatus).OrderByDescending(x => x.MessageID).ToList();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
