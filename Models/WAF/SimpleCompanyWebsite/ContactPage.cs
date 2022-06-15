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
    public partial class ContactPage: WAF.Engine.Content.SimpleCompanyWebsite.BaseItem {
        HTMLPropertyValue _formText;
        public virtual string FormText {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("e066e655-7e20-4c49-8e7a-e54224176c07"), ref _formText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("e066e655-7e20-4c49-8e7a-e54224176c07"), ref _formText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        HTMLPropertyValue _formContainer;
        public virtual string FormContainer {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("f81e2ca0-89d2-486c-9cfb-312da45af377"), ref _formContainer, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("f81e2ca0-89d2-486c-9cfb-312da45af377"), ref _formContainer, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ContactPage>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ContactPage>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ContactPage>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e");
            }
        }

        public static int PropertyIdFormText {
            get {
                return WAFID.GetPropertyId("5ea9f0ec-c925-4a98-8be4-47fc07163ee4");
            }
        }

        public static int DataValueIdFormTextFormText {
            get {
                return WAFID.GetDataValueId("e066e655-7e20-4c49-8e7a-e54224176c07");
            }
        }

        public static int PropertyIdFormContainer {
            get {
                return WAFID.GetPropertyId("01abd864-1525-4af6-8f8c-6b19d3af855c");
            }
        }

        public static int DataValueIdFormContainerFormContainer {
            get {
                return WAFID.GetDataValueId("f81e2ca0-89d2-486c-9cfb-312da45af377");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("5ea9f0ec-c925-4a98-8be4-47fc07163ee4")) {
                object init = FormText;
                return _formText;
            }
            else if (propertyId == WAFID.GetPropertyId("01abd864-1525-4af6-8f8c-6b19d3af855c")) {
                object init = FormContainer;
                return _formContainer;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _formText = null;
            _formContainer = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlContactPage {
        public static SqlTable Table {
            get {
                return new SqlTable("contact_page", WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString FormText {
                get {
                    return new SqlFieldLongString("form_text", Table, WAFID.GetDataValueId("e066e655-7e20-4c49-8e7a-e54224176c07"));
                }
            }

            public static SqlFieldLongString FormContainer {
                get {
                    return new SqlFieldLongString("form_container", Table, WAFID.GetDataValueId("f81e2ca0-89d2-486c-9cfb-312da45af377"));
                }
            }

        }
    }
    public class SqlAliasContactPage : SqlAlias {
        public SqlAliasContactPage()
            : base(SqlContactPage.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlContactPage.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString FormText {
            get {
                return new SqlExpressionFieldLongString(SqlContactPage.Field.FormText, this);
            }
        }

        public SqlExpressionFieldLongString FormContainer {
            get {
                return new SqlExpressionFieldLongString(SqlContactPage.Field.FormContainer, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlContactPage{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")); 
            }
        }

        public static AqlPropertyLongString FormText {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlContactPage.Field.FormText, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyLongString FormContainer {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlContactPage.Field.FormContainer, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyShortString HeaderSubtitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.HeaderSubtitle, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyShortString FontAwesome_IconString {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.FontAwesome_IconString, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean Top_Level_Is_Link {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.Top_Level_Is_Link, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasContactPage
        : WAF.Engine.Query.SimpleCompanyWebsite.AqlAliasBaseItem{

        public AqlAliasContactPage()
            : base(WAFID.GetContentClassId("0d9916cf-1f69-4109-8e13-8dc94947062e")) {

        }

        public AqlAliasContactPage(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString FormText {
            get {
                return new AqlExpressionPropertyLongString(AqlContactPage.FormText, this);
            }
        }

        public AqlExpressionPropertyLongString FormContainer {
            get {
                return new AqlExpressionPropertyLongString(AqlContactPage.FormContainer, this);
            }
        }

    }
}
