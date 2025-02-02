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
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public List<Home> GetBlogListWithCategory()
        {
            return _homeDal.GetListAll();
        }

        public Home GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Home> GetList()
        {
            return _homeDal.GetListAll();
        }

        public void HomeAdd(Home home)
        {
            throw new NotImplementedException();
        }

        public void HomeDelete(Home home)
        {
            throw new NotImplementedException();
        }

        public void HomeUpdate(Home home)
        {
            throw new NotImplementedException();
        }
    }
}
