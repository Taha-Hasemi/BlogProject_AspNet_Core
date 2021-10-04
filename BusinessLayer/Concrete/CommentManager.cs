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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment category)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment category)
        {
            throw new NotImplementedException();
        }

        public Comment GetByBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListByBlog(int id)
        {
            return _commentDal.List(x => x.BlogID == id);
        }

        public void UpdateComment(Comment category)
        {
            throw new NotImplementedException();
        }
    }
}
