using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICommentService
    {
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
        void UpdateComment(Comment comment);
        List<Comment> GetList();
        Comment GetByID(int id);
        Comment GetByBlog(int id);
        List<Comment> ListByBlog(int id);
    }
}
