using EpiServerProject.Models.Pages;

namespace EpiServerProject.Models.ViewModels;

public interface IPageViewModel<out T> where T : SitePageData
{
    T CurrentPage { get; }
    LayoutModel Layout { get; set; }
}
