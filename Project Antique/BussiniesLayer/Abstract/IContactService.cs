using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussiniesLayer.Abstract
{
    public  interface IContactService
        
    {
        void ContactAdd(Contact contact);
        List<Contact> GetList();
       Contact GetById(int id);
    }
}
