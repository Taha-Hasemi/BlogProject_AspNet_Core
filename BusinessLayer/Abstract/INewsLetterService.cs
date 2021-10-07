using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsLetter);
        void DeleteNewsLetter(NewsLetter newsLetter);
        void UpdateNewsLetter(NewsLetter newsLetter);
        List<NewsLetter> GetList();
        NewsLetter GetByID(int id);
    }
}
