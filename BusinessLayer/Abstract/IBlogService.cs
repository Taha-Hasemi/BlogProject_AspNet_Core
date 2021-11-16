using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogWithCategory();
        List<Blog> GetLastThreeBlogWithCategory();
        List<Blog> GetBlogWithCategoryByWriter(int id);
        List<Blog> GetBlogWithCommentsAndCategory(int id);
        List<Blog> GetAllBlogWithCommentsAndCategory();
        List<Blog> ListBlogByWriter(int id);
        List<Blog> ListLastThreePost();
        int GetAllBlogsCount();
        int GetWriterBlogsCount(int writerID);
    }
}
