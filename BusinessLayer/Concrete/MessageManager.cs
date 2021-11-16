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
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListMessageByReceiverAndSenderForInBox(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && x.MessageReceivers[0].WriterID == id);
        }

        public List<Message> GetListMessageByReceiverAndSenderForNotification(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && !x.MessageReadStatus && x.MessageReceivers[0].WriterID == id);
        }

        public List<Message> GetListMessageByReceiverAndSenderForSendBox(int id)
        {
            return _messageDal.GetListMessageByReceiverAndSender(x => x.MessageStatus && x.MessageSenders[0].WriterID == id);
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
