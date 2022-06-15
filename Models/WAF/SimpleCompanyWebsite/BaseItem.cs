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
    public partial class BaseItem: WAF.Engine.Content.Native.HierarchicalContent {
        ShortStringPropertyValue _headerSubtitle;
        public virtual string HeaderSubtitle {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("d2464068-486c-4a79-b12e-29377f9211ac"), ref _headerSubtitle, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("d2464068-486c-4a79-b12e-29377f9211ac"), ref _headerSubtitle, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _fontAwesome_IconString;
        public virtual string FontAwesome_IconString {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("e686a5ad-e020-4a05-aa1a-f179a25dcd74"), ref _fontAwesome_IconString, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("e686a5ad-e020-4a05-aa1a-f179a25dcd74"), ref _fontAwesome_IconString, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        CheckBoxPropertyValue _top_Level_Is_Link;
        public virtual bool Top_Level_Is_Link {
        get { return CheckBoxPropertyValue.GetValue(WAFID.GetDataValueId("b148a161-e2c2-4d00-b57b-5a5d068f9c57"), ref _top_Level_Is_Link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); CheckBoxPropertyValue.SetValue(WAFID.GetDataValueId("b148a161-e2c2-4d00-b57b-5a5d068f9c57"), ref _top_Level_Is_Link, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      

        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<BaseItem>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<BaseItem>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<BaseItem>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a");
            }
        }

        public static int PropertyIdHeaderSubtitle {
            get {
                return WAFID.GetPropertyId("df0d5fd9-2625-4255-8e78-162d941c0d8c");
            }
        }

        public static int DataValueIdHeaderSubtitleHeaderSubtitle {
            get {
                return WAFID.GetDataValueId("d2464068-486c-4a79-b12e-29377f9211ac");
            }
        }

        public static int PropertyIdFontAwesome_IconString {
            get {
                return WAFID.GetPropertyId("b2b6fb28-2859-42e2-915d-86d09e2d8021");
            }
        }

        public static int DataValueIdFontAwesome_IconStringFontAwesomeIconString {
            get {
                return WAFID.GetDataValueId("e686a5ad-e020-4a05-aa1a-f179a25dcd74");
            }
        }

        public static int PropertyIdTop_Level_Is_Link {
            get {
                return WAFID.GetPropertyId("fdfffc5b-7ed0-4772-8292-ec355a262999");
            }
        }

        public static int DataValueIdTop_Level_Is_LinkTopLevelIsLink {
            get {
                return WAFID.GetDataValueId("b148a161-e2c2-4d00-b57b-5a5d068f9c57");
            }
        }

        public static int PropertyIdTopLevelIsLink_Description {
            get {
                return WAFID.GetPropertyId("3896a89e-b0d2-46bc-94cd-dc77c47e8271");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("df0d5fd9-2625-4255-8e78-162d941c0d8c")) {
                object init = HeaderSubtitle;
                return _headerSubtitle;
            }
            else if (propertyId == WAFID.GetPropertyId("b2b6fb28-2859-42e2-915d-86d09e2d8021")) {
                object init = FontAwesome_IconString;
                return _fontAwesome_IconString;
            }
            else if (propertyId == WAFID.GetPropertyId("fdfffc5b-7ed0-4772-8292-ec355a262999")) {
                object init = Top_Level_Is_Link;
                return _top_Level_Is_Link;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _headerSubtitle = null;
            _fontAwesome_IconString = null;
            _top_Level_Is_Link = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlBaseItem {
        public static SqlTable Table {
            get {
                return new SqlTable("base_item", WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString HeaderSubtitle {
                get {
                    return new SqlFieldShortString("header_subtitle", Table, WAFID.GetDataValueId("d2464068-486c-4a79-b12e-29377f9211ac"));
                }
            }

            public static SqlFieldShortString FontAwesome_IconString {
                get {
                    return new SqlFieldShortString("font_awesome__icon_string", Table, WAFID.GetDataValueId("e686a5ad-e020-4a05-aa1a-f179a25dcd74"));
                }
            }

            public static SqlFieldBoolean Top_Level_Is_Link {
                get {
                    return new SqlFieldBoolean("top__level__is__link", Table, WAFID.GetDataValueId("b148a161-e2c2-4d00-b57b-5a5d068f9c57"));
                }
            }

        }
    }
    public class SqlAliasBaseItem : SqlAlias {
        public SqlAliasBaseItem()
            : base(SqlBaseItem.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlBaseItem.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString HeaderSubtitle {
            get {
                return new SqlExpressionFieldShortString(SqlBaseItem.Field.HeaderSubtitle, this);
            }
        }

        public SqlExpressionFieldShortString FontAwesome_IconString {
            get {
                return new SqlExpressionFieldShortString(SqlBaseItem.Field.FontAwesome_IconString, this);
            }
        }

        public SqlExpressionFieldBoolean Top_Level_Is_Link {
            get {
                return new SqlExpressionFieldBoolean(SqlBaseItem.Field.Top_Level_Is_Link, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlBaseItem{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")); 
            }
        }

        public static AqlPropertyShortString HeaderSubtitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.HeaderSubtitle, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyShortString FontAwesome_IconString {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.FontAwesome_IconString, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean Top_Level_Is_Link {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.Top_Level_Is_Link, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasBaseItem
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasBaseItem()
            : base(WAFID.GetContentClassId("966d7227-69e0-4b7a-8475-b89ad21a972a")) {

        }

        public AqlAliasBaseItem(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString HeaderSubtitle {
            get {
                return new AqlExpressionPropertyShortString(AqlBaseItem.HeaderSubtitle, this);
            }
        }

        public AqlExpressionPropertyShortString FontAwesome_IconString {
            get {
                return new AqlExpressionPropertyShortString(AqlBaseItem.FontAwesome_IconString, this);
            }
        }

        public AqlExpressionPropertyBoolean Top_Level_Is_Link {
            get {
                return new AqlExpressionPropertyBoolean(AqlBaseItem.Top_Level_Is_Link, this);
            }
        }

    }
}
