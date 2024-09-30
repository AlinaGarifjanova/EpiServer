namespace EpiServerProject.Models.Pages
{
    [ContentType(GUID = "54C26D5A-8706-43C3-AB4E-A3011F4E09C3", GroupName = Globals.GroupNames.Specialized, DisplayName ="Container")]
    [AvailableContentTypes(Availability.Specific, Include = [typeof(SlideshowPage)])]
    [ImageUrl("/pages/CMS-icon-page-04.png")]
    public class ContainerPage : PageData, IContainerPage
    {

    }
}
