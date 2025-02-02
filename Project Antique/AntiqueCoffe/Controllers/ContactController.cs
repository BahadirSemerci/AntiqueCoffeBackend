using BussiniesLayer.Concrete;
using DataAccsessLayer.EntitiyFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AntiqueCoffe.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm= new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact c)
        {
           
            cm.ContactAdd(c);
            return RedirectToAction("Index", "Contact");
            
        }
    }
}
