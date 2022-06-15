using SimpleCompanyWebsite.Models.ViewModels;
using WAF.API.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Engine.Property;
using WAF.Engine.Query.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Code.Helpers
{
    public class NavigationHelper
    {

        public static Settings? GetSettings(WAFNativeContext wafContext)
        {
            var cp = WAFRuntime.Engine.SystemSession.Query<ControlPanel>()
                .Where(AqlControlPanel.SiteId == wafContext.Session.SiteId)
                .Execute()
                .FirstOrDefault();

            if (cp.Settings.IsSet())
                return cp.Settings.Get();
            else
                return null;
        }

        public static NavigationViewModel? GetMainMenuViewModel(WAFNativeContext wafContext)
        {
            var cp = WAFRuntime.Engine.SystemSession.Query<ControlPanel>()
             .Where(AqlControlPanel.SiteId == wafContext.Session.SiteId)
             .Execute()
             .FirstOrDefault();

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


                return vm;
            }
            return null;
        }
    }
}
