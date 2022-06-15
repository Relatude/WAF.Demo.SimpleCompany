using Microsoft.AspNetCore.Mvc;
using SimpleCompanyWebsite.Models.ViewModels;
using WAF.API.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;
using WAF.Presentation.Web;

namespace SimpleCompanyWebsite.Controllers
{
    public class EmployeeController : BaseController
    {
        public EmployeeController(WAFNativeContext wafCtx): base(wafCtx)
        {
            wafContext = wafCtx;

        }

        public ActionResult ListAll()
        {

            var employees = wafContext.Session.Query<Employee>().Execute();

            AllEmployeesViewModel vm = new AllEmployeesViewModel()
            {
                Employees = employees,
                Page = wafContext.Session.Query<EmployeesPage>().Execute().SingleOrDefault()
            };

            return View(vm);
        }
    }
}