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
    public partial class Service: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _fontAwesome_String;
        public virtual string FontAwesome_String {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("e0105f6c-711d-4079-8162-c286c2a456c7"), ref _fontAwesome_String, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("e0105f6c-711d-4079-8162-c286c2a456c7"), ref _fontAwesome_String, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _title;
        public virtual string Title {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5b59e42b-98d8-4def-99f3-1e524a2e41d7"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5b59e42b-98d8-4def-99f3-1e524a2e41d7"), ref _title, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _blurb;
        public virtual string Blurb {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("b1cafab1-267d-41bb-b2d4-e4339c41c7a5"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("b1cafab1-267d-41bb-b2d4-e4339c41c7a5"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("a7137566-33ff-49af-bfae-653994675fb1");
            }
        }

        public static int PropertyIdFontAwesome_String {
            get {
                return WAFID.GetPropertyId("916eec50-ba3b-494a-9f0d-b2be86eec574");
            }
        }

        public static int DataValueIdFontAwesome_StringFontAwesomeString {
            get {
                return WAFID.GetDataValueId("e0105f6c-711d-4079-8162-c286c2a456c7");
            }
        }

        public static int PropertyIdTitle {
            get {
                return WAFID.GetPropertyId("5bb1dcd0-881d-4358-8953-4000fe6809a4");
            }
        }

        public static int DataValueIdTitleTitle {
            get {
                return WAFID.GetDataValueId("5b59e42b-98d8-4def-99f3-1e524a2e41d7");
            }
        }

        public static int PropertyIdBlurb {
            get {
                return WAFID.GetPropertyId("2662028d-70db-498b-bd15-4580accf6c3a");
            }
        }

        public static int DataValueIdBlurbBlurb {
            get {
                return WAFID.GetDataValueId("b1cafab1-267d-41bb-b2d4-e4339c41c7a5");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("916eec50-ba3b-494a-9f0d-b2be86eec574")) {
                object init = FontAwesome_String;
                return _fontAwesome_String;
            }
            else if (propertyId == WAFID.GetPropertyId("5bb1dcd0-881d-4358-8953-4000fe6809a4")) {
                object init = Title;
                return _title;
            }
            else if (propertyId == WAFID.GetPropertyId("2662028d-70db-498b-bd15-4580accf6c3a")) {
                object init = Blurb;
                return _blurb;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _fontAwesome_String = null;
            _title = null;
            _blurb = null;
            base.ResetPropertyValues();
        }
    }
}
