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
    public partial class Paragraph_Employee: WAF.Engine.Content.InnerContentBase {
        ShortStringPropertyValue _headline;
        public virtual string Headline {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("f8c69c12-d31c-44eb-927b-b27dd43c0398"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("f8c69c12-d31c-44eb-927b-b27dd43c0398"), ref _headline, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.EmployeeContainer> _employees;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.EmployeeContainer> Employees{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.EmployeeContainer>.GetValue(WAFID.GetDataValueId("e9980337-9f07-4624-be3c-0fe382f5429a"), ref _employees, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("4ae79785-a951-44c3-bee2-2222f513753c");
            }
        }

        public static int PropertyIdHeadline {
            get {
                return WAFID.GetPropertyId("e7c3e7eb-b22c-48a1-9c29-52aa241c8a8b");
            }
        }

        public static int DataValueIdHeadlineHeadline {
            get {
                return WAFID.GetDataValueId("f8c69c12-d31c-44eb-927b-b27dd43c0398");
            }
        }

        public static int PropertyIdEmployees {
            get {
                return WAFID.GetPropertyId("e9980337-9f07-4624-be3c-0fe382f5429a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("e7c3e7eb-b22c-48a1-9c29-52aa241c8a8b")) {
                object init = Headline;
                return _headline;
            }
            else if (propertyId == WAFID.GetPropertyId("e9980337-9f07-4624-be3c-0fe382f5429a")) {
                object init = Employees;
                return _employees;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _headline = null;
            _employees = null;
            base.ResetPropertyValues();
        }
    }
}
