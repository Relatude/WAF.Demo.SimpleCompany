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
    public partial class Paragraph_Testimonial: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _headline;
        public virtual string Headline {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("fe305a34-5312-47cb-9349-5387f2dd3b50"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("fe305a34-5312-47cb-9349-5387f2dd3b50"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Testimonial> _testimonial;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Testimonial> Testimonial{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Testimonial>.GetPropValue(WAFID.GetDataValueId("ed2ddbf4-f985-4bd2-aa1c-9c8886fc052a"), ref _testimonial, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("9e9050f8-a3e7-4e99-a226-789abe083b67");
            }
        }

        public static int PropertyIdHeadline {
            get {
                return WAFID.GetPropertyId("c28bb8d1-86e5-409e-a934-581c9ed490a7");
            }
        }

        public static int DataValueIdHeadlineHeadline {
            get {
                return WAFID.GetDataValueId("fe305a34-5312-47cb-9349-5387f2dd3b50");
            }
        }

        public static int PropertyIdTestimonial {
            get {
                return WAFID.GetPropertyId("22c779d3-9029-4f8f-b42b-a8929348c780");
            }
        }

        public static int DataValueIdTestimonialTestimonial {
            get {
                return WAFID.GetDataValueId("ed2ddbf4-f985-4bd2-aa1c-9c8886fc052a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("c28bb8d1-86e5-409e-a934-581c9ed490a7")) {
                object init = Headline;
                return _headline;
            }
            else if (propertyId == WAFID.GetPropertyId("22c779d3-9029-4f8f-b42b-a8929348c780")) {
                object init = Testimonial;
                return _testimonial;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _headline = null;
            _testimonial = null;
            base.ResetPropertyValues();
        }
    }
}
