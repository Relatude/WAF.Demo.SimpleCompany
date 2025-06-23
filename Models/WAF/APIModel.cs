// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using System;
using System.Linq;
using System.Collections.Generic;
namespace WAF.API { public class CustomDefinition{ } };

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("98e254d7-3a7d-464f-b824-9e0f165cc7f1")]
public class ControlPanel : WAF.API.Native.HierarchicalContent {
public ControlPanel(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _mainMenuGuid = new Guid("22e11c88-afd4-437c-a9c0-33713fbf8fed");
        [PropertyGuid("22e11c88-afd4-437c-a9c0-33713fbf8fed")]
        public WAF.API.Native.HierarchicalFolder MainMenu{
        get { return DataProvider.GetPropertyValue(_mainMenuGuid) as WAF.API.Native.HierarchicalFolder;}
        set { DataProvider.SetPropertyValue(_mainMenuGuid, value);}
        }
      
        static Guid _logoGuid = new Guid("e4711120-f81a-44c7-9e23-cb5ae6a58879");
        [PropertyGuid("e4711120-f81a-44c7-9e23-cb5ae6a58879")]
        public PropertyTypes.FileInfo Logo {
        get { return DataProvider.GetFileInfo(_logoGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _frontpageGuid = new Guid("0ecaef16-d4a6-43de-b7c5-0eaecb9721c3");
        [PropertyGuid("0ecaef16-d4a6-43de-b7c5-0eaecb9721c3")]
        public WAF.API.SimpleCompanyWebsite.Frontpage Frontpage{
        get { return DataProvider.GetPropertyValue(_frontpageGuid) as WAF.API.SimpleCompanyWebsite.Frontpage;}
        set { DataProvider.SetPropertyValue(_frontpageGuid, value);}
        }
      
        static Guid _portfolioGuid = new Guid("9db543ce-65d3-4fef-aa2f-1964f80e4431");
        [PropertyGuid("9db543ce-65d3-4fef-aa2f-1964f80e4431")]
        public WAF.API.SimpleCompanyWebsite.Portfolio Portfolio{
        get { return DataProvider.GetPropertyValue(_portfolioGuid) as WAF.API.SimpleCompanyWebsite.Portfolio;}
        set { DataProvider.SetPropertyValue(_portfolioGuid, value);}
        }
      
        static Guid _settingsGuid = new Guid("f88a1017-af1f-46f7-a0ee-36f7c6f05329");
        [PropertyGuid("f88a1017-af1f-46f7-a0ee-36f7c6f05329")]
        public WAF.API.SimpleCompanyWebsite.Settings Settings{
        get { return DataProvider.GetPropertyValue(_settingsGuid) as WAF.API.SimpleCompanyWebsite.Settings;}
        set { DataProvider.SetPropertyValue(_settingsGuid, value);}
        }
      
        static Guid _contactPageGuid = new Guid("b06389e6-fe3c-4004-a635-ac6170c03e8e");
        [PropertyGuid("b06389e6-fe3c-4004-a635-ac6170c03e8e")]
        public WAF.API.SimpleCompanyWebsite.ContactPage ContactPage{
        get { return DataProvider.GetPropertyValue(_contactPageGuid) as WAF.API.SimpleCompanyWebsite.ContactPage;}
        set { DataProvider.SetPropertyValue(_contactPageGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("374198d5-2ae5-4f72-b189-d5924647734e")]
public class SocialMediaLink : WAF.API.Native.InnerContentBase {
public SocialMediaLink(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _linkGuid = new Guid("6138a3b1-64ea-4d51-b368-dd35bb1caeb1");
        [PropertyGuid("6138a3b1-64ea-4d51-b368-dd35bb1caeb1")]
        public string Link {
        get { return (string)DataProvider.GetPropertyValue(_linkGuid); }
        set { DataProvider.SetPropertyValue(_linkGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("3b48fa07-f106-4473-9055-ce122d0d059c")]
public class Project : WAF.API.Native.HierarchicalContent {
public Project(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _blurbGuid = new Guid("be5e19b8-43d3-4fd4-8751-b30e7dbf0cb9");
        [PropertyGuid("be5e19b8-43d3-4fd4-8751-b30e7dbf0cb9")]
        public string Blurb {
        get { return (string)DataProvider.GetPropertyValue(_blurbGuid); }
        set { DataProvider.SetPropertyValue(_blurbGuid, value); }
        }
      
        static Guid _mainImageGuid = new Guid("a4ec9abe-f633-414c-98db-e7e77308e708");
        [PropertyGuid("a4ec9abe-f633-414c-98db-e7e77308e708")]
        public PropertyTypes.FileInfo MainImage {
        get { return DataProvider.GetFileInfo(_mainImageGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _imageSeriesGuid = new Guid("c10e7e95-ad9c-42e4-838e-ea6f0d95650d");
        [PropertyGuid("c10e7e95-ad9c-42e4-838e-ea6f0d95650d")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> ImageSeries {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_imageSeriesGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_imageSeriesGuid, value);}
        }
      
        static Guid _date_StartedGuid = new Guid("a053e8e9-12cb-4988-8e08-3f6b041d038d");
        [PropertyGuid("a053e8e9-12cb-4988-8e08-3f6b041d038d")]
        public DateTime Date_Started {
        get { return (DateTime)DataProvider.GetPropertyValue(_date_StartedGuid); }
        set { DataProvider.SetPropertyValue(_date_StartedGuid, value); }
        }
      
        static Guid _date_EndedGuid = new Guid("28f1be51-afd0-4f01-94ce-951b71318e08");
        [PropertyGuid("28f1be51-afd0-4f01-94ce-951b71318e08")]
        public DateTime Date_Ended {
        get { return (DateTime)DataProvider.GetPropertyValue(_date_EndedGuid); }
        set { DataProvider.SetPropertyValue(_date_EndedGuid, value); }
        }
      
        static Guid _related_Power_TypesGuid = new Guid("e31c5d1b-101b-4fa1-951f-1dc71717a58f");
        [PropertyGuid("e31c5d1b-101b-4fa1-951f-1dc71717a58f")]
        public string[] Related_Power_Types {
        get { return (string[])DataProvider.GetPropertyValue(_related_Power_TypesGuid); }
        set { DataProvider.SetPropertyValue(_related_Power_TypesGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("51aa7668-ec10-4b1e-8f37-2be94099b424")]
public class Settings : WAF.API.Native.HierarchicalContent {
public Settings(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _blurbGuid = new Guid("256e8c86-83ab-4ddb-92df-eec4e85149cd");
        [PropertyGuid("256e8c86-83ab-4ddb-92df-eec4e85149cd")]
        public string Blurb {
        get { return (string)DataProvider.GetPropertyValue(_blurbGuid); }
        set { DataProvider.SetPropertyValue(_blurbGuid, value); }
        }
      
        static Guid _street_AddressGuid = new Guid("d28071d7-f1b2-487b-ae95-290e83bdfc50");
        [PropertyGuid("d28071d7-f1b2-487b-ae95-290e83bdfc50")]
        public string Street_Address {
        get { return (string)DataProvider.GetPropertyValue(_street_AddressGuid); }
        set { DataProvider.SetPropertyValue(_street_AddressGuid, value); }
        }
      
        static Guid _phoneGuid = new Guid("4bc9b9ac-2049-4f07-a13e-bc148e86028c");
        [PropertyGuid("4bc9b9ac-2049-4f07-a13e-bc148e86028c")]
        public string Phone {
        get { return (string)DataProvider.GetPropertyValue(_phoneGuid); }
        set { DataProvider.SetPropertyValue(_phoneGuid, value); }
        }
      
        static Guid _emailGuid = new Guid("8d6c8a5a-84cd-410a-931c-15164664dc36");
        [PropertyGuid("8d6c8a5a-84cd-410a-931c-15164664dc36")]
        public string Email {
        get { return (string)DataProvider.GetPropertyValue(_emailGuid); }
        set { DataProvider.SetPropertyValue(_emailGuid, value); }
        }
      
        static Guid _skypeGuid = new Guid("fb2695ba-dfa7-4e54-a870-c623e6248b74");
        [PropertyGuid("fb2695ba-dfa7-4e54-a870-c623e6248b74")]
        public string Skype {
        get { return (string)DataProvider.GetPropertyValue(_skypeGuid); }
        set { DataProvider.SetPropertyValue(_skypeGuid, value); }
        }
      
        static Guid _facebook_LinkGuid = new Guid("95a6710e-ac70-494b-ae0d-2dd63e5a4a4d");
        [PropertyGuid("95a6710e-ac70-494b-ae0d-2dd63e5a4a4d")]
        public string Facebook_Link {
        get { return (string)DataProvider.GetPropertyValue(_facebook_LinkGuid); }
        set { DataProvider.SetPropertyValue(_facebook_LinkGuid, value); }
        }
      
        static Guid _twitter_LinkGuid = new Guid("e5d3ab74-8add-49bf-9f98-acdc053babcb");
        [PropertyGuid("e5d3ab74-8add-49bf-9f98-acdc053babcb")]
        public string Twitter_Link {
        get { return (string)DataProvider.GetPropertyValue(_twitter_LinkGuid); }
        set { DataProvider.SetPropertyValue(_twitter_LinkGuid, value); }
        }
      
        static Guid _instagram_LinkGuid = new Guid("cde54cdf-0575-4967-a3b1-d716b9f602c1");
        [PropertyGuid("cde54cdf-0575-4967-a3b1-d716b9f602c1")]
        public string Instagram_Link {
        get { return (string)DataProvider.GetPropertyValue(_instagram_LinkGuid); }
        set { DataProvider.SetPropertyValue(_instagram_LinkGuid, value); }
        }
      
        static Guid _googleMapsFrameUrlGuid = new Guid("c1825abd-78f7-47a8-91a2-d07be81311bc");
        [PropertyGuid("c1825abd-78f7-47a8-91a2-d07be81311bc")]
        public string GoogleMapsFrameUrl {
        get { return (string)DataProvider.GetPropertyValue(_googleMapsFrameUrlGuid); }
        set { DataProvider.SetPropertyValue(_googleMapsFrameUrlGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("46830257-9d67-485c-8bb1-4f09812c414b")]
public class Frontpage : WAF.API.SimpleCompanyWebsite.BaseItem {
public Frontpage(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _titleTextGuid = new Guid("1e6e68da-e702-441f-8d3b-2b5a94180755");
        [PropertyGuid("1e6e68da-e702-441f-8d3b-2b5a94180755")]
        public string TitleText {
        get { return (string)DataProvider.GetPropertyValue(_titleTextGuid); }
        set { DataProvider.SetPropertyValue(_titleTextGuid, value); }
        }
      
        static Guid _coverImagesGuid = new Guid("2be896ef-4dbf-4edc-b6a3-bdb9d673d6b3");
        [PropertyGuid("2be896ef-4dbf-4edc-b6a3-bdb9d673d6b3")]
        public System.Collections.Generic.List<WAF.API.Native.InnerFile> CoverImages {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_coverImagesGuid)).Cast<WAF.API.Native.InnerFile>().ToList();}
        set {DataProvider.SetPropertyValue(_coverImagesGuid, value);}
        }
      
        static Guid _paragraphsGuid = new Guid("3f80c15e-5fb4-460b-a5af-15cc08ce8525");
        [PropertyGuid("3f80c15e-5fb4-460b-a5af-15cc08ce8525")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> Paragraphs {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_paragraphsGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_paragraphsGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("92565199-f47a-4d2f-82e2-d3960748f002")]
public class Paragraph_Text : WAF.API.Native.InnerContentBase {
public Paragraph_Text(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headlineGuid = new Guid("52f2fd9b-645b-4d98-92d8-c52339812142");
        [PropertyGuid("52f2fd9b-645b-4d98-92d8-c52339812142")]
        public string Headline {
        get { return (string)DataProvider.GetPropertyValue(_headlineGuid); }
        set { DataProvider.SetPropertyValue(_headlineGuid, value); }
        }
      
        static Guid _textGuid = new Guid("644975f8-e71f-41ec-bbe1-40cec4a12745");
        [PropertyGuid("644975f8-e71f-41ec-bbe1-40cec4a12745")]
        public string Text {
        get { return (string)DataProvider.GetPropertyValue(_textGuid); }
        set { DataProvider.SetPropertyValue(_textGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("d85178ea-7906-4bb5-b267-46d69f4792ce")]
public class Article : WAF.API.SimpleCompanyWebsite.BaseItem {
public Article(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _paragraphsGuid = new Guid("ded7b1c9-a5e9-450b-8291-a4aed2ef2d9b");
        [PropertyGuid("ded7b1c9-a5e9-450b-8291-a4aed2ef2d9b")]
        public System.Collections.Generic.List<WAF.API.Native.InnerContentBase> Paragraphs {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_paragraphsGuid)).Cast<WAF.API.Native.InnerContentBase>().ToList();}
        set {DataProvider.SetPropertyValue(_paragraphsGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("4ae79785-a951-44c3-bee2-2222f513753c")]
public class Paragraph_Employee : WAF.API.Native.InnerContentBase {
public Paragraph_Employee(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headlineGuid = new Guid("e7c3e7eb-b22c-48a1-9c29-52aa241c8a8b");
        [PropertyGuid("e7c3e7eb-b22c-48a1-9c29-52aa241c8a8b")]
        public string Headline {
        get { return (string)DataProvider.GetPropertyValue(_headlineGuid); }
        set { DataProvider.SetPropertyValue(_headlineGuid, value); }
        }
      
        static Guid _employeesGuid = new Guid("e9980337-9f07-4624-be3c-0fe382f5429a");
        [PropertyGuid("e9980337-9f07-4624-be3c-0fe382f5429a")]
        public System.Collections.Generic.List<WAF.API.SimpleCompanyWebsite.EmployeeContainer> Employees {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_employeesGuid)).Cast<WAF.API.SimpleCompanyWebsite.EmployeeContainer>().ToList();}
        set {DataProvider.SetPropertyValue(_employeesGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("9e9050f8-a3e7-4e99-a226-789abe083b67")]
public class Paragraph_Testimonial : WAF.API.Native.InnerContentBase {
public Paragraph_Testimonial(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headlineGuid = new Guid("c28bb8d1-86e5-409e-a934-581c9ed490a7");
        [PropertyGuid("c28bb8d1-86e5-409e-a934-581c9ed490a7")]
        public string Headline {
        get { return (string)DataProvider.GetPropertyValue(_headlineGuid); }
        set { DataProvider.SetPropertyValue(_headlineGuid, value); }
        }
      
        static Guid _testimonialGuid = new Guid("22c779d3-9029-4f8f-b42b-a8929348c780");
        [PropertyGuid("22c779d3-9029-4f8f-b42b-a8929348c780")]
        public WAF.API.SimpleCompanyWebsite.Testimonial Testimonial{
        get { return DataProvider.GetPropertyValue(_testimonialGuid) as WAF.API.SimpleCompanyWebsite.Testimonial;}
        set { DataProvider.SetPropertyValue(_testimonialGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("ea1cbbc0-ebf1-4201-a09f-ced1848597c1")]
public class Paragraph_Service : WAF.API.Native.InnerContentBase {
public Paragraph_Service(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _titleGuid = new Guid("897411c9-7f81-4dab-9335-a9a81e62dee5");
        [PropertyGuid("897411c9-7f81-4dab-9335-a9a81e62dee5")]
        public string Title {
        get { return (string)DataProvider.GetPropertyValue(_titleGuid); }
        set { DataProvider.SetPropertyValue(_titleGuid, value); }
        }
      
        static Guid _servicesGuid = new Guid("a69790b6-4dce-489c-80e7-4db7dc7e273b");
        [PropertyGuid("a69790b6-4dce-489c-80e7-4db7dc7e273b")]
        public System.Collections.Generic.List<WAF.API.SimpleCompanyWebsite.Service> Services {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_servicesGuid)).Cast<WAF.API.SimpleCompanyWebsite.Service>().ToList();}
        set {DataProvider.SetPropertyValue(_servicesGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("decf5c3d-3575-4e3c-92b8-9f3e0523b793")]
public class Paragraph_ImageSeries : WAF.API.Native.InnerContentBase {
public Paragraph_ImageSeries(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _imagesGuid = new Guid("8f2afe8b-1d7a-4a80-bed1-3a6e97cbd597");
        [PropertyGuid("8f2afe8b-1d7a-4a80-bed1-3a6e97cbd597")]
        public System.Collections.Generic.List<WAF.API.SimpleCompanyWebsite.Paragraph_Image> Images {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_imagesGuid)).Cast<WAF.API.SimpleCompanyWebsite.Paragraph_Image>().ToList();}
        set {DataProvider.SetPropertyValue(_imagesGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("61a4bc12-1d7f-42c4-9f22-cbe5873529cd")]
public class Paragraph_Image : WAF.API.Native.InnerContentBase {
public Paragraph_Image(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _imageGuid = new Guid("89876a0c-2269-478f-8e64-7ad2f1bc4423");
        [PropertyGuid("89876a0c-2269-478f-8e64-7ad2f1bc4423")]
        public PropertyTypes.FileInfo Image {
        get { return DataProvider.GetFileInfo(_imageGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _image_TextGuid = new Guid("40e2da4c-9995-4be1-804c-d4a845e34e95");
        [PropertyGuid("40e2da4c-9995-4be1-804c-d4a845e34e95")]
        public string Image_Text {
        get { return (string)DataProvider.GetPropertyValue(_image_TextGuid); }
        set { DataProvider.SetPropertyValue(_image_TextGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("30c4716f-70c2-460e-ad1e-c6cc6a07d5a0")]
public class EmployeeContainer : WAF.API.Native.InnerContentBase {
public EmployeeContainer(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _employeeGuid = new Guid("0d1416d4-e6b0-4662-aa27-63c8591bd491");
        [PropertyGuid("0d1416d4-e6b0-4662-aa27-63c8591bd491")]
        public WAF.API.SimpleCompanyWebsite.Employee Employee{
        get { return DataProvider.GetPropertyValue(_employeeGuid) as WAF.API.SimpleCompanyWebsite.Employee;}
        set { DataProvider.SetPropertyValue(_employeeGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("a7137566-33ff-49af-bfae-653994675fb1")]
public class Service : WAF.API.Native.InnerContentBase {
public Service(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _fontAwesome_StringGuid = new Guid("916eec50-ba3b-494a-9f0d-b2be86eec574");
        [PropertyGuid("916eec50-ba3b-494a-9f0d-b2be86eec574")]
        public string FontAwesome_String {
        get { return (string)DataProvider.GetPropertyValue(_fontAwesome_StringGuid); }
        set { DataProvider.SetPropertyValue(_fontAwesome_StringGuid, value); }
        }
      
        static Guid _titleGuid = new Guid("5bb1dcd0-881d-4358-8953-4000fe6809a4");
        [PropertyGuid("5bb1dcd0-881d-4358-8953-4000fe6809a4")]
        public string Title {
        get { return (string)DataProvider.GetPropertyValue(_titleGuid); }
        set { DataProvider.SetPropertyValue(_titleGuid, value); }
        }
      
        static Guid _blurbGuid = new Guid("2662028d-70db-498b-bd15-4580accf6c3a");
        [PropertyGuid("2662028d-70db-498b-bd15-4580accf6c3a")]
        public string Blurb {
        get { return (string)DataProvider.GetPropertyValue(_blurbGuid); }
        set { DataProvider.SetPropertyValue(_blurbGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("966d7227-69e0-4b7a-8475-b89ad21a972a")]
public class BaseItem : WAF.API.Native.HierarchicalContent {
public BaseItem(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _headerSubtitleGuid = new Guid("df0d5fd9-2625-4255-8e78-162d941c0d8c");
        [PropertyGuid("df0d5fd9-2625-4255-8e78-162d941c0d8c")]
        public string HeaderSubtitle {
        get { return (string)DataProvider.GetPropertyValue(_headerSubtitleGuid); }
        set { DataProvider.SetPropertyValue(_headerSubtitleGuid, value); }
        }
      
        static Guid _fontAwesome_IconStringGuid = new Guid("b2b6fb28-2859-42e2-915d-86d09e2d8021");
        [PropertyGuid("b2b6fb28-2859-42e2-915d-86d09e2d8021")]
        public string FontAwesome_IconString {
        get { return (string)DataProvider.GetPropertyValue(_fontAwesome_IconStringGuid); }
        set { DataProvider.SetPropertyValue(_fontAwesome_IconStringGuid, value); }
        }
      
        static Guid _top_Level_Is_LinkGuid = new Guid("fdfffc5b-7ed0-4772-8292-ec355a262999");
        [PropertyGuid("fdfffc5b-7ed0-4772-8292-ec355a262999")]
        public bool Top_Level_Is_Link {
        get { return (bool)DataProvider.GetPropertyValue(_top_Level_Is_LinkGuid); }
        set { DataProvider.SetPropertyValue(_top_Level_Is_LinkGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("587718a4-c62d-43f0-83b5-59725f604589")]
public class Employee : WAF.API.Native.SystemUser {
public Employee(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _descriptionGuid = new Guid("5653f445-7bbf-4fdd-a384-238502b3574b");
        [PropertyGuid("5653f445-7bbf-4fdd-a384-238502b3574b")]
        public string Description {
        get { return (string)DataProvider.GetPropertyValue(_descriptionGuid); }
        set { DataProvider.SetPropertyValue(_descriptionGuid, value); }
        }
      
        static Guid _socialMediaLinksGuid = new Guid("9486ca01-df77-4695-aa97-b5fc1b803d32");
        [PropertyGuid("9486ca01-df77-4695-aa97-b5fc1b803d32")]
        public System.Collections.Generic.List<WAF.API.SimpleCompanyWebsite.SocialMediaLink> SocialMediaLinks {
        get {return ((IQueryable<WAF.API.IInnerContent>)DataProvider.GetPropertyValue(_socialMediaLinksGuid)).Cast<WAF.API.SimpleCompanyWebsite.SocialMediaLink>().ToList();}
        set {DataProvider.SetPropertyValue(_socialMediaLinksGuid, value);}
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("6415a6a8-37e1-4dcd-8244-bb9b7d94bc3d")]
public class Testimonial : WAF.API.Native.HierarchicalContent {
public Testimonial(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _userPhotoGuid = new Guid("89acb27f-be77-4b28-9020-cc2ebb46fadf");
        [PropertyGuid("89acb27f-be77-4b28-9020-cc2ebb46fadf")]
        public PropertyTypes.FileInfo UserPhoto {
        get { return DataProvider.GetFileInfo(_userPhotoGuid); }
        set { throw new NotSupportedException(); }
        }
      
        static Guid _testimonyGuid = new Guid("2d061a1c-6c3e-43b1-b2da-54377f91ba7a");
        [PropertyGuid("2d061a1c-6c3e-43b1-b2da-54377f91ba7a")]
        public string Testimony {
        get { return (string)DataProvider.GetPropertyValue(_testimonyGuid); }
        set { DataProvider.SetPropertyValue(_testimonyGuid, value); }
        }
      
        static Guid _userNameGuid = new Guid("ed5f9c25-1279-464d-8681-315e7ca03ecc");
        [PropertyGuid("ed5f9c25-1279-464d-8681-315e7ca03ecc")]
        public string UserName {
        get { return (string)DataProvider.GetPropertyValue(_userNameGuid); }
        set { DataProvider.SetPropertyValue(_userNameGuid, value); }
        }
      
        static Guid _locationGuid = new Guid("faa65802-27af-4469-90a1-b17f5800b030");
        [PropertyGuid("faa65802-27af-4469-90a1-b17f5800b030")]
        public string Location {
        get { return (string)DataProvider.GetPropertyValue(_locationGuid); }
        set { DataProvider.SetPropertyValue(_locationGuid, value); }
        }
      
        static Guid _contactLinkGuid = new Guid("41523af6-128d-4576-8c18-976cbea8e322");
        [PropertyGuid("41523af6-128d-4576-8c18-976cbea8e322")]
        public string ContactLink {
        get { return (string)DataProvider.GetPropertyValue(_contactLinkGuid); }
        set { DataProvider.SetPropertyValue(_contactLinkGuid, value); }
        }
      
        static Guid _dateOfTestimonyGuid = new Guid("1b4b5c9d-4373-49f7-8959-29454ee40ae5");
        [PropertyGuid("1b4b5c9d-4373-49f7-8959-29454ee40ae5")]
        public DateTime DateOfTestimony {
        get { return (DateTime)DataProvider.GetPropertyValue(_dateOfTestimonyGuid); }
        set { DataProvider.SetPropertyValue(_dateOfTestimonyGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("12a94109-7b36-41b9-8a8e-510e5a94dd94")]
public class Paragraph_CallToActionLink : WAF.API.Native.InnerContentBase {
public Paragraph_CallToActionLink(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _linkGuid = new Guid("7e225b4e-d7ea-40d3-b96c-a22fcd6abcf7");
        [PropertyGuid("7e225b4e-d7ea-40d3-b96c-a22fcd6abcf7")]
        public string Link {
        get { return (string)DataProvider.GetPropertyValue(_linkGuid); }
        set { DataProvider.SetPropertyValue(_linkGuid, value); }
        }
      
        static Guid _linkTextGuid = new Guid("916876cb-25b5-45ff-9b91-e045580e66ca");
        [PropertyGuid("916876cb-25b5-45ff-9b91-e045580e66ca")]
        public string LinkText {
        get { return (string)DataProvider.GetPropertyValue(_linkTextGuid); }
        set { DataProvider.SetPropertyValue(_linkTextGuid, value); }
        }
      
        static Guid _bannerTextGuid = new Guid("75b43348-d2b1-4df9-a81b-a4c6928c0bbd");
        [PropertyGuid("75b43348-d2b1-4df9-a81b-a4c6928c0bbd")]
        public string BannerText {
        get { return (string)DataProvider.GetPropertyValue(_bannerTextGuid); }
        set { DataProvider.SetPropertyValue(_bannerTextGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("618b2529-f69b-4e58-bc11-48f1917b339b")]
public class Paragraph_Text_Two_Column : WAF.API.Native.InnerContentBase {
public Paragraph_Text_Two_Column(IInnerContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _left_Column_HeadlineGuid = new Guid("e0ec85b7-ab09-4fc9-bf5a-cd4ab4e6b050");
        [PropertyGuid("e0ec85b7-ab09-4fc9-bf5a-cd4ab4e6b050")]
        public string Left_Column_Headline {
        get { return (string)DataProvider.GetPropertyValue(_left_Column_HeadlineGuid); }
        set { DataProvider.SetPropertyValue(_left_Column_HeadlineGuid, value); }
        }
      
        static Guid _left_Column_TextGuid = new Guid("0e01d547-4ccf-4429-9c78-5dcc628ac0f5");
        [PropertyGuid("0e01d547-4ccf-4429-9c78-5dcc628ac0f5")]
        public string Left_Column_Text {
        get { return (string)DataProvider.GetPropertyValue(_left_Column_TextGuid); }
        set { DataProvider.SetPropertyValue(_left_Column_TextGuid, value); }
        }
      
        static Guid _right_Column_HeadlineGuid = new Guid("59541c95-50e4-48cb-92b8-4f595111a0f4");
        [PropertyGuid("59541c95-50e4-48cb-92b8-4f595111a0f4")]
        public string Right_Column_Headline {
        get { return (string)DataProvider.GetPropertyValue(_right_Column_HeadlineGuid); }
        set { DataProvider.SetPropertyValue(_right_Column_HeadlineGuid, value); }
        }
      
        static Guid _right_Column_TextGuid = new Guid("ffe27a56-1aa3-473d-b684-192c68ab2887");
        [PropertyGuid("ffe27a56-1aa3-473d-b684-192c68ab2887")]
        public string Right_Column_Text {
        get { return (string)DataProvider.GetPropertyValue(_right_Column_TextGuid); }
        set { DataProvider.SetPropertyValue(_right_Column_TextGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("0d9916cf-1f69-4109-8e13-8dc94947062e")]
public class ContactPage : WAF.API.SimpleCompanyWebsite.BaseItem {
public ContactPage(IContentDataProvider dataProvider)
: base(dataProvider) {}
        static Guid _formTextGuid = new Guid("5ea9f0ec-c925-4a98-8be4-47fc07163ee4");
        [PropertyGuid("5ea9f0ec-c925-4a98-8be4-47fc07163ee4")]
        public string FormText {
        get { return (string)DataProvider.GetPropertyValue(_formTextGuid); }
        set { DataProvider.SetPropertyValue(_formTextGuid, value); }
        }
      
        static Guid _formContainerGuid = new Guid("01abd864-1525-4af6-8f8c-6b19d3af855c");
        [PropertyGuid("01abd864-1525-4af6-8f8c-6b19d3af855c")]
        public string FormContainer {
        get { return (string)DataProvider.GetPropertyValue(_formContainerGuid); }
        set { DataProvider.SetPropertyValue(_formContainerGuid, value); }
        }
      
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("4d7223ba-925e-4446-bdfb-0fdaca6331ec")]
public class Portfolio : WAF.API.SimpleCompanyWebsite.BaseItem {
public Portfolio(IContentDataProvider dataProvider)
: base(dataProvider) {}
}
}

namespace WAF.API.SimpleCompanyWebsite {
[ClassGuid("931c3d04-192e-49dd-8af4-93fb8cae0f24")]
public class EmployeesPage : WAF.API.SimpleCompanyWebsite.BaseItem {
public EmployeesPage(IContentDataProvider dataProvider)
: base(dataProvider) {}
}
}



namespace WAF.API.GraphQL {
public class RelatudeContentQuery {
WAF.API.Web.WAFNativeContext _ctx;
public RelatudeContentQuery(WAF.API.Web.WAFNativeContext ctx) {
  _ctx = ctx;
}


[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPage>> GetBlogPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Blog>> GetBlogs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Blog>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogCategory>> GetBlogCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BlogPost>> GetBlogPosts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BlogPost>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentFile>> GetContentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DefCulture>> GetDefCultures() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DefCulture>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentSnapshot>> GetContentSnapshots() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentSnapshot>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DocumentFile>> GetDocumentFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DocumentFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Domain>> GetDomains() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Domain>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UrlStatus>> GetUrlStati() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UrlStatus>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Installation>> GetInstallatia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Installation>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentTag>> GetContentTags() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentTag>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagVocabulary>> GetTagVocabularies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagVocabulary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TagTerm>> GetTagTerms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TagTerm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileConversion>> GetFileConversia() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileConversion>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileFolder>> GetFileFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileLibrary>> GetFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Fileshare>> GetFileshares() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Fileshare>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFile>> GetFileshareFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.FileshareFolder>> GetFileshareFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.FileshareFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Forum>> GetForums() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Forum>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumCategory>> GetForumCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumGlobalSettings>> GetForumGlobalSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumGlobalSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumMessage>> GetForumMessages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumMessage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumRank>> GetForumRanks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumRank>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ForumThread>> GetForumThreads() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ForumThread>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.GroupFileLibrary>> GetGroupFileLibraries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.GroupFileLibrary>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalContent>> GetHierarchicalContents() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalContent>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ImageFile>> GetImageFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ImageFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.LogSetting>> GetLogSettings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.LogSetting>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Module>> GetModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Module>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Newsletter>> GetNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Newsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterDelivery>> GetNewsletterDeliveries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterDelivery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterRecipientList>> GetNewsletterRecipientLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterRecipientList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ScheduledTask>> GetScheduledTasks() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ScheduledTask>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Site>> GetSites() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Site>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SoundFile>> GetSoundFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SoundFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Stylesheet>> GetStylesheets() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Stylesheet>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SystemUser>> GetSystemUsers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SystemUser>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Template>> GetTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Template>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MVCTemplate>> GetMVCTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MVCTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UserGroup>> GetUserGroups() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UserGroup>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VideoFile>> GetVideoFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VideoFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.InteractiveFile>> GetInteractiveFiles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.InteractiveFile>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HierarchicalFolder>> GetHierarchicalFolders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HierarchicalFolder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SpecializedPage>> GetSpecializedPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SpecializedPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.RedirectPage>> GetRedirectPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.RedirectPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.MessageBase>> GetMessageBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.MessageBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SMS>> GetSMSs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SMS>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQueryBase>> GetContentQueryBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQueryBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentQuery>> GetContentQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.JoinQuery>> GetJoinQueries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.JoinQuery>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.QueryFilter>> GetQueryFilters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.QueryFilter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ArticleBase>> GetArticleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ArticleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebForm>> GetWebForms() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebForm>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.WebFormSubmit>> GetWebFormSubmits() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.WebFormSubmit>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBase>> GetProductBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductCategory>> GetProductCategories() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductCategory>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Shop>> GetShops() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Shop>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Review>> GetReviews() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Review>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Order>> GetOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Order>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OrderItem>> GetOrderItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OrderItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Currency>> GetCurrencies() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Currency>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Country>> GetCountries() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Country>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Manufacturer>> GetManufacturers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Manufacturer>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShippingMethod>> GetShippingMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShippingMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PaymentMethod>> GetPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DashboardBox>> GetDashboardBoxes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DashboardBox>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ShopEmail>> GetShopEmails() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ShopEmail>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountBase>> GetDiscountBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UsedDiscount>> GetUsedDiscounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UsedDiscount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProduct>> GetDiscountPercentageOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductImport>> GetProductImports() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductImport>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProduct>> GetDiscountAmountOffProducts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProduct>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffOrder>> GetDiscountAmountOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffOrder>> GetDiscountPercentageOffOrders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffOrder>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffShipping>> GetDiscountPercentageOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffShipping>> GetDiscountAmountOffShippings() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffShipping>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>> GetDiscountAmountOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountAmountOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>> GetDiscountPercentageOffProductYWhenBuyingXs() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.DiscountPercentageOffProductYWhenBuyingX>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.CreditCardPaymentMethod>> GetCreditCardPaymentMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.CreditCardPaymentMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductBundle>> GetProductBundles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductBundle>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ItemCostShippingCalculationMethod>> GetItemCostShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ItemCostShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.PercentageShippingCalculationMethod>> GetPercentageShippingCalculationMethods() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.PercentageShippingCalculationMethod>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.AdaptiveNewsletter>> GetAdaptiveNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.AdaptiveNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.NewsletterTemplate>> GetNewsletterTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.NewsletterTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.BasicNewsletter>> GetBasicNewsletters() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.BasicNewsletter>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.VisitorSegment>> GetVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.VisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StandardVisitorSegment>> GetStandardVisitorSegments() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StandardVisitorSegment>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SegmentationSettings>> GetSegmentationSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SegmentationSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxClass>> GetTaxClasses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxClass>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.TaxRate>> GetTaxRates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.TaxRate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.Chat>> GetChats() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.Chat>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ChatAccount>> GetChatAccounts() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ChatAccount>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StorageProvider>> GetStorageProviders() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StorageProvider>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentCardTemplate>> GetContentCardTemplates() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentCardTemplate>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIMenuItem>> GetUIMenuItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIMenuItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.UIPlugIn>> GetUIPlugIns() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.UIPlugIn>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.OptimizingModule>> GetOptimizingModules() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.OptimizingModule>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ContentModuleBase>> GetContentModuleBases() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ContentModuleBase>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.HeadlessServer>> GetHeadlessServers() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.HeadlessServer>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.ProductList>> GetProductLists() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.ProductList>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.StatisticsSettings>> GetStatisticsSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.StatisticsSettings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.Native.SalesChannel>> GetSalesChannels() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.Native.SalesChannel>(QueryOptions.Default).ToList().AsQueryable());
}


[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.ControlPanel>> GetControlPanels() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.ControlPanel>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Project>> GetProjects() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Project>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Settings>> GetSettingses() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Settings>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Frontpage>> GetFrontpages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Frontpage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Article>> GetArticles() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Article>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.BaseItem>> GetBaseItems() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.BaseItem>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Employee>> GetEmployees() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Employee>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Testimonial>> GetTestimonials() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Testimonial>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.ContactPage>> GetContactPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.ContactPage>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.Portfolio>> GetPortfolioes() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.Portfolio>(QueryOptions.Default).ToList().AsQueryable());
}

[HotChocolate.Types.UsePaging(IncludeTotalCount=true, DefaultPageSize=25)]
[HotChocolate.Data.UseFiltering]
[HotChocolate.Data.UseSorting]
public Task<IQueryable<WAF.API.SimpleCompanyWebsite.EmployeesPage>> GetEmployeesPages() {
   return Task.FromResult(_ctx.Session.APISession.Query<WAF.API.SimpleCompanyWebsite.EmployeesPage>(QueryOptions.Default).ToList().AsQueryable());
}
}
}

