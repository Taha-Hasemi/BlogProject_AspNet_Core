using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        void DeleteContact(Contact contact);
        void UpdateContact(Contact contact);
        List<Contact> GetList();
        Contact GetByID(int id);
    }
}
