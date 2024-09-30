
using EPiServer.Web;
using EpiServerProject.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace EpiServerProject.Business.Components.SlideShow
{
    public class SlideshowViewComponent : ViewComponent
    {
        private readonly IContentLoader _contentLoader;

        public SlideshowViewComponent(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IViewComponentResult Invoke()
        {
            var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);

            var model = new SlideshowViewComponentModel();
            if (startPage.Content is ContentArea contentArea)
            {
                foreach (var item in contentArea.FilteredItems)
                {
                    var page = item.GetContent() as SlideshowPage;
                    if (page != null)
                    {
                        model.Pages.Add(page);
                    }
                }
            }

            return View("~/business/components/slideshow/default.cshtml", model);
        }

    }
}
