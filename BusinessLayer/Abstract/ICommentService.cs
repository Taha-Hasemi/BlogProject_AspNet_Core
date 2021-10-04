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
        void AddComment(Comment category);
        void DeleteComment(Comment category);
        void UpdateComment(Comment category);
        List<Comment> GetList();
        Comment GetByID(int id);
        Comment GetByBlog(int id);
        List<Comment> ListByBlog(int id);
    }
}
