using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static EpiServerProject.Globals;

namespace EpiServerProject.Models.Blocks
{
    [ContentType(GUID = "2D9FF73C-C9D3-4941-98F9-B1F0040B9974", GroupName = GroupNames.Specialized, DisplayName = "Slideshow", Description = "This is a slideshow block template")]
    public class SlideshowBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        [AllowedTypes(typeof(SlideshowBlock))]
        public virtual ContentArea Slideshow { get; set; }
    }
}
