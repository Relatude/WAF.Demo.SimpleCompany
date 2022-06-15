using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Controllers
{
    public class FrontpageController : Controller
    {
        private WAFNativeContext wafContext;
        public FrontpageController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;
        }
        // GET: Frontpage
        public ActionResult Index()
        {
            return View(wafContext.Request.GetContent<Frontpage>());
        }
    }
}