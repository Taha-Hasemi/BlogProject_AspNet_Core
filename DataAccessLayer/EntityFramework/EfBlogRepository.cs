using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetBlogWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.BlogStatus).OrderByDescending(x => x.BlogID).ToList();
            }
        }

        public List<Blog> GetBlogWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.WriterID == id && x.BlogStatus).OrderByDescending(x => x.BlogID).ToList();
            }
        }
    }
}
