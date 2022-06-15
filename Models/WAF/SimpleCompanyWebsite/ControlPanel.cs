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
    public partial class ControlPanel: WAF.Engine.Content.Native.HierarchicalContent {
        NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> _mainMenu;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder> MainMenu{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.Native.HierarchicalFolder>.GetPropValue(WAFID.GetDataValueId("19089f1a-921a-4a8f-86f2-d8946a41fc3b"), ref _mainMenu, this);}
        }
      
        FilePropertyValue _logo;
        public virtual FilePropertyValue Logo {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("4d5323d5-bbd9-4573-a338-ae96005702cd"),WAFID.GetDataValueId("5a68b4ae-5353-4838-b433-0428562c89b1"),WAFID.GetDataValueId("58059509-8af1-4fea-9515-ea191c903515"),WAFID.GetDataValueId("06490a0a-f4f4-4191-831e-990ba4b01924"),WAFID.GetDataValueId("50743e87-0e7b-4630-a163-e5b5c9c3453c"),WAFID.GetDataValueId("8b3fe78e-8ca3-4f32-81b3-80c57f6517bd"), ref _logo, this, WAFID.GetDataValueId("e4711120-f81a-44c7-9e23-cb5ae6a58879")); }
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Frontpage> _frontpage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Frontpage> Frontpage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Frontpage>.GetPropValue(WAFID.GetDataValueId("d8c00707-fd16-45a5-8027-b5ea0a00fb20"), ref _frontpage, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Portfolio> _portfolio;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Portfolio> Portfolio{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Portfolio>.GetPropValue(WAFID.GetDataValueId("afda55d8-163f-406d-b257-24cfee6fca15"), ref _portfolio, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Settings> _settings;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Settings> Settings{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.Settings>.GetPropValue(WAFID.GetDataValueId("02ee5d9a-6aa7-4306-889c-ae0da30a4803"), ref _settings, this);}
        }
      
        NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.ContactPage> _contactPage;
        public virtual NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.ContactPage> ContactPage{
        get { EnsureContentDataIndependence(); return NodeParentPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.ContactPage>.GetPropValue(WAFID.GetDataValueId("f58c2730-7860-464b-977e-1e974881d4f5"), ref _contactPage, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<ControlPanel>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<ControlPanel>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<ControlPanel>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1");
            }
        }

        public static int PropertyIdMainMenu {
            get {
                return WAFID.GetPropertyId("22e11c88-afd4-437c-a9c0-33713fbf8fed");
            }
        }

        public static int DataValueIdMainMenuMainMenu {
            get {
                return WAFID.GetDataValueId("19089f1a-921a-4a8f-86f2-d8946a41fc3b");
            }
        }

        public static int PropertyIdLogo {
            get {
                return WAFID.GetPropertyId("e4711120-f81a-44c7-9e23-cb5ae6a58879");
            }
        }

        public static int DataValueIdLogoLogoFilename {
            get {
                return WAFID.GetDataValueId("5a68b4ae-5353-4838-b433-0428562c89b1");
            }
        }

        public static int DataValueIdLogoLogoTypeName {
            get {
                return WAFID.GetDataValueId("58059509-8af1-4fea-9515-ea191c903515");
            }
        }

        public static int DataValueIdLogoLogoExtension {
            get {
                return WAFID.GetDataValueId("06490a0a-f4f4-4191-831e-990ba4b01924");
            }
        }

        public static int DataValueIdLogoLogoBytes {
            get {
                return WAFID.GetDataValueId("50743e87-0e7b-4630-a163-e5b5c9c3453c");
            }
        }

        public static int DataValueIdLogoLogoInfo {
            get {
                return WAFID.GetDataValueId("8b3fe78e-8ca3-4f32-81b3-80c57f6517bd");
            }
        }

        public static int DataValueIdLogoLogoInt {
            get {
                return WAFID.GetDataValueId("4d5323d5-bbd9-4573-a338-ae96005702cd");
            }
        }

        public static int PropertyIdFrontpage {
            get {
                return WAFID.GetPropertyId("0ecaef16-d4a6-43de-b7c5-0eaecb9721c3");
            }
        }

        public static int DataValueIdFrontpageFrontpage {
            get {
                return WAFID.GetDataValueId("d8c00707-fd16-45a5-8027-b5ea0a00fb20");
            }
        }

        public static int PropertyIdPortfolio {
            get {
                return WAFID.GetPropertyId("9db543ce-65d3-4fef-aa2f-1964f80e4431");
            }
        }

        public static int DataValueIdPortfolioPortfolio {
            get {
                return WAFID.GetDataValueId("afda55d8-163f-406d-b257-24cfee6fca15");
            }
        }

        public static int PropertyIdSettings {
            get {
                return WAFID.GetPropertyId("f88a1017-af1f-46f7-a0ee-36f7c6f05329");
            }
        }

        public static int DataValueIdSettingsSettings {
            get {
                return WAFID.GetDataValueId("02ee5d9a-6aa7-4306-889c-ae0da30a4803");
            }
        }

        public static int PropertyIdContactPage {
            get {
                return WAFID.GetPropertyId("b06389e6-fe3c-4004-a635-ac6170c03e8e");
            }
        }

        public static int DataValueIdContactPageContactPage {
            get {
                return WAFID.GetDataValueId("f58c2730-7860-464b-977e-1e974881d4f5");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("22e11c88-afd4-437c-a9c0-33713fbf8fed")) {
                object init = MainMenu;
                return _mainMenu;
            }
            else if (propertyId == WAFID.GetPropertyId("e4711120-f81a-44c7-9e23-cb5ae6a58879")) {
                object init = Logo;
                return _logo;
            }
            else if (propertyId == WAFID.GetPropertyId("0ecaef16-d4a6-43de-b7c5-0eaecb9721c3")) {
                object init = Frontpage;
                return _frontpage;
            }
            else if (propertyId == WAFID.GetPropertyId("9db543ce-65d3-4fef-aa2f-1964f80e4431")) {
                object init = Portfolio;
                return _portfolio;
            }
            else if (propertyId == WAFID.GetPropertyId("f88a1017-af1f-46f7-a0ee-36f7c6f05329")) {
                object init = Settings;
                return _settings;
            }
            else if (propertyId == WAFID.GetPropertyId("b06389e6-fe3c-4004-a635-ac6170c03e8e")) {
                object init = ContactPage;
                return _contactPage;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _mainMenu = null;
            _logo = null;
            _frontpage = null;
            _portfolio = null;
            _settings = null;
            _contactPage = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlControlPanel {
        public static SqlTable Table {
            get {
                return new SqlTable("control_panel", WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger MainMenu {
                get {
                    return new SqlFieldInteger("main_menu", Table, WAFID.GetDataValueId("19089f1a-921a-4a8f-86f2-d8946a41fc3b"));
                }
            }

            public static SqlFieldShortString Logo_logo_filename {
                get {
                    return new SqlFieldShortString("logo_filename", Table, WAFID.GetDataValueId("5a68b4ae-5353-4838-b433-0428562c89b1"));
                }
            }

            public static SqlFieldShortString Logo_logo_type_name {
                get {
                    return new SqlFieldShortString("logo_type_name", Table, WAFID.GetDataValueId("58059509-8af1-4fea-9515-ea191c903515"));
                }
            }

            public static SqlFieldShortString Logo_logo_extension {
                get {
                    return new SqlFieldShortString("logo_extension", Table, WAFID.GetDataValueId("06490a0a-f4f4-4191-831e-990ba4b01924"));
                }
            }

            public static SqlFieldFloat Logo_logo_bytes {
                get {
                    return new SqlFieldFloat("logo_bytes", Table, WAFID.GetDataValueId("50743e87-0e7b-4630-a163-e5b5c9c3453c"));
                }
            }

            public static SqlFieldLongString Logo_logo_info {
                get {
                    return new SqlFieldLongString("logo_info", Table, WAFID.GetDataValueId("8b3fe78e-8ca3-4f32-81b3-80c57f6517bd"));
                }
            }

            public static SqlFieldInteger Logo_logo_int {
                get {
                    return new SqlFieldInteger("logo_int", Table, WAFID.GetDataValueId("4d5323d5-bbd9-4573-a338-ae96005702cd"));
                }
            }

            public static SqlFieldInteger Frontpage {
                get {
                    return new SqlFieldInteger("frontpage", Table, WAFID.GetDataValueId("d8c00707-fd16-45a5-8027-b5ea0a00fb20"));
                }
            }

            public static SqlFieldInteger Portfolio {
                get {
                    return new SqlFieldInteger("portfolio", Table, WAFID.GetDataValueId("afda55d8-163f-406d-b257-24cfee6fca15"));
                }
            }

            public static SqlFieldInteger Settings {
                get {
                    return new SqlFieldInteger("settings", Table, WAFID.GetDataValueId("02ee5d9a-6aa7-4306-889c-ae0da30a4803"));
                }
            }

            public static SqlFieldInteger ContactPage {
                get {
                    return new SqlFieldInteger("contact_page", Table, WAFID.GetDataValueId("f58c2730-7860-464b-977e-1e974881d4f5"));
                }
            }

        }
    }
    public class SqlAliasControlPanel : SqlAlias {
        public SqlAliasControlPanel()
            : base(SqlControlPanel.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger MainMenu {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.MainMenu, this);
            }
        }

        public SqlExpressionFieldShortString Logo_logo_filename {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Logo_logo_filename, this);
            }
        }

        public SqlExpressionFieldShortString Logo_logo_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Logo_logo_type_name, this);
            }
        }

        public SqlExpressionFieldShortString Logo_logo_extension {
            get {
                return new SqlExpressionFieldShortString(SqlControlPanel.Field.Logo_logo_extension, this);
            }
        }

        public SqlExpressionFieldFloat Logo_logo_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlControlPanel.Field.Logo_logo_bytes, this);
            }
        }

        public SqlExpressionFieldLongString Logo_logo_info {
            get {
                return new SqlExpressionFieldLongString(SqlControlPanel.Field.Logo_logo_info, this);
            }
        }

        public SqlExpressionFieldInteger Logo_logo_int {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Logo_logo_int, this);
            }
        }

        public SqlExpressionFieldInteger Frontpage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Frontpage, this);
            }
        }

        public SqlExpressionFieldInteger Portfolio {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Portfolio, this);
            }
        }

        public SqlExpressionFieldInteger Settings {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.Settings, this);
            }
        }

        public SqlExpressionFieldInteger ContactPage {
            get {
                return new SqlExpressionFieldInteger(SqlControlPanel.Field.ContactPage, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlControlPanel{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")); 
            }
        }

        public static AqlPropertyInteger MainMenu {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.MainMenu, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyShortString Logo_logo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_filename, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyShortString Logo_logo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_type_name, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyShortString Logo_logo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_extension, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyFloat Logo_logo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_bytes, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyLongString Logo_logo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_info, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger Logo_logo_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Logo_logo_int, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger Frontpage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Frontpage, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger Portfolio {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Portfolio, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger Settings {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.Settings, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger ContactPage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlControlPanel.Field.ContactPage, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasControlPanel
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasControlPanel()
            : base(WAFID.GetContentClassId("98e254d7-3a7d-464f-b824-9e0f165cc7f1")) {

        }

        public AqlAliasControlPanel(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger MainMenu {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.MainMenu, this);
            }
        }

        public AqlExpressionPropertyShortString Logo_logo_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Logo_logo_filename, this);
            }
        }

        public AqlExpressionPropertyShortString Logo_logo_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Logo_logo_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString Logo_logo_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlControlPanel.Logo_logo_extension, this);
            }
        }

        public AqlExpressionPropertyFloat Logo_logo_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlControlPanel.Logo_logo_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString Logo_logo_info {
            get {
                return new AqlExpressionPropertyLongString(AqlControlPanel.Logo_logo_info, this);
            }
        }

        public AqlExpressionPropertyInteger Logo_logo_int {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Logo_logo_int, this);
            }
        }

        public AqlExpressionPropertyInteger Frontpage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Frontpage, this);
            }
        }

        public AqlExpressionPropertyInteger Portfolio {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Portfolio, this);
            }
        }

        public AqlExpressionPropertyInteger Settings {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.Settings, this);
            }
        }

        public AqlExpressionPropertyInteger ContactPage {
            get {
                return new AqlExpressionPropertyInteger(AqlControlPanel.ContactPage, this);
            }
        }

    }
}
