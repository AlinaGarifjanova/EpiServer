using EPiServer.Validation.Internal;
using EpiServerProject.Models.Pages;

namespace EpiServerProject.Models.ViewModels;

public class StartPageViewModel : PageViewModel<StartPage>
{
    public StartPageViewModel(StartPage currentPage) : base(currentPage)
    {

    }
}
