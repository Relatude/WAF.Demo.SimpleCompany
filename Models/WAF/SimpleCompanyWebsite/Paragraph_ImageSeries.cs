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
    public partial class Paragraph_ImageSeries: WAF.Engine.Content.InnerContentBase {
        InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Paragraph_Image> _images;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Paragraph_Image> Images{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Paragraph_Image>.GetValue(WAFID.GetDataValueId("8f2afe8b-1d7a-4a80-bed1-3a6e97cbd597"), ref _images, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("decf5c3d-3575-4e3c-92b8-9f3e0523b793");
            }
        }

        public static int PropertyIdImages {
            get {
                return WAFID.GetPropertyId("8f2afe8b-1d7a-4a80-bed1-3a6e97cbd597");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("8f2afe8b-1d7a-4a80-bed1-3a6e97cbd597")) {
                object init = Images;
                return _images;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _images = null;
            base.ResetPropertyValues();
        }
    }
}
