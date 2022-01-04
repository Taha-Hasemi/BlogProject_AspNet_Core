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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void Delete(Category t)
        {
            t.CategoryStatus = false;
            _categoryDal.Update(t);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.List(x => x.CategoryID == id).SingleOrDefault();
        }

        public List<Category> GetCategoriesWithBlogs()
        {
            return _categoryDal.GetCategoriesWithBlogs();
        }

        public int GetCategoryCount()
        {
            return _categoryDal.List().Count();
        }

        public List<Category> GetList()
        {
            return _categoryDal.List(x => x.CategoryStatus);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
