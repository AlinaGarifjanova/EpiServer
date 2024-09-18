using System.ComponentModel.DataAnnotations;
using static EpiServerProject.Globals;

namespace EpiServerProject.Models.Pages;

[ContentType(GUID = "DA742500-8C7B-4D85-831D-21C495864067", GroupName =GroupNames.Specialized)]
public class StartPage : SitePageData
{
    [Display(GroupName = SystemTabNames.Content)]
    [CultureSpecific]
    public virtual string Heading { get; set; } = string.Empty;

}
