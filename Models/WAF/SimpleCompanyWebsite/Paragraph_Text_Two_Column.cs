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
    public partial class Paragraph_Text_Two_Column: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _left_Column_Headline;
        public virtual string Left_Column_Headline {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("4b230858-5686-4b26-b82e-df1881956df8"), ref _left_Column_Headline, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("4b230858-5686-4b26-b82e-df1881956df8"), ref _left_Column_Headline, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _left_Column_Text;
        public virtual string Left_Column_Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("5573f91c-2bf7-47f3-a843-bc3d8b88909c"), ref _left_Column_Text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("5573f91c-2bf7-47f3-a843-bc3d8b88909c"), ref _left_Column_Text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ShortStringPropertyValue _right_Column_Headline;
        public virtual string Right_Column_Headline {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("2789e0ec-40e6-4087-aef3-f2616ecc4b34"), ref _right_Column_Headline, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("2789e0ec-40e6-4087-aef3-f2616ecc4b34"), ref _right_Column_Headline, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _right_Column_Text;
        public virtual string Right_Column_Text {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("fd8cfae2-8684-42c6-a444-6cfc2deef21a"), ref _right_Column_Text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("fd8cfae2-8684-42c6-a444-6cfc2deef21a"), ref _right_Column_Text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("618b2529-f69b-4e58-bc11-48f1917b339b");
            }
        }

        public static int PropertyIdLeft_Column_Headline {
            get {
                return WAFID.GetPropertyId("e0ec85b7-ab09-4fc9-bf5a-cd4ab4e6b050");
            }
        }

        public static int DataValueIdLeft_Column_HeadlineLeftColumnHeadline {
            get {
                return WAFID.GetDataValueId("4b230858-5686-4b26-b82e-df1881956df8");
            }
        }

        public static int PropertyIdLeft_Column_Text {
            get {
                return WAFID.GetPropertyId("0e01d547-4ccf-4429-9c78-5dcc628ac0f5");
            }
        }

        public static int DataValueIdLeft_Column_TextLeftColumnText {
            get {
                return WAFID.GetDataValueId("5573f91c-2bf7-47f3-a843-bc3d8b88909c");
            }
        }

        public static int PropertyIdRight_Column_Headline {
            get {
                return WAFID.GetPropertyId("59541c95-50e4-48cb-92b8-4f595111a0f4");
            }
        }

        public static int DataValueIdRight_Column_HeadlineRightColumnHeadline {
            get {
                return WAFID.GetDataValueId("2789e0ec-40e6-4087-aef3-f2616ecc4b34");
            }
        }

        public static int PropertyIdRight_Column_Text {
            get {
                return WAFID.GetPropertyId("ffe27a56-1aa3-473d-b684-192c68ab2887");
            }
        }

        public static int DataValueIdRight_Column_TextRightColumnText {
            get {
                return WAFID.GetDataValueId("fd8cfae2-8684-42c6-a444-6cfc2deef21a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("e0ec85b7-ab09-4fc9-bf5a-cd4ab4e6b050")) {
                object init = Left_Column_Headline;
                return _left_Column_Headline;
            }
            else if (propertyId == WAFID.GetPropertyId("0e01d547-4ccf-4429-9c78-5dcc628ac0f5")) {
                object init = Left_Column_Text;
                return _left_Column_Text;
            }
            else if (propertyId == WAFID.GetPropertyId("59541c95-50e4-48cb-92b8-4f595111a0f4")) {
                object init = Right_Column_Headline;
                return _right_Column_Headline;
            }
            else if (propertyId == WAFID.GetPropertyId("ffe27a56-1aa3-473d-b684-192c68ab2887")) {
                object init = Right_Column_Text;
                return _right_Column_Text;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _left_Column_Headline = null;
            _left_Column_Text = null;
            _right_Column_Headline = null;
            _right_Column_Text = null;
            base.ResetPropertyValues();
        }
    }
}
