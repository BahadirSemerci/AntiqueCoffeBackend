using BussiniesLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public List<Menu> GetBlogListWithCategory()
        {
            return _menuDal.GetListAll();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetList()
        {
            return _menuDal.GetListAll();
        }

        public string? GetMenuListWithCategory()
        {
       throw new NotImplementedException();
        }

        public void MenuAdd(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void MenuDelete(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void MenuUpdate(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
