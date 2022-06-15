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
    public partial class Article: WAF.Engine.Content.SimpleCompanyWebsite.BaseItem {
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _paragraphs;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> Paragraphs{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("ded7b1c9-a5e9-450b-8291-a4aed2ef2d9b"), ref _paragraphs, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Article>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Article>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Article>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce");
            }
        }

        public static int PropertyIdParagraphs {
            get {
                return WAFID.GetPropertyId("ded7b1c9-a5e9-450b-8291-a4aed2ef2d9b");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("ded7b1c9-a5e9-450b-8291-a4aed2ef2d9b")) {
                object init = Paragraphs;
                return _paragraphs;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _paragraphs = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlArticle {
        public static SqlTable Table {
            get {
                return new SqlTable("article", WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

        }
    }
    public class SqlAliasArticle : SqlAlias {
        public SqlAliasArticle()
            : base(SqlArticle.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlArticle.Field.ContentId, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlArticle{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")); 
            }
        }

        public static AqlPropertyShortString HeaderSubtitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.HeaderSubtitle, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyShortString FontAwesome_IconString {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.FontAwesome_IconString, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean Top_Level_Is_Link {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.SimpleCompanyWebsite.SqlBaseItem.Field.Top_Level_Is_Link, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasArticle
        : WAF.Engine.Query.SimpleCompanyWebsite.AqlAliasBaseItem{

        public AqlAliasArticle()
            : base(WAFID.GetContentClassId("d85178ea-7906-4bb5-b267-46d69f4792ce")) {

        }

        public AqlAliasArticle(int contentClassId)
            : base(contentClassId) {

        }

    }
}
