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
    public partial class Settings: WAF.Engine.Content.Native.HierarchicalContent {
        ShortStringPropertyValue _blurb;
        public virtual string Blurb {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("b3b2e8c4-4778-4fdc-9d25-15fe442ebf85"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("b3b2e8c4-4778-4fdc-9d25-15fe442ebf85"), ref _blurb, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _street_Address;
        public virtual string Street_Address {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("ca0267bf-3deb-4553-a62e-39a3465824c2"), ref _street_Address, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("ca0267bf-3deb-4553-a62e-39a3465824c2"), ref _street_Address, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _phone;
        public virtual string Phone {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("e5a078e8-0e44-4c45-a035-e047a2eb4cfd"), ref _phone, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("e5a078e8-0e44-4c45-a035-e047a2eb4cfd"), ref _phone, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _email;
        public virtual LinkPropertyValue Email {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("1530c913-089a-4b61-a8cd-d76ad3630607"), ref _email, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        ShortStringPropertyValue _skype;
        public virtual string Skype {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("8124d97a-b50e-44ae-a1ec-0b73701fded7"), ref _skype, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("8124d97a-b50e-44ae-a1ec-0b73701fded7"), ref _skype, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LinkPropertyValue _facebook_Link;
        public virtual LinkPropertyValue Facebook_Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("5fe0ed9f-cc74-4271-9bc1-b74bae4f67ac"), ref _facebook_Link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _twitter_Link;
        public virtual LinkPropertyValue Twitter_Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("61f78b2e-36c4-4d35-8c3b-06365f5203dc"), ref _twitter_Link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LinkPropertyValue _instagram_Link;
        public virtual LinkPropertyValue Instagram_Link {
        get {  EnsureContentDataIndependence(); return LinkPropertyValue.GetValue(WAFID.GetDataValueId("8f0ca234-5351-4e12-ba1a-7e8c44906e27"), ref _instagram_Link, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        }
      
        LongStringPropertyValue _googleMapsFrameUrl;
        public virtual string GoogleMapsFrameUrl {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("a120edec-543e-4669-ba77-c1499f045f56"), ref _googleMapsFrameUrl, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("a120edec-543e-4669-ba77-c1499f045f56"), ref _googleMapsFrameUrl, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<Settings>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<Settings>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<Settings>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424");
            }
        }

        public static int PropertyIdBlurb {
            get {
                return WAFID.GetPropertyId("256e8c86-83ab-4ddb-92df-eec4e85149cd");
            }
        }

        public static int DataValueIdBlurbBlurb {
            get {
                return WAFID.GetDataValueId("b3b2e8c4-4778-4fdc-9d25-15fe442ebf85");
            }
        }

        public static int PropertyIdStreet_Address {
            get {
                return WAFID.GetPropertyId("d28071d7-f1b2-487b-ae95-290e83bdfc50");
            }
        }

        public static int DataValueIdStreet_AddressStreetAddress {
            get {
                return WAFID.GetDataValueId("ca0267bf-3deb-4553-a62e-39a3465824c2");
            }
        }

        public static int PropertyIdPhone {
            get {
                return WAFID.GetPropertyId("4bc9b9ac-2049-4f07-a13e-bc148e86028c");
            }
        }

        public static int DataValueIdPhonePhone {
            get {
                return WAFID.GetDataValueId("e5a078e8-0e44-4c45-a035-e047a2eb4cfd");
            }
        }

        public static int PropertyIdEmail {
            get {
                return WAFID.GetPropertyId("8d6c8a5a-84cd-410a-931c-15164664dc36");
            }
        }

        public static int DataValueIdEmailEmail {
            get {
                return WAFID.GetDataValueId("1530c913-089a-4b61-a8cd-d76ad3630607");
            }
        }

        public static int PropertyIdSkype {
            get {
                return WAFID.GetPropertyId("fb2695ba-dfa7-4e54-a870-c623e6248b74");
            }
        }

        public static int DataValueIdSkypeSkype {
            get {
                return WAFID.GetDataValueId("8124d97a-b50e-44ae-a1ec-0b73701fded7");
            }
        }

        public static int PropertyIdFacebook_Link {
            get {
                return WAFID.GetPropertyId("95a6710e-ac70-494b-ae0d-2dd63e5a4a4d");
            }
        }

        public static int DataValueIdFacebook_LinkFacebookLink {
            get {
                return WAFID.GetDataValueId("5fe0ed9f-cc74-4271-9bc1-b74bae4f67ac");
            }
        }

        public static int PropertyIdTwitter_Link {
            get {
                return WAFID.GetPropertyId("e5d3ab74-8add-49bf-9f98-acdc053babcb");
            }
        }

        public static int DataValueIdTwitter_LinkTwitterLink {
            get {
                return WAFID.GetDataValueId("61f78b2e-36c4-4d35-8c3b-06365f5203dc");
            }
        }

        public static int PropertyIdInstagram_Link {
            get {
                return WAFID.GetPropertyId("cde54cdf-0575-4967-a3b1-d716b9f602c1");
            }
        }

        public static int DataValueIdInstagram_LinkInstagramLink {
            get {
                return WAFID.GetDataValueId("8f0ca234-5351-4e12-ba1a-7e8c44906e27");
            }
        }

        public static int PropertyIdGoogleMapsFrameUrl {
            get {
                return WAFID.GetPropertyId("c1825abd-78f7-47a8-91a2-d07be81311bc");
            }
        }

        public static int DataValueIdGoogleMapsFrameUrlGoogleMapsFrameUrl {
            get {
                return WAFID.GetDataValueId("a120edec-543e-4669-ba77-c1499f045f56");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("256e8c86-83ab-4ddb-92df-eec4e85149cd")) {
                object init = Blurb;
                return _blurb;
            }
            else if (propertyId == WAFID.GetPropertyId("d28071d7-f1b2-487b-ae95-290e83bdfc50")) {
                object init = Street_Address;
                return _street_Address;
            }
            else if (propertyId == WAFID.GetPropertyId("4bc9b9ac-2049-4f07-a13e-bc148e86028c")) {
                object init = Phone;
                return _phone;
            }
            else if (propertyId == WAFID.GetPropertyId("8d6c8a5a-84cd-410a-931c-15164664dc36")) {
                object init = Email;
                return _email;
            }
            else if (propertyId == WAFID.GetPropertyId("fb2695ba-dfa7-4e54-a870-c623e6248b74")) {
                object init = Skype;
                return _skype;
            }
            else if (propertyId == WAFID.GetPropertyId("95a6710e-ac70-494b-ae0d-2dd63e5a4a4d")) {
                object init = Facebook_Link;
                return _facebook_Link;
            }
            else if (propertyId == WAFID.GetPropertyId("e5d3ab74-8add-49bf-9f98-acdc053babcb")) {
                object init = Twitter_Link;
                return _twitter_Link;
            }
            else if (propertyId == WAFID.GetPropertyId("cde54cdf-0575-4967-a3b1-d716b9f602c1")) {
                object init = Instagram_Link;
                return _instagram_Link;
            }
            else if (propertyId == WAFID.GetPropertyId("c1825abd-78f7-47a8-91a2-d07be81311bc")) {
                object init = GoogleMapsFrameUrl;
                return _googleMapsFrameUrl;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _blurb = null;
            _street_Address = null;
            _phone = null;
            _email = null;
            _skype = null;
            _facebook_Link = null;
            _twitter_Link = null;
            _instagram_Link = null;
            _googleMapsFrameUrl = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.SimpleCompanyWebsite {
    public abstract class SqlSettings {
        public static SqlTable Table {
            get {
                return new SqlTable("settings", WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
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
                    return new SqlFieldShortString("blurb", Table, WAFID.GetDataValueId("b3b2e8c4-4778-4fdc-9d25-15fe442ebf85"));
                }
            }

            public static SqlFieldShortString Street_Address {
                get {
                    return new SqlFieldShortString("street__address", Table, WAFID.GetDataValueId("ca0267bf-3deb-4553-a62e-39a3465824c2"));
                }
            }

            public static SqlFieldShortString Phone {
                get {
                    return new SqlFieldShortString("phone", Table, WAFID.GetDataValueId("e5a078e8-0e44-4c45-a035-e047a2eb4cfd"));
                }
            }

            public static SqlFieldShortString Email {
                get {
                    return new SqlFieldShortString("email", Table, WAFID.GetDataValueId("1530c913-089a-4b61-a8cd-d76ad3630607"));
                }
            }

            public static SqlFieldShortString Skype {
                get {
                    return new SqlFieldShortString("skype", Table, WAFID.GetDataValueId("8124d97a-b50e-44ae-a1ec-0b73701fded7"));
                }
            }

            public static SqlFieldShortString Facebook_Link {
                get {
                    return new SqlFieldShortString("facebook__link", Table, WAFID.GetDataValueId("5fe0ed9f-cc74-4271-9bc1-b74bae4f67ac"));
                }
            }

            public static SqlFieldShortString Twitter_Link {
                get {
                    return new SqlFieldShortString("twitter__link", Table, WAFID.GetDataValueId("61f78b2e-36c4-4d35-8c3b-06365f5203dc"));
                }
            }

            public static SqlFieldShortString Instagram_Link {
                get {
                    return new SqlFieldShortString("instagram__link", Table, WAFID.GetDataValueId("8f0ca234-5351-4e12-ba1a-7e8c44906e27"));
                }
            }

            public static SqlFieldLongString GoogleMapsFrameUrl {
                get {
                    return new SqlFieldLongString("google_maps_frame_url", Table, WAFID.GetDataValueId("a120edec-543e-4669-ba77-c1499f045f56"));
                }
            }

        }
    }
    public class SqlAliasSettings : SqlAlias {
        public SqlAliasSettings()
            : base(SqlSettings.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlSettings.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldShortString Blurb {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Blurb, this);
            }
        }

        public SqlExpressionFieldShortString Street_Address {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Street_Address, this);
            }
        }

        public SqlExpressionFieldShortString Phone {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Phone, this);
            }
        }

        public SqlExpressionFieldShortString Email {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Email, this);
            }
        }

        public SqlExpressionFieldShortString Skype {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Skype, this);
            }
        }

        public SqlExpressionFieldShortString Facebook_Link {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Facebook_Link, this);
            }
        }

        public SqlExpressionFieldShortString Twitter_Link {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Twitter_Link, this);
            }
        }

        public SqlExpressionFieldShortString Instagram_Link {
            get {
                return new SqlExpressionFieldShortString(SqlSettings.Field.Instagram_Link, this);
            }
        }

        public SqlExpressionFieldLongString GoogleMapsFrameUrl {
            get {
                return new SqlExpressionFieldLongString(SqlSettings.Field.GoogleMapsFrameUrl, this);
            }
        }

    }
}
namespace WAF.Engine.Query.SimpleCompanyWebsite {
    [System.Serializable]
    public partial class AqlSettings{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")); 
            }
        }

        public static AqlPropertyShortString Blurb {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Blurb, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Street_Address {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Street_Address, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Phone {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Phone, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Email {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Email, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Skype {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Skype, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Facebook_Link {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Facebook_Link, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Twitter_Link {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Twitter_Link, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString Instagram_Link {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.Instagram_Link, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyLongString GoogleMapsFrameUrl {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.SimpleCompanyWebsite.SqlSettings.Field.GoogleMapsFrameUrl, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
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
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasSettings
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasSettings()
            : base(WAFID.GetContentClassId("51aa7668-ec10-4b1e-8f37-2be94099b424")) {

        }

        public AqlAliasSettings(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyShortString Blurb {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Blurb, this);
            }
        }

        public AqlExpressionPropertyShortString Street_Address {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Street_Address, this);
            }
        }

        public AqlExpressionPropertyShortString Phone {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Phone, this);
            }
        }

        public AqlExpressionPropertyShortString Email {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Email, this);
            }
        }

        public AqlExpressionPropertyShortString Skype {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Skype, this);
            }
        }

        public AqlExpressionPropertyShortString Facebook_Link {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Facebook_Link, this);
            }
        }

        public AqlExpressionPropertyShortString Twitter_Link {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Twitter_Link, this);
            }
        }

        public AqlExpressionPropertyShortString Instagram_Link {
            get {
                return new AqlExpressionPropertyShortString(AqlSettings.Instagram_Link, this);
            }
        }

        public AqlExpressionPropertyLongString GoogleMapsFrameUrl {
            get {
                return new AqlExpressionPropertyLongString(AqlSettings.GoogleMapsFrameUrl, this);
            }
        }

    }
}
