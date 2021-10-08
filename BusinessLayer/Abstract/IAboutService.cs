using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void AddAbout(About about);
        void DeleteAbout(About about);
        void UpdateAbout(About about);
        List<About> GetList();
        About GetByID(int id);
    }
}
