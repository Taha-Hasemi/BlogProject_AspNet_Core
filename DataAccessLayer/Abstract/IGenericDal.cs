﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class, IEntity, new()
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
