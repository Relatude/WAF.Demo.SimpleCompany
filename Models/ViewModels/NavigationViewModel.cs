using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.SimpleCompanyWebsite;

namespace SimpleCompanyWebsite.Models.ViewModels {
    public class NavigationViewModel {
        public List<BaseItem> MenuItems { get; set; }
        public string Logo { get; set; }
    }
}