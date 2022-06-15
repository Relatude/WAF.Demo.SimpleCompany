using Microsoft.AspNetCore.Mvc;
using SimpleCompanyWebsite.Models.ViewModels;
using WAF.API.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Controllers
{
    public class ProjectController : BaseController
    {
        public ProjectController(WAFNativeContext wafCtx): base(wafCtx)
        {
            wafContext = wafCtx;
        }
        // GET: Portfolio
        public ActionResult Index()
        {
            return View(wafContext.Request.GetContent<Project>());
        }


        public ActionResult Portfolio()
        {
            var projectList = wafContext.Session.Query<Project>().Execute();
            var filterOptions = Enum.GetNames(typeof(Power_Types_Enumeration));
            //var filterOptions = Enum.GetNames(typeof(Power_Types_Enumeration)).ToList();
            //List<string> filterOptions = new List<string>();
            //foreach (string s in filterOptionsArray) {
            //    filterOptions.Add(s.Replace("_", " "));
            //}




            var viewModel = new PortfolioViewModel
            {
                ProjectList = projectList,
                FiltersList = filterOptions,
                Portfolio = cp.Portfolio.Get()
            };
            return View(viewModel);
        }
    }
}