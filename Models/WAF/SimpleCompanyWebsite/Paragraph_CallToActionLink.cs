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
    public partial class Paragraph_CallToActionLink: WAF.Engine.Content.InnerContentBase {
        LinkPropertyValue _link;
        public virtual LinkPropertyValue Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("16a1acf0-4116-4759-b6fc-13303a54c920"), ref _link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        ShortStringPropertyValue _linkText;
        public virtual string LinkText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("3ff269a8-d5fe-43d4-9d2c-c395d2d343a3"), ref _linkText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("3ff269a8-d5fe-43d4-9d2c-c395d2d343a3"), ref _linkText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _bannerText;
        public virtual string BannerText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("a0dc6243-96c4-4337-bb18-78f1f5259ae6"), ref _bannerText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("a0dc6243-96c4-4337-bb18-78f1f5259ae6"), ref _bannerText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("12a94109-7b36-41b9-8a8e-510e5a94dd94");
            }
        }

        public static int PropertyIdLink {
            get {
                return WAFID.GetPropertyId("7e225b4e-d7ea-40d3-b96c-a22fcd6abcf7");
            }
        }

        public static int DataValueIdLinkLink {
            get {
                return WAFID.GetDataValueId("16a1acf0-4116-4759-b6fc-13303a54c920");
            }
        }

        public static int PropertyIdLinkText {
            get {
                return WAFID.GetPropertyId("916876cb-25b5-45ff-9b91-e045580e66ca");
            }
        }

        public static int DataValueIdLinkTextLinkText {
            get {
                return WAFID.GetDataValueId("3ff269a8-d5fe-43d4-9d2c-c395d2d343a3");
            }
        }

        public static int PropertyIdBannerText {
            get {
                return WAFID.GetPropertyId("75b43348-d2b1-4df9-a81b-a4c6928c0bbd");
            }
        }

        public static int DataValueIdBannerTextBannerText {
            get {
                return WAFID.GetDataValueId("a0dc6243-96c4-4337-bb18-78f1f5259ae6");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("7e225b4e-d7ea-40d3-b96c-a22fcd6abcf7")) {
                object init = Link;
                return _link;
            }
            else if (propertyId == WAFID.GetPropertyId("916876cb-25b5-45ff-9b91-e045580e66ca")) {
                object init = LinkText;
                return _linkText;
            }
            else if (propertyId == WAFID.GetPropertyId("75b43348-d2b1-4df9-a81b-a4c6928c0bbd")) {
                object init = BannerText;
                return _bannerText;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _link = null;
            _linkText = null;
            _bannerText = null;
            base.ResetPropertyValues();
        }
    }
}
