using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetListMessageByReceiverAndSenderForInBox(int id);
        List<Message> GetListMessageByReceiverAndSenderForSendBox(int id);
        List<Message> GetListMessageByReceiverAndSenderForNotification(int id);
        List<Message> ListForInBox(int id);
    }
}
