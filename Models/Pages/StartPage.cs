using EpiServerProject.Models.Blocks;
using System.ComponentModel.DataAnnotations;
using static EpiServerProject.Globals;

namespace EpiServerProject.Models.Pages;

[ContentType(GUID = "DA742500-8C7B-4D85-831D-21C495864067", GroupName =GroupNames.Specialized)]
[ImageUrl("/pages/CMS-icon-page-02.png")]
[AvailableContentTypes(Availability.Specific, Include = new[]
{
    typeof(SettingsPage),
    typeof(ArticlePage), 
    typeof(ContainerPage),
    typeof(SlideshowPage),
    typeof(SlideshowBlock),
    typeof(SearchPage),
})]
public class StartPage : SitePageData
{
    [Display(GroupName = SystemTabNames.Content, Order = 10)]
    [CultureSpecific]
    public virtual string Heading { get; set; } = string.Empty;


	[Display(GroupName = SystemTabNames.Content, Order = 20)]
	[CultureSpecific]
    [ScaffoldColumn(false)]
	public virtual XhtmlString MainBody { get; set; }


    [Display(GroupName = SystemTabNames.Content, Order = 30, Name = "Slideshow", Description = "")]
    [AllowedTypes (typeof(SlideshowPage), typeof(SlideshowBlock))]

    public virtual ContentArea Content { get; set; }


}
