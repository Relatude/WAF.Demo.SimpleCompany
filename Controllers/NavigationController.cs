using Microsoft.AspNetCore.Mvc;
using SimpleCompanyWebsite.Models.ViewModels;
using WAF.API.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Engine.Property;
using WAF.Engine.Query.SimpleCompanyWebsite;

namespace SimpleCompanyWebsite.Controllers
{
    public class NavigationController : BaseController
    {
        public NavigationController(WAFNativeContext wafCtx) : base(wafCtx)
        {
            wafContext = wafCtx;
        }
        //public ActionResult Footer()
        //{
        //    if (cp.Settings.IsSet())
        //        return View(cp.Settings.Get());
        //    else
        //        return new EmptyResult();
        //}

        public ActionResult MainMenu()
        {

            HierarchicalContent mainMenu;
            if (cp.MainMenu.IsSet())
            {
                mainMenu = cp.MainMenu.Get();

                var cats = mainMenu.Children.Query<BaseItem>()
                    .Where(AqlBaseItem.ShowInMenu == true)
                    .Execute();


                var adjust = new ImageAdjustments();
                adjust.CanvasX = 128;
                adjust.CanvasY = 106;

                string logo = cp.Logo.GetUrl(adjust);

                NavigationViewModel vm = new NavigationViewModel()
                {
                    MenuItems = cats,
                    Logo = logo
                };


                return View(vm);
            }

            return View();
        }


    }
}