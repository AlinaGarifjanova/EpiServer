using EpiServerProject.Models.Pages;

namespace EpiServerProject.Models.ViewModels
{
    public class MoviePageViewModel : PageViewModel<SearchPage>
    {
        public MoviePageViewModel(SearchPage currentPage) : base(currentPage)
        {
        }

        public MovieDetails Movie { get; set; }
    }
}
