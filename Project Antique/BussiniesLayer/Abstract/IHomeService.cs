using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Abstract
{
    public interface IHomeService
    {
        void HomeAdd(Home home);
        void HomeDelete(Home home);
        void HomeUpdate(Home home);
        List<Home> GetList();
        Home GetById(int id);
        List<Home> GetBlogListWithCategory();
    }
}
