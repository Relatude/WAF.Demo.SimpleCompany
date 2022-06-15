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
    public partial class Frontpage: WAF.Engine.Content.SimpleCompanyWebsite.BaseItem {
        ShortStringPropertyValue _titleText;
        public virtual string TitleText {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("eaace988-e9ee-4d86-ba73-0c42b43a13e5"), ref _titleText, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("eaace988-e9ee-4d86-ba73-0c42b43a13e5"), ref _titleText, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> _coverImages;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile> CoverImages{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.Native.InnerFile>.GetValue(WAFID.GetDataValueId("2be896ef-4dbf-4edc-b6a3-bdb9d673d6b3"), ref _coverImages, this);}
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _paragraphs;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Paragraphs{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("3f80c15e-5fb4-460b-a5af-15cc08ce8525"), ref _paragraphs, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Frontpage>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Frontpage>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Frontpage>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b");
            }
        }

        public static int PropertyIdTitleText {
            get {
                return WAFID.GetPropertyId("1e6e68da-e702-441f-8d3b-2b5a94180755");
            }
        }

        public static int DataValueIdTitleTextTitleText {
            get {
                return WAFID.GetDataValueId("eaace988-e9ee-4d86-ba73-0c42b43a13e5");
            }
        }

        public static int PropertyIdCoverImages {
            get {
                return WAFID.GetPropertyId("2be896ef-4dbf-4edc-b6a3-bdb9d673d6b3");
            }
        }

        public static int PropertyIdParagraphs {
            get {
                return WAFID.GetPropertyId("3f80c15e-5fb4-460b-a5af-15cc08ce8525");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("1e6e68da-e702-441f-8d3b-2b5a94180755")) {
                object init = TitleText;
                return _titleText;
            }
            else if (propertyId == WAFID.GetPropertyId("2be896ef-4dbf-4edc-b6a3-bdb9d673d6b3")) {
                object init = CoverImages;
                return _coverImages;
            }
            else if (propertyId == WAFID.GetPropertyId("3f80c15e-5fb4-460b-a5af-15cc08ce8525")) {
                object init = Paragraphs;
                return _paragraphs;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _titleText = null;
            _coverImages = null;
            _paragraphs = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlFrontpage {
        public static SqlTable Table {
            get {
                return new SqlTable("frontpage", WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString TitleText {
                get {
                    return new SqlFieldShortString("title_text", Table, WAFID.GetDataValueId("eaace988-e9ee-4d86-ba73-0c42b43a13e5"));
                }
            }

        }
    }
    public class SqlAliasFrontpage : SqlAlias {
        public SqlAliasFrontpage()
            : base(SqlFrontpage.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlFrontpage.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString TitleText {
            get {
                return new SqlExpressionFieldShortString(SqlFrontpage.Field.TitleText, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlFrontpage{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")); 
            }
        }

        public static AqlPropertyShortString TitleText {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlFrontpage.Field.TitleText, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyShortString HeaderSubtitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.HeaderSubtitle, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyShortString FontAwesome_IconString {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.FontAwesome_IconString, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean Top_Level_Is_Link {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.Top_Level_Is_Link, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasFrontpage
        : WAF.Engine.Query.SimpleCompanyWebsite.AqlAliasBaseItem{

        public AqlAliasFrontpage()
            : base(WAFID.GetContentClassId("46830257-9d67-485c-8bb1-4f09812c414b")) {

        }

        public AqlAliasFrontpage(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString TitleText {
            get {
                return new AqlExpressionPropertyShortString(AqlFrontpage.TitleText, this);
            }
        }

    }
}
