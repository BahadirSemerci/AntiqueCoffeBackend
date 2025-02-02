using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Abstract{
    public  interface IMenuService
    {
        void MenuAdd(Menu menu);
        void MenuDelete(Menu menu);
        void MenuUpdate(Menu menu);
        List<Menu> GetList();
        Menu GetById(int id);
        List<Menu> GetBlogListWithCategory();
    }
}
