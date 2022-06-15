using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;

namespace SimpleCompanyWebsite.Models.ViewModels {
    public class AllEmployeesViewModel {
        public List<Employee> Employees { get; set; }
        public EmployeesPage Page { get; set; }
    }
}