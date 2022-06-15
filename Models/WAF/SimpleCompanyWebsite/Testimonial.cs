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
    public partial class Testimonial: WAF.Engine.Content.Native.HierarchicalContent {
        FilePropertyValue _userPhoto;
        public virtual FilePropertyValue UserPhoto {
        get { EnsureContentDataIndependence(); return FilePropertyValue.GetValue(WAFID.GetDataValueId("d484d0ca-c6ad-4ba3-bd51-a3d4fd502cb1"),WAFID.GetDataValueId("1f737493-bf65-45ff-a6fe-23b492746dec"),WAFID.GetDataValueId("fc838529-ad41-43d8-89e4-dce584cebb2f"),WAFID.GetDataValueId("2a07272c-8732-4078-a5d0-a2f52cca4643"),WAFID.GetDataValueId("bb978877-9618-437d-ab7c-52e8db5c3e1b"),WAFID.GetDataValueId("2d02d758-e081-49f3-86a3-07a7b9af92c4"), ref _userPhoto, this, WAFID.GetDataValueId("89acb27f-be77-4b28-9020-cc2ebb46fadf")); }
        }
      
        ShortStringPropertyValue _testimony;
        public virtual string Testimony {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("22e2f26f-4082-4e78-bfb6-0b93d9088f77"), ref _testimony, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("22e2f26f-4082-4e78-bfb6-0b93d9088f77"), ref _testimony, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _userName;
        public virtual string UserName {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("763efa30-d40e-4a88-9d5b-4c989404d631"), ref _userName, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("763efa30-d40e-4a88-9d5b-4c989404d631"), ref _userName, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _location;
        public virtual string Location {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("5d27ce84-7db3-4bd8-9164-c6818c9331be"), ref _location, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("5d27ce84-7db3-4bd8-9164-c6818c9331be"), ref _location, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _contactLink;
        public virtual LinkPropertyValue ContactLink {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("53b99512-2d96-4c75-aefb-231579525594"), ref _contactLink, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        DateTimePropertyValue _dateOfTestimony;
        public virtual DateTime DateOfTestimony {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("17874142-c759-4a49-99cd-6d603e54ed8a"), ref _dateOfTestimony, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("17874142-c759-4a49-99cd-6d603e54ed8a"), ref _dateOfTestimony, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Testimonial>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Testimonial>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Testimonial>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d");
            }
        }

        public static int PropertyIdUserPhoto {
            get {
                return WAFID.GetPropertyId("89acb27f-be77-4b28-9020-cc2ebb46fadf");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoFilename {
            get {
                return WAFID.GetDataValueId("1f737493-bf65-45ff-a6fe-23b492746dec");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoTypeName {
            get {
                return WAFID.GetDataValueId("fc838529-ad41-43d8-89e4-dce584cebb2f");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoExtension {
            get {
                return WAFID.GetDataValueId("2a07272c-8732-4078-a5d0-a2f52cca4643");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoBytes {
            get {
                return WAFID.GetDataValueId("bb978877-9618-437d-ab7c-52e8db5c3e1b");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoInfo {
            get {
                return WAFID.GetDataValueId("2d02d758-e081-49f3-86a3-07a7b9af92c4");
            }
        }

        public static int DataValueIdUserPhotoUserPhotoInt {
            get {
                return WAFID.GetDataValueId("d484d0ca-c6ad-4ba3-bd51-a3d4fd502cb1");
            }
        }

        public static int PropertyIdTestimony {
            get {
                return WAFID.GetPropertyId("2d061a1c-6c3e-43b1-b2da-54377f91ba7a");
            }
        }

        public static int DataValueIdTestimonyTestimony {
            get {
                return WAFID.GetDataValueId("22e2f26f-4082-4e78-bfb6-0b93d9088f77");
            }
        }

        public static int PropertyIdUserName {
            get {
                return WAFID.GetPropertyId("ed5f9c25-1279-464d-8681-315e7ca03ecc");
            }
        }

        public static int DataValueIdUserNameUserName {
            get {
                return WAFID.GetDataValueId("763efa30-d40e-4a88-9d5b-4c989404d631");
            }
        }

        public static int PropertyIdLocation {
            get {
                return WAFID.GetPropertyId("faa65802-27af-4469-90a1-b17f5800b030");
            }
        }

        public static int DataValueIdLocationLocation {
            get {
                return WAFID.GetDataValueId("5d27ce84-7db3-4bd8-9164-c6818c9331be");
            }
        }

        public static int PropertyIdContactLink {
            get {
                return WAFID.GetPropertyId("41523af6-128d-4576-8c18-976cbea8e322");
            }
        }

        public static int DataValueIdContactLinkContactLink {
            get {
                return WAFID.GetDataValueId("53b99512-2d96-4c75-aefb-231579525594");
            }
        }

        public static int PropertyIdDateOfTestimony {
            get {
                return WAFID.GetPropertyId("1b4b5c9d-4373-49f7-8959-29454ee40ae5");
            }
        }

        public static int DataValueIdDateOfTestimonyDateOfTestimony {
            get {
                return WAFID.GetDataValueId("17874142-c759-4a49-99cd-6d603e54ed8a");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("89acb27f-be77-4b28-9020-cc2ebb46fadf")) {
                object init = UserPhoto;
                return _userPhoto;
            }
            else if (propertyId == WAFID.GetPropertyId("2d061a1c-6c3e-43b1-b2da-54377f91ba7a")) {
                object init = Testimony;
                return _testimony;
            }
            else if (propertyId == WAFID.GetPropertyId("ed5f9c25-1279-464d-8681-315e7ca03ecc")) {
                object init = UserName;
                return _userName;
            }
            else if (propertyId == WAFID.GetPropertyId("faa65802-27af-4469-90a1-b17f5800b030")) {
                object init = Location;
                return _location;
            }
            else if (propertyId == WAFID.GetPropertyId("41523af6-128d-4576-8c18-976cbea8e322")) {
                object init = ContactLink;
                return _contactLink;
            }
            else if (propertyId == WAFID.GetPropertyId("1b4b5c9d-4373-49f7-8959-29454ee40ae5")) {
                object init = DateOfTestimony;
                return _dateOfTestimony;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _userPhoto = null;
            _testimony = null;
            _userName = null;
            _location = null;
            _contactLink = null;
            _dateOfTestimony = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlTestimonial {
        public static SqlTable Table {
            get {
                return new SqlTable("testimonial", WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldShortString UserPhoto_user_photo_filename {
                get {
                    return new SqlFieldShortString("user_photo_filename", Table, WAFID.GetDataValueId("1f737493-bf65-45ff-a6fe-23b492746dec"));
                }
            }

            public static SqlFieldShortString UserPhoto_user_photo_type_name {
                get {
                    return new SqlFieldShortString("user_photo_type_name", Table, WAFID.GetDataValueId("fc838529-ad41-43d8-89e4-dce584cebb2f"));
                }
            }

            public static SqlFieldShortString UserPhoto_user_photo_extension {
                get {
                    return new SqlFieldShortString("user_photo_extension", Table, WAFID.GetDataValueId("2a07272c-8732-4078-a5d0-a2f52cca4643"));
                }
            }

            public static SqlFieldFloat UserPhoto_user_photo_bytes {
                get {
                    return new SqlFieldFloat("user_photo_bytes", Table, WAFID.GetDataValueId("bb978877-9618-437d-ab7c-52e8db5c3e1b"));
                }
            }

            public static SqlFieldLongString UserPhoto_user_photo_info {
                get {
                    return new SqlFieldLongString("user_photo_info", Table, WAFID.GetDataValueId("2d02d758-e081-49f3-86a3-07a7b9af92c4"));
                }
            }

            public static SqlFieldInteger UserPhoto_user_photo_int {
                get {
                    return new SqlFieldInteger("user_photo_int", Table, WAFID.GetDataValueId("d484d0ca-c6ad-4ba3-bd51-a3d4fd502cb1"));
                }
            }

            public static SqlFieldShortString Testimony {
                get {
                    return new SqlFieldShortString("testimony", Table, WAFID.GetDataValueId("22e2f26f-4082-4e78-bfb6-0b93d9088f77"));
                }
            }

            public static SqlFieldShortString UserName {
                get {
                    return new SqlFieldShortString("user_name", Table, WAFID.GetDataValueId("763efa30-d40e-4a88-9d5b-4c989404d631"));
                }
            }

            public static SqlFieldShortString Location {
                get {
                    return new SqlFieldShortString("location", Table, WAFID.GetDataValueId("5d27ce84-7db3-4bd8-9164-c6818c9331be"));
                }
            }

            public static SqlFieldShortString ContactLink {
                get {
                    return new SqlFieldShortString("contact_link", Table, WAFID.GetDataValueId("53b99512-2d96-4c75-aefb-231579525594"));
                }
            }

            public static SqlFieldDateTime DateOfTestimony {
                get {
                    return new SqlFieldDateTime("date_of_testimony", Table, WAFID.GetDataValueId("17874142-c759-4a49-99cd-6d603e54ed8a"));
                }
            }

        }
    }
    public class SqlAliasTestimonial : SqlAlias {
        public SqlAliasTestimonial()
            : base(SqlTestimonial.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlTestimonial.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString UserPhoto_user_photo_filename {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.UserPhoto_user_photo_filename, this);
            }
        }

        public SqlExpressionFieldShortString UserPhoto_user_photo_type_name {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.UserPhoto_user_photo_type_name, this);
            }
        }

        public SqlExpressionFieldShortString UserPhoto_user_photo_extension {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.UserPhoto_user_photo_extension, this);
            }
        }

        public SqlExpressionFieldFloat UserPhoto_user_photo_bytes {
            get {
                return new SqlExpressionFieldFloat(SqlTestimonial.Field.UserPhoto_user_photo_bytes, this);
            }
        }

        public SqlExpressionFieldLongString UserPhoto_user_photo_info {
            get {
                return new SqlExpressionFieldLongString(SqlTestimonial.Field.UserPhoto_user_photo_info, this);
            }
        }

        public SqlExpressionFieldInteger UserPhoto_user_photo_int {
            get {
                return new SqlExpressionFieldInteger(SqlTestimonial.Field.UserPhoto_user_photo_int, this);
            }
        }

        public SqlExpressionFieldShortString Testimony {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.Testimony, this);
            }
        }

        public SqlExpressionFieldShortString UserName {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.UserName, this);
            }
        }

        public SqlExpressionFieldShortString Location {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.Location, this);
            }
        }

        public SqlExpressionFieldShortString ContactLink {
            get {
                return new SqlExpressionFieldShortString(SqlTestimonial.Field.ContactLink, this);
            }
        }

        public SqlExpressionFieldDateTime DateOfTestimony {
            get {
                return new SqlExpressionFieldDateTime(SqlTestimonial.Field.DateOfTestimony, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlTestimonial{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")); 
            }
        }

        public static AqlPropertyShortString UserPhoto_user_photo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_filename, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString UserPhoto_user_photo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_type_name, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString UserPhoto_user_photo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_extension, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyFloat UserPhoto_user_photo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_bytes, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyLongString UserPhoto_user_photo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_info, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyInteger UserPhoto_user_photo_int {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserPhoto_user_photo_int, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString Testimony {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.Testimony, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString UserName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.UserName, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString Location {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.Location, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString ContactLink {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.ContactLink, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyDateTime DateOfTestimony {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.SimpleCompanyWebsite.SqlTestimonial.Field.DateOfTestimony, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasTestimonial
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasTestimonial()
            : base(WAFID.GetContentClassId("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")) {

        }

        public AqlAliasTestimonial(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString UserPhoto_user_photo_filename {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.UserPhoto_user_photo_filename, this);
            }
        }

        public AqlExpressionPropertyShortString UserPhoto_user_photo_type_name {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.UserPhoto_user_photo_type_name, this);
            }
        }

        public AqlExpressionPropertyShortString UserPhoto_user_photo_extension {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.UserPhoto_user_photo_extension, this);
            }
        }

        public AqlExpressionPropertyFloat UserPhoto_user_photo_bytes {
            get {
                return new AqlExpressionPropertyFloat(AqlTestimonial.UserPhoto_user_photo_bytes, this);
            }
        }

        public AqlExpressionPropertyLongString UserPhoto_user_photo_info {
            get {
                return new AqlExpressionPropertyLongString(AqlTestimonial.UserPhoto_user_photo_info, this);
            }
        }

        public AqlExpressionPropertyInteger UserPhoto_user_photo_int {
            get {
                return new AqlExpressionPropertyInteger(AqlTestimonial.UserPhoto_user_photo_int, this);
            }
        }

        public AqlExpressionPropertyShortString Testimony {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.Testimony, this);
            }
        }

        public AqlExpressionPropertyShortString UserName {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.UserName, this);
            }
        }

        public AqlExpressionPropertyShortString Location {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.Location, this);
            }
        }

        public AqlExpressionPropertyShortString ContactLink {
            get {
                return new AqlExpressionPropertyShortString(AqlTestimonial.ContactLink, this);
            }
        }

        public AqlExpressionPropertyDateTime DateOfTestimony {
            get {
                return new AqlExpressionPropertyDateTime(AqlTestimonial.DateOfTestimony, this);
            }
        }

    }
}
