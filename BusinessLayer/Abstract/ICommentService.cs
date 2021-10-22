using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICommentService : IGenericService<Comment>
    {
        Comment GetByBlog(int id);
        List<Comment> ListByBlog(int id);
    }
}
