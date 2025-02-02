using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Abstract
{
    public interface IMenuRightService
    {
        void MenuRightAdd(MenuRight menuRight);
        void MenuRightDelete(MenuRight menuRight);
        void MenuRightUpdate(MenuRight menuRight);
        List<MenuRight> GetList();
        MenuRight GetById(int id);
        List<MenuRight> GetBlogListWithCategory();
    }
}
