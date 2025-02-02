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
    public class MenuRightManager : IMenuRightService
    {
        IMenuRightDal _menuRightdal;

        public MenuRightManager(IMenuRightDal menuRightDal)
        {
            _menuRightdal = menuRightDal;
        }

        public List<MenuRight> GetBlogListWithCategory()
        {
            return _menuRightdal.GetListAll();
        }

        public MenuRight GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MenuRight> GetList()
        {
           return _menuRightdal.GetListAll();
        }

        public void MenuRightAdd(MenuRight menuRight)
        {
            throw new NotImplementedException();
        }

        public void MenuRightDelete(MenuRight menuRight)
        {
            throw new NotImplementedException();
        }

        public void MenuRightUpdate(MenuRight menuRight)
        {
            throw new NotImplementedException();
        }
    }
}
