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
    public partial class Paragraph_Image: WAF.Engine.Content.InnerContentBase {
        FilePropertyValue _image;
        public virtual FilePropertyValue Image {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("9cddc339-1633-4ef9-bbc0-92356ecd4b0c"),WAFID.GetDataValueId("a35c8fbd-4572-4de0-adce-f2af8a98b878"),WAFID.GetDataValueId("c10326ad-a115-40ec-9b27-2c1cc6e3fcf6"),WAFID.GetDataValueId("0d083e92-3a8a-4be6-a2a8-dae54f55f83f"),WAFID.GetDataValueId("1a6d0116-9284-41b5-9fc3-c299f0dfbf8a"),WAFID.GetDataValueId("37e6025d-fa1f-4a3a-96a0-5546379d14f1"), ref _image, this, WAFID.GetDataValueId("89876a0c-2269-478f-8e64-7ad2f1bc4423")); }
        }
      
        ShortStringPropertyValue _image_Text;
        public virtual string Image_Text {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("59e15bb5-358e-4dfd-8581-c9af634c79c7"), ref _image_Text, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("59e15bb5-358e-4dfd-8581-c9af634c79c7"), ref _image_Text, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("61a4bc12-1d7f-42c4-9f22-cbe5873529cd");
            }
        }

        public static int PropertyIdImage {
            get {
                return WAFID.GetPropertyId("89876a0c-2269-478f-8e64-7ad2f1bc4423");
            }
        }

        public static int DataValueIdImageImageFilename {
            get {
                return WAFID.GetDataValueId("a35c8fbd-4572-4de0-adce-f2af8a98b878");
            }
        }

        public static int DataValueIdImageImageTypeName {
            get {
                return WAFID.GetDataValueId("c10326ad-a115-40ec-9b27-2c1cc6e3fcf6");
            }
        }

        public static int DataValueIdImageImageExtension {
            get {
                return WAFID.GetDataValueId("0d083e92-3a8a-4be6-a2a8-dae54f55f83f");
            }
        }

        public static int DataValueIdImageImageBytes {
            get {
                return WAFID.GetDataValueId("1a6d0116-9284-41b5-9fc3-c299f0dfbf8a");
            }
        }

        public static int DataValueIdImageImageInfo {
            get {
                return WAFID.GetDataValueId("37e6025d-fa1f-4a3a-96a0-5546379d14f1");
            }
        }

        public static int DataValueIdImageImageInt {
            get {
                return WAFID.GetDataValueId("9cddc339-1633-4ef9-bbc0-92356ecd4b0c");
            }
        }

        public static int PropertyIdImage_Text {
            get {
                return WAFID.GetPropertyId("40e2da4c-9995-4be1-804c-d4a845e34e95");
            }
        }

        public static int DataValueIdImage_TextImageText {
            get {
                return WAFID.GetDataValueId("59e15bb5-358e-4dfd-8581-c9af634c79c7");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("89876a0c-2269-478f-8e64-7ad2f1bc4423")) {
                object init = Image;
                return _image;
            }
            else if (propertyId == WAFID.GetPropertyId("40e2da4c-9995-4be1-804c-d4a845e34e95")) {
                object init = Image_Text;
                return _image_Text;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _image = null;
            _image_Text = null;
            base.ResetPropertyValues();
        }
    }
}
