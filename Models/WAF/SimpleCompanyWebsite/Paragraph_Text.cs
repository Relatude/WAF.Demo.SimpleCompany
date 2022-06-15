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
    public partial class Paragraph_Text: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _headline;
        public virtual string Headline {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("85f60545-ed8e-436e-8129-73ed1baefd17"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("85f60545-ed8e-436e-8129-73ed1baefd17"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _text;
        public virtual string Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("554f6672-6812-4071-a6f5-e8a203fb9b9b"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("554f6672-6812-4071-a6f5-e8a203fb9b9b"), ref _text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("92565199-f47a-4d2f-82e2-d3960748f002");
            }
        }

        public static int PropertyIdHeadline {
            get {
                return WAFID.GetPropertyId("52f2fd9b-645b-4d98-92d8-c52339812142");
            }
        }

        public static int DataValueIdHeadlineHeadline {
            get {
                return WAFID.GetDataValueId("85f60545-ed8e-436e-8129-73ed1baefd17");
            }
        }

        public static int PropertyIdText {
            get {
                return WAFID.GetPropertyId("644975f8-e71f-41ec-bbe1-40cec4a12745");
            }
        }

        public static int DataValueIdTextText {
            get {
                return WAFID.GetDataValueId("554f6672-6812-4071-a6f5-e8a203fb9b9b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("52f2fd9b-645b-4d98-92d8-c52339812142")) {
                object init = Headline;
                return _headline;
            }
            else if (propertyId == WAFID.GetPropertyId("644975f8-e71f-41ec-bbe1-40cec4a12745")) {
                object init = Text;
                return _text;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _headline = null;
            _text = null;
            base.ResetPropertyValues();
        }
    }
}
