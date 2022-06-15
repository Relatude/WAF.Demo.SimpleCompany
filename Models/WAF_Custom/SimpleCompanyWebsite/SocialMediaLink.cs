
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

    public partial class SocialMediaLink
    {

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

        public string GetFontAwesomeIcon()
        {

            if (this.Link.LinkType == LinkType.Email)
            {
                return "fa-envelope";
            }
            else
            {
                if (LinkContainsString("facebook.com"))
                    return "fa-facebook";

                if (LinkContainsString("twitter.com"))
                    return "fa-twitter";

                if (LinkContainsString("github.com"))
                    return "fa-github";

                if (LinkContainsString("instagram.com"))
                    return "fa-instagram";

                if (LinkContainsString("flickr.com"))
                    return "fa-flickr";

                if (LinkContainsString("youtube.com"))
                    return "fa-youtube";

                if (LinkContainsString("linkedin.com"))
                    return "fa-linkedin";

            }





            return "";
        }

        private bool LinkContainsString(string s)
        {
            var lowerCaseLinkValue = this.Link.ToString().ToLower();
            if (lowerCaseLinkValue.Contains(s))
            {
                return true;
            }
            return false;
        }
    }
}

