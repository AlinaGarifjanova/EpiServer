using EPiServer.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static EpiServerProject.Globals;

namespace EpiServerProject.Models.Pages;
[ContentType(
    GUID = "EE440564-C07C-438D-846E-4C374989554C", GroupName = GroupNames.Specialized, DisplayName = "Slideshow", Description = "This is a slideshow template")]
[ImageUrl("/pages/CMS-icon-page-05.png")]
public class SlideshowPage : SitePageData
{
    [Display(GroupName = SystemTabNames.Content, Order = 10)]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; }
   
    [CultureSpecific]
    [Display(Name = "Title", Order = 20 )]
    public virtual string Title { get; set; }

    [CultureSpecific]
    [Display(Name = "Description", Order = 30)]
    public virtual string Description { get; set; }

    [CultureSpecific]
    [Display(Name = "Button Text", Order = 40)]
    public virtual string ButtonText { get; set; }
}
