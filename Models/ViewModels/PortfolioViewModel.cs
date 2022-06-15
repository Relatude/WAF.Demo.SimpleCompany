using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;

namespace SimpleCompanyWebsite.Models.ViewModels {
    public class PortfolioViewModel {
        public List<Project> ProjectList { get; set; }
        public string[] FiltersList { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}