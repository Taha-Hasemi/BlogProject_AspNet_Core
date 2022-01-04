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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role t)
        {
            throw new NotImplementedException();
        }

        public Role GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Role t)
        {
            throw new NotImplementedException();
        }
    }
}
