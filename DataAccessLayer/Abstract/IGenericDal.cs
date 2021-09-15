using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T GetByID(int id);
    }
}
