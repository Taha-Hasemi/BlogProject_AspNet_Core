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

        public List<Blog> GetBlogWithCategory()
        {
            return _blogDal.GetBlogWithCategory();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.List(x => x.BlogID == id && x.BlogStatus).SingleOrDefault();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.List(x => x.BlogID == id && x.BlogStatus);
        }
        public List<Blog> GetList()
        {
            return _blogDal.List(x => x.BlogStatus);
        }

        public List<Blog> ListBlogByWriter(int id)
        {
            return _blogDal.List(x => x.WriterID == id && x.BlogStatus);
        }

        public List<Blog> ListLastThreePost()
        {
            return _blogDal.List(x => x.BlogStatus).Take(4).OrderByDescending(x => x.BlogID).ToList();
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            t.BlogStatus = false;
            _blogDal.Update(t);
        }

        public void Update(Blog t)
        {
            _blogDal.Update(t);
        }

        public List<Blog> GetBlogWithCategoryByWriter(int id)
        {
            return _blogDal.GetBlogWithCategoryByWriter(id);
        }

        public List<Blog> GetLastThreeBlogWithCategory()
        {
            return _blogDal.GetLastThreeBlogWithCategory();
        }
    }
}
