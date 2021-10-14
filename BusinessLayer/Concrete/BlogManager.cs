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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetBlogWithCategory()
        {
            return _blogDal.GetBlogWithCategory();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.List(x => x.BlogID == id).SingleOrDefault();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.List(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.List();
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> ListBlogByWriter(int id)
        {
            return _blogDal.List(x => x.WriterID == id);
        }

        public List<Blog> ListLastThreePost()
        {
            return _blogDal.List().Take(4).OrderByDescending(x => x.BlogID).ToList();
        }
    }
}
