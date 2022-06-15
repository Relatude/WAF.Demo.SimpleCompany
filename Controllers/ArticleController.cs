using Microsoft.AspNetCore.Mvc;
using WAF.API.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Controllers
{
    public class ArticleController : Controller
    {
        private WAFNativeContext wafContext;

        public ArticleController(WAFNativeContext wafCtx)
        {
            wafContext = wafCtx;

        }

        public ActionResult Index()
        {
            return View(wafContext.Request.GetContent<Article>());
        }

    }
}