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
    public partial class Paragraph_Service: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _title;
        public virtual string Title {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("f375e6bf-3dd6-4d6b-b64e-87025e04335a"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("f375e6bf-3dd6-4d6b-b64e-87025e04335a"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Service> _services;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Service> Services{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Service>.GetValue(WAFID.GetDataValueId("a69790b6-4dce-489c-80e7-4db7dc7e273b"), ref _services, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("ea1cbbc0-ebf1-4201-a09f-ced1848597c1");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("897411c9-7f81-4dab-9335-a9a81e62dee5");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("f375e6bf-3dd6-4d6b-b64e-87025e04335a");
            }
        }

        public static int PropertyIdServices {
            get {
                return WAFID.GetPropertyId("a69790b6-4dce-489c-80e7-4db7dc7e273b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("897411c9-7f81-4dab-9335-a9a81e62dee5")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("a69790b6-4dce-489c-80e7-4db7dc7e273b")) {
                object init = Services;
                return _services;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _title = null;
            _services = null;
            base.ResetPropertyValues();
        }
    }
}
