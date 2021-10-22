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
            _categoryDal.Delete(t);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.List(x => x.CategoryID == id).SingleOrDefault();
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
