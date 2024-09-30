using System.ComponentModel.DataAnnotations;
using static EpiServerProject.Globals;

namespace EpiServerProject.Models.Pages
{
    [ContentType(DisplayName = "Search Page",GUID = "5631DAAB-F3C8-48B2-9E28-050EE597B530", GroupName = GroupNames.Specialized)]
    [ImageUrl("/pages/CMS-icon-page-07.img")]
    public class SearchPage : SitePageData
    {
        //[Display(Name = "Search Query", GroupName = SystemTabNames.Content, Order = 1)]
        //public virtual string SearchQuery { get; set; }
    }
}
