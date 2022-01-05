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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer Get(Writer t)
        {
            return _writerDal.List(x => (x.WriterName == t.WriterName || x.WriterMail == t.WriterMail) && x.WriterPassword == t.WriterPassword).FirstOrDefault();
        }

        public void Add(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void Delete(Writer t)
        {
            t.WriterStatus = false;
            _writerDal.Update(t);
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public Writer GetByID(int id)
        {
            return _writerDal.List(x => x.WriterID == id).FirstOrDefault();
        }
    }
}
