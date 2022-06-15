
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

    public partial class Project
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

        public string GetCssClasses()
        {

            string cssClasses = "";
            var setList = this.Related_Power_Types.GetAllSet();
            foreach (var num in setList)
            {
                cssClasses += " " + Enum.GetName(typeof(Power_Types_Enumeration), num).ToLower().Replace("_", "-");
            }



            return cssClasses;
        }

    }
}

