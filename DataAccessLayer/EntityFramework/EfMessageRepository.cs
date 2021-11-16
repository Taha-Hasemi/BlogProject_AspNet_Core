using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetListMessageByReceiverAndSender(Expression<Func<Message, bool>> filter)
        {
            using (var c = new Context())
            {
                return c.Messages.Include(x => x.MessageReceivers).ThenInclude(x => x.Writer).Include(x => x.MessageSenders).ThenInclude(x => x.Writer).Where(filter).OrderByDescending(x => x.MessageID).ToList();
            }
        }
    }
}
