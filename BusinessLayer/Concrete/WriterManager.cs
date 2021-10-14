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

        public Writer GetWriter(Writer writer)
        {
            return _writerDal.List(x => (x.WriterName == writer.WriterName || x.WriterMail == writer.WriterMail) && x.WriterPassword == writer.WriterPassword).FirstOrDefault();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }
    }
}
