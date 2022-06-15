// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.SimpleCompanyWebsite;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.SimpleCompanyWebsite {
    [Serializable]
    public partial class SocialMediaLink: WAF.Engine.Content.InnerContentBase {
        LinkPropertyValue _link;
        public virtual LinkPropertyValue Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("82b78ea4-bd9b-458d-bba5-b4e2d304d20b"), ref _link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("374198d5-2ae5-4f72-b189-d5924647734e");
            }
        }

        public static int PropertyIdLink {
            get {
                return WAFID.GetPropertyId("6138a3b1-64ea-4d51-b368-dd35bb1caeb1");
            }
        }

        public static int DataValueIdLinkLink {
            get {
                return WAFID.GetDataValueId("82b78ea4-bd9b-458d-bba5-b4e2d304d20b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("6138a3b1-64ea-4d51-b368-dd35bb1caeb1")) {
                object init = Link;
                return _link;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _link = null;
            base.ResetPropertyValues();
        }
    }
}
