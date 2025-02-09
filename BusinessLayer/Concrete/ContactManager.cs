﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
