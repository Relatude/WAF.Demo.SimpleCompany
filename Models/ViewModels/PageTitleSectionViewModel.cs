namespace SimpleCompanyWebsite.Models.ViewModels
{
    public class PageTitleSectionViewModel
    {
        public string Name { get; set; }
        public string HeaderSubtitle { get; set; }
        public string IconString { get; set; }

        public PageTitleSectionViewModel(string name, string headerSubTitle, string iconString)
        {
            this.Name = name;
            this.HeaderSubtitle = headerSubTitle;
            this.IconString = iconString;
        }
    }
}
