using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Engine.Query.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Controllers
{
    public class BaseController: Controller 
    {
        protected ControlPanel cp;
        protected WAFNativeContext wafContext;

        public BaseController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;

            cp = WAFRuntime.Engine.SystemSession.Query<ControlPanel>()
                .Where(AqlControlPanel.SiteId == wafContext.Session.SiteId)
                .Execute()
                .FirstOrDefault();



            ViewBag.cp = cp;
        }

    }
}
