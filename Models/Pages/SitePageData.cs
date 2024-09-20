using System.ComponentModel.DataAnnotations;

namespace EpiServerProject.Models.Pages;

public class SitePageData : PageData
{
    [Display(GroupName = Globals.GroupNames.MetaData, Order = 100)]
    [CultureSpecific]
    public virtual string MetaTitle
    {
        get 
        { 
            var metaTitle = this.GetPropertyValue(x => x.MetaTitle); 
            return !string.IsNullOrWhiteSpace(metaTitle) 
                ? metaTitle 
                : PageName;
        }
        set => this.SetPropertyValue(x => x.MetaTitle, value);
    }
}
