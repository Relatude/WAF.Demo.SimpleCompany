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
    public partial class Employee: WAF.Engine.Content.Native.SystemUser {
        LongStringPropertyValue _description;
        public virtual string Description {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("248b99d4-02ee-4761-a467-bb66c05da7fa"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("248b99d4-02ee-4761-a467-bb66c05da7fa"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.SocialMediaLink> _socialMediaLinks;
        public virtual InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.SocialMediaLink> SocialMediaLinks{
        get {EnsureContentDataIndependence(); return InnerContentsPropertyValue<WAF.Engine.Content.SimpleCompanyWebsite.SocialMediaLink>.GetValue(WAFID.GetDataValueId("9486ca01-df77-4695-aa97-b5fc1b803d32"), ref _socialMediaLinks, this);}
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Employee>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Employee>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Employee>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("5653f445-7bbf-4fdd-a384-238502b3574b");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("248b99d4-02ee-4761-a467-bb66c05da7fa");
            }
        }

        public static int PropertyIdSocialMediaLinks {
            get {
                return WAFID.GetPropertyId("9486ca01-df77-4695-aa97-b5fc1b803d32");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("5653f445-7bbf-4fdd-a384-238502b3574b")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("9486ca01-df77-4695-aa97-b5fc1b803d32")) {
                object init = SocialMediaLinks;
                return _socialMediaLinks;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _description = null;
            _socialMediaLinks = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlEmployee {
        public static SqlTable Table {
            get {
                return new SqlTable("employee", WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("248b99d4-02ee-4761-a467-bb66c05da7fa"));
                }
            }

        }
    }
    public class SqlAliasEmployee : SqlAlias {
        public SqlAliasEmployee()
            : base(SqlEmployee.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlEmployee.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlEmployee.Field.Description, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlEmployee{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")); 
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlEmployee.Field.Description, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString UserName {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.UserName, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Password {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Password, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean IsAdmin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsAdmin, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean AllowEditLogin {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.AllowEditLogin, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyRelation DirectMemberships {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("6facd1bc-df8e-4d9c-ab2e-4614e26834e6"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasUserGroup(), new WAF.Engine.Query.Native.AqlAliasSystemUser(), WAF.Engine.Query.Native.AqlRelUserGroup.Relation));
            }
        }

        public static AqlPropertyShortString Forename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Forename, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Surname {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Surname, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Email, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger Gender {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Gender, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyDateTime Birth {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.Birth, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Company {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Company, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString JobTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.JobTitle, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Street {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Street, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString PostZipCode {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.PostZipCode, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString ProvinceState {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.ProvinceState, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString City {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.City, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Country {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Country, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Mobile {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Mobile, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Phone, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString IM {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.IM, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Website {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Website, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Photo_photo_filename {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_filename, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Photo_photo_type_name {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_type_name, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString Photo_photo_extension {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_extension, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyFloat Photo_photo_bytes {
            get {
                return new AqlPropertyFloat(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_bytes, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString Photo_photo_info {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_info, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger Photo_photo_reference {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.Photo_photo_reference, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString Signature {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Signature, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString Comment {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.Comment, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger StartSite {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.StartSite, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger PreferredLanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredLanguage, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean IsApproved {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsApproved, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean IsLocked {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlSystemUser.Field.IsLocked, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger FailedLogins {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.FailedLogins, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString PasswordAnswer {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordAnswer, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString PasswordQuestion {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.PasswordQuestion, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyDateTime LastPasswordChangedDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastPasswordChangedDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyDateTime LastLoginDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLoginDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyDateTime LastActivityDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastActivityDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyDateTime LastLockoutDate {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.Native.SqlSystemUser.Field.LastLockoutDate, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString GUID {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.GUID, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyRelation Orders {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("42822b2c-241c-4879-a8bd-360aee78e58f"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasSystemUser(), new WAF.Engine.Query.Native.AqlAliasOrder(), WAF.Engine.Query.Native.AqlRelCustomerOrders.Relation));
            }
        }

        public static AqlPropertyInteger PreferredUILanguage {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlSystemUser.Field.PreferredUILanguage, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString RestrictLoginsByIPs {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.RestrictLoginsByIPs, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString VisitorId {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlSystemUser.Field.VisitorId, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString UIConfig {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.UIConfig, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString TwoFactorPersistentKeys {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlSystemUser.Field.TwoFactorPersistentKeys, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasEmployee
        : WAF.Engine.Query.Native.AqlAliasSystemUser{

        public AqlAliasEmployee()
            : base(WAFID.GetContentClassId("587718a4-c62d-43f0-83b5-59725f604589")) {

        }

        public AqlAliasEmployee(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlEmployee.Description, this);
            }
        }

    }
}
