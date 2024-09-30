using EpiServerProject.Models.Pages;

namespace EpiServerProject.Models.ViewModels
{
    public class SearchPageViewModel : PageViewModel<SearchPage>
    {
        public SearchPageViewModel(SearchPage currentPage) : base(currentPage)
        {
        }

        public List<MovieDetails> Movies{ get; set; }
    }
}
