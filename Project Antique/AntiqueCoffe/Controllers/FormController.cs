using BussiniesLayer.Concrete;
using DataAccsessLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace AntiqueCoffe.Controllers
{
    public class FormController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            var values=cm.GetList();
            return View(values);
        }
    }
}
