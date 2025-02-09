﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ICategoryService:IGenericService<Category>
    {
        int GetCategoryCount();
        List<Category> GetCategoriesWithBlogs();
    }
}
