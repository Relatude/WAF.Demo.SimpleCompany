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
    public partial class EmployeeContainer: WAF.Engine.Content.InnerContentBase {
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Employee> _employee;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Employee> Employee{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Employee>.GetPropValue(WAFID.GetDataValueId("ed539856-4301-4b91-9d42-24a128c7b16a"), ref _employee, this);}
        }
      
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("30c4716f-70c2-460e-ad1e-c6cc6a07d5a0");
            }
        }

        public static int PropertyIdEmployee {
            get {
                return WAFID.GetPropertyId("0d1416d4-e6b0-4662-aa27-63c8591bd491");
            }
        }

        public static int DataValueIdEmployeeEmployee {
            get {
                return WAFID.GetDataValueId("ed539856-4301-4b91-9d42-24a128c7b16a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("0d1416d4-e6b0-4662-aa27-63c8591bd491")) {
                object init = Employee;
                return _employee;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _employee = null;
            base.ResetPropertyValues();
        }
    }
}
