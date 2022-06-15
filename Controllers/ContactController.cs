using Microsoft.AspNetCore.Mvc;
using SimpleCompanyWebsite.Models;
using SimpleCompanyWebsite.Models.ViewModels;
using WAF.API.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;

namespace SimpleCompanyWebsite.Controllers
{
    public class ContactController : BaseController
    {
        public ContactController(WAFNativeContext wafCtx) : base(wafCtx)
        {
            wafContext = wafCtx;

        }
        public ActionResult Index()
        {
            if (cp.Settings.IsSet() && cp.ContactPage.IsSet())
            {

                ContactViewModel vm = new ContactViewModel
                {
                    Settings = cp.Settings.Get(),
                    Contact = cp.ContactPage.Get()
                };
                return View(vm);
            }
            else
            {
                return StatusCode(500, "Control panel missing settings or contactpage");
            }
        }

        [HttpPost]
        public ActionResult ContactForm(ContactQuery contact)
        {
            return Content("You just got in touch with us!");
        }
    }
}