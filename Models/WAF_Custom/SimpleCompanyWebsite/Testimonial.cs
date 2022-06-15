
// WAF Custom. Add your own code here to customize the default behavior.
using System;
using WAF.Common;
using WAF.Data;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Data.Query;
using WAF.Data.Query.SimpleCompanyWebsite;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content.Native;
using WAF.Engine.Property;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Engine.Content.SimpleCompanyWebsite
{

    public partial class Testimonial
    {

        public override void OnInit()
        {

            base.OnInit();
        }

        public override void OnNew()
        {

            base.OnNew();
        }

        public override void OnBeforeInsert()
        {

            base.OnBeforeInsert();
        }

        public override void OnBeforeUpdate()
        {


            string name = "";

            name += this.DateOfTestimony.ToString("yyyy-MM-dd");

            if (!string.IsNullOrWhiteSpace(this.UserName))
            {
                name += " - " + this.UserName;
            }

            this.Name = name;

            base.OnBeforeUpdate();
        }

        public override void OnAfterInsert()
        {

            base.OnAfterInsert();
        }

        public override void OnAfterUpdate()
        {

            base.OnAfterUpdate();
        }

        public override void OnAfterDelete(bool permanently)
        {

            base.OnAfterDelete(permanently);
        }

    }
}

