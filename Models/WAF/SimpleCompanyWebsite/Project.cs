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
    public partial class Project: WAF.Engine.Content.Native.HierarchicalContent {
        ShortStringPropertyValue _blurb;
        public virtual string Blurb {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("85101e48-488a-4e8f-8853-f1f3cac948ee"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("85101e48-488a-4e8f-8853-f1f3cac948ee"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        FilePropertyValue _mainImage;
        public virtual FilePropertyValue MainImage {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("7b27e9ef-e866-4232-aa1c-9966daadebbb"),WAFID.GetDataValueId("9e12612c-c2f0-4178-a519-545f2cf1bc10"),WAFID.GetDataValueId("c7332df1-6a4e-41e9-acf9-770ab84c91ea"),WAFID.GetDataValueId("af54a6df-13e6-4506-a995-a25ea66877a8"),WAFID.GetDataValueId("7d1a5597-2267-4396-80bd-afa7d2c538a8"),WAFID.GetDataValueId("36e8436e-4926-49bb-8889-188bd607a9ce"), ref _mainImage, this, WAFID.GetDataValueId("a4ec9abe-f633-414c-98db-e7e77308e708")); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> _imageSeries;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase> ImageSeries{
        get { EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.InnerContentBase>.GetValue(WAFID.GetDataValueId("c10e7e95-ad9c-42e4-838e-ea6f0d95650d"), ref _imageSeries, this);}
        }
      
        DateTimePropertyValue _date_Started;
        public virtual DateTime Date_Started {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("fa38f980-2a89-4c21-8326-f3e5eb972ab3"), ref _date_Started, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("fa38f980-2a89-4c21-8326-f3e5eb972ab3"), ref _date_Started, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        DateTimePropertyValue _date_Ended;
        public virtual DateTime Date_Ended {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("d31ddba2-53ac-4e8d-b611-f59ec8544ce3"), ref _date_Ended, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("d31ddba2-53ac-4e8d-b611-f59ec8544ce3"), ref _date_Ended, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        EnumerationsPropertyValue<SimpleCompanyWebsite.Power_Types_Enumeration> _related_Power_Types;
        public virtual EnumerationsPropertyValue<SimpleCompanyWebsite.Power_Types_Enumeration> Related_Power_Types {
        get { EnsureContentDataIndependence(); return EnumerationsPropertyValue<SimpleCompanyWebsite.Power_Types_Enumeration>.GetValue(WAFID.GetDataValueId("e31c5d1b-101b-4fa1-951f-1dc71717a58f"), ref _related_Power_Types, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Project>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Project>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Project>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c");
            }
        }

        public static int PropertyIdBlurb {
            get {
                return WAFID.GetPropertyId("be5e19b8-43d3-4fd4-8751-b30e7dbf0cb9");
            }
        }

        public static int DataValueIdBlurbBlurb {
            get {
                return WAFID.GetDataValueId("85101e48-488a-4e8f-8853-f1f3cac948ee");
            }
        }

        public static int PropertyIdMainImage {
            get {
                return WAFID.GetPropertyId("a4ec9abe-f633-414c-98db-e7e77308e708");
            }
        }

        public static int DataValueIdMainImageMainImageFilename {
            get {
                return WAFID.GetDataValueId("9e12612c-c2f0-4178-a519-545f2cf1bc10");
            }
        }

        public static int DataValueIdMainImageMainImageTypeName {
            get {
                return WAFID.GetDataValueId("c7332df1-6a4e-41e9-acf9-770ab84c91ea");
            }
        }

        public static int DataValueIdMainImageMainImageExtension {
            get {
                return WAFID.GetDataValueId("af54a6df-13e6-4506-a995-a25ea66877a8");
            }
        }

        public static int DataValueIdMainImageMainImageBytes {
            get {
                return WAFID.GetDataValueId("7d1a5597-2267-4396-80bd-afa7d2c538a8");
            }
        }

        public static int DataValueIdMainImageMainImageInfo {
            get {
                return WAFID.GetDataValueId("36e8436e-4926-49bb-8889-188bd607a9ce");
            }
        }

        public static int DataValueIdMainImageMainImageInt {
            get {
                return WAFID.GetDataValueId("7b27e9ef-e866-4232-aa1c-9966daadebbb");
            }
        }

        public static int PropertyIdImageSeries {
            get {
                return WAFID.GetPropertyId("c10e7e95-ad9c-42e4-838e-ea6f0d95650d");
            }
        }

        public static int PropertyIdDate_Started {
            get {
                return WAFID.GetPropertyId("a053e8e9-12cb-4988-8e08-3f6b041d038d");
            }
        }

        public static int DataValueIdDate_StartedDateStarted {
            get {
                return WAFID.GetDataValueId("fa38f980-2a89-4c21-8326-f3e5eb972ab3");
            }
        }

        public static int PropertyIdDate_Ended {
            get {
                return WAFID.GetPropertyId("28f1be51-afd0-4f01-94ce-951b71318e08");
            }
        }

        public static int DataValueIdDate_EndedDateEnded {
            get {
                return WAFID.GetDataValueId("d31ddba2-53ac-4e8d-b611-f59ec8544ce3");
            }
        }

        public static int PropertyIdRelated_Power_Types {
            get {
                return WAFID.GetPropertyId("e31c5d1b-101b-4fa1-951f-1dc71717a58f");
            }
        }

        public static int DataValueIdRelated_Power_TypesRelatedPowerTypesslot0 {
            get {
                return WAFID.GetDataValueId("11bf4f71-23eb-49df-b3e6-aa8d90cd759a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("be5e19b8-43d3-4fd4-8751-b30e7dbf0cb9")) {
                object init = Blurb;
                return _blurb;
            }
            else if (propertyId == WAFID.GetPropertyId("a4ec9abe-f633-414c-98db-e7e77308e708")) {
                object init = MainImage;
                return _mainImage;
            }
            else if (propertyId == WAFID.GetPropertyId("c10e7e95-ad9c-42e4-838e-ea6f0d95650d")) {
                object init = ImageSeries;
                return _imageSeries;
            }
            else if (propertyId == WAFID.GetPropertyId("a053e8e9-12cb-4988-8e08-3f6b041d038d")) {
                object init = Date_Started;
                return _date_Started;
            }
            else if (propertyId == WAFID.GetPropertyId("28f1be51-afd0-4f01-94ce-951b71318e08")) {
                object init = Date_Ended;
                return _date_Ended;
            }
            else if (propertyId == WAFID.GetPropertyId("e31c5d1b-101b-4fa1-951f-1dc71717a58f")) {
                object init = Related_Power_Types;
                return _related_Power_Types;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _blurb = null;
            _mainImage = null;
            _imageSeries = null;
            _date_Started = null;
            _date_Ended = null;
            _related_Power_Types = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlProject {
        public static SqlTable Table {
            get {
                return new SqlTable("project", WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString Blurb {
                get {
                    return new SqlFieldShortString("blurb", Table, WAFID.GetDataValueId("85101e48-488a-4e8f-8853-f1f3cac948ee"));
                }
            }

            public static SqlFieldShortString MainImage_main_image_filename {
                get {
                    return new SqlFieldShortString("main_image_filename", Table, WAFID.GetDataValueId("9e12612c-c2f0-4178-a519-545f2cf1bc10"));
                }
            }

            public static SqlFieldShortString MainImage_main_image_type_name {
                get {
                    return new SqlFieldShortString("main_image_type_name", Table, WAFID.GetDataValueId("c7332df1-6a4e-41e9-acf9-770ab84c91ea"));
                }
            }

            public static SqlFieldShortString MainImage_main_image_extension {
                get {
                    return new SqlFieldShortString("main_image_extension", Table, WAFID.GetDataValueId("af54a6df-13e6-4506-a995-a25ea66877a8"));
                }
            }

            public static SqlFieldFloat MainImage_main_image_bytes {
                get {
                    return new SqlFieldFloat("main_image_bytes", Table, WAFID.GetDataValueId("7d1a5597-2267-4396-80bd-afa7d2c538a8"));
                }
            }

            public static SqlFieldLongString MainImage_main_image_info {
                get {
                    return new SqlFieldLongString("main_image_info", Table, WAFID.GetDataValueId("36e8436e-4926-49bb-8889-188bd607a9ce"));
                }
            }

            public static SqlFieldInteger MainImage_main_image_int {
                get {
                    return new SqlFieldInteger("main_image_int", Table, WAFID.GetDataValueId("7b27e9ef-e866-4232-aa1c-9966daadebbb"));
                }
            }

            public static SqlFieldDateTime Date_Started {
                get {
                    return new SqlFieldDateTime("date__started", Table, WAFID.GetDataValueId("fa38f980-2a89-4c21-8326-f3e5eb972ab3"));
                }
            }

            public static SqlFieldDateTime Date_Ended {
                get {
                    return new SqlFieldDateTime("date__ended", Table, WAFID.GetDataValueId("d31ddba2-53ac-4e8d-b611-f59ec8544ce3"));
                }
            }

            public static SqlFieldInteger Related_Power_TypesSlot_0 {
                get {
                    return new SqlFieldInteger("related__power__typesSlot_0", Table, WAFID.GetDataValueId("11bf4f71-23eb-49df-b3e6-aa8d90cd759a"));
                }
            }

        }
    }
    public class SqlAliasProject : SqlAlias {
        public SqlAliasProject()
            : base(SqlProject.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlProject.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString Blurb {
            get {
                return new SqlExpressionFieldShortString(SqlProject.Field.Blurb, this);
            }
        }

        public SqlExpressionFieldShortString MainImage_main_image_filename {
            get {
                return new SqlExpressionFieldShortString(SqlProject.Field.MainImage_main_image_filename, this);
            }
        }

        public SqlExpressionFieldShortString MainImage_main_image_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlProject.Field.MainImage_main_image_type_name, this);
            }
        }

        public SqlExpressionFieldShortString MainImage_main_image_extension {
            get {
                return new SqlExpressionFieldShortString(SqlProject.Field.MainImage_main_image_extension, this);
            }
        }

        public SqlExpressionFieldFloat MainImage_main_image_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlProject.Field.MainImage_main_image_bytes, this);
            }
        }

        public SqlExpressionFieldLongString MainImage_main_image_info {
            get {
                return new SqlExpressionFieldLongString(SqlProject.Field.MainImage_main_image_info, this);
            }
        }

        public SqlExpressionFieldInteger MainImage_main_image_int {
            get {
                return new SqlExpressionFieldInteger(SqlProject.Field.MainImage_main_image_int, this);
            }
        }

        public SqlExpressionFieldDateTime Date_Started {
            get {
                return new SqlExpressionFieldDateTime(SqlProject.Field.Date_Started, this);
            }
        }

        public SqlExpressionFieldDateTime Date_Ended {
            get {
                return new SqlExpressionFieldDateTime(SqlProject.Field.Date_Ended, this);
            }
        }

        public SqlExpressionFieldInteger Related_Power_TypesSlot_0 {
            get {
                return new SqlExpressionFieldInteger(SqlProject.Field.Related_Power_TypesSlot_0, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlProject{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")); 
            }
        }

        public static AqlPropertyShortString Blurb {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.Blurb, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyShortString MainImage_main_image_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_filename, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyShortString MainImage_main_image_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_type_name, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyShortString MainImage_main_image_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_extension, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyFloat MainImage_main_image_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_bytes, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyLongString MainImage_main_image_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_info, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyInteger MainImage_main_image_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.MainImage_main_image_int, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyDateTime Date_Started {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.Date_Started, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyDateTime Date_Ended {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.Date_Ended, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlExpressionEnumHelper<WAF.Engine.Content.SimpleCompanyWebsite.Power_Types_Enumeration> Related_Power_Types {
            get {
                return new AqlExpressionEnumHelper<WAF.Engine.Content.SimpleCompanyWebsite.Power_Types_Enumeration>(
        new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.Related_Power_TypesSlot_0, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"))
        );
            }
        }

        public static AqlPropertyInteger Related_Power_TypesSlot_0_IntField {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlProject.Field.Related_Power_TypesSlot_0, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasProject
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasProject()
            : base(WAFID.GetContentClassId("3b48fa07-f106-4473-9055-ce122d0d059c")) {

        }

        public AqlAliasProject(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString Blurb {
            get {
                return new AqlExpressionPropertyShortString(AqlProject.Blurb, this);
            }
        }

        public AqlExpressionPropertyShortString MainImage_main_image_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlProject.MainImage_main_image_filename, this);
            }
        }

        public AqlExpressionPropertyShortString MainImage_main_image_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlProject.MainImage_main_image_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString MainImage_main_image_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlProject.MainImage_main_image_extension, this);
            }
        }

        public AqlExpressionPropertyFloat MainImage_main_image_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlProject.MainImage_main_image_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString MainImage_main_image_info {
            get {
                return new AqlExpressionPropertyLongString(AqlProject.MainImage_main_image_info, this);
            }
        }

        public AqlExpressionPropertyInteger MainImage_main_image_int {
            get {
                return new AqlExpressionPropertyInteger(AqlProject.MainImage_main_image_int, this);
            }
        }

        public AqlExpressionPropertyDateTime Date_Started {
            get {
                return new AqlExpressionPropertyDateTime(AqlProject.Date_Started, this);
            }
        }

        public AqlExpressionPropertyDateTime Date_Ended {
            get {
                return new AqlExpressionPropertyDateTime(AqlProject.Date_Ended, this);
            }
        }

        public AqlExpressionEnumHelper<WAF.Engine.Content.SimpleCompanyWebsite.Power_Types_Enumeration> Related_Power_Types {
            get {
                return new AqlExpressionEnumHelper<WAF.Engine.Content.SimpleCompanyWebsite.Power_Types_Enumeration>(new AqlExpressionPropertyInteger(AqlProject.Related_Power_TypesSlot_0_IntField, this) 
);
            }
        }

    }
}
