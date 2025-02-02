using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrette;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntitiyFreamwork
{
    public class EfMenuRepository : GenericRepository<Menu>, IMenuDal
    {
        public List<Menu> GetListWithCategory()
        {
            throw new NotImplementedException();
        }
    }
}
