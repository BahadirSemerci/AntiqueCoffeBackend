using AntiqueCoffe.ModelViews;
using BussiniesLayer.Concrete;
using DataAccsessLayer.EntitiyFreamwork;
using Microsoft.AspNetCore.Mvc;


namespace AntiqueCoffe.Controllers
{
    public class MenuController : Controller
    {
        MenuManager bm = new MenuManager(new EfMenuRepository());
        MenuRightManager bm2 = new MenuRightManager(new EfMenuRightRepository());
        HomeManager HomeManager = new HomeManager(new EfHomeRepository());
        public IActionResult Index()
        {
            var menuValues = bm.GetBlogListWithCategory();
            var menuRightValues = bm2.GetBlogListWithCategory();
            var homeValues = HomeManager.GetBlogListWithCategory();
            var viewModel = new MenuModelViews
            {
                Menus = menuValues,
                MenuRights = menuRightValues,
                Homes= homeValues
            };
            return View(viewModel);
        }
       
    }
}
