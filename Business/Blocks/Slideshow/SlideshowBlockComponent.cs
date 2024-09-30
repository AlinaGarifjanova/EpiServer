//using EPiServer.Web.Mvc;
//using EpiServerProject.Models.Blocks;
//using EpiServerProject.Models.Pages;
//using Microsoft.AspNetCore.Mvc;


//namespace EpiServerProject.Business.Blocks.Slideshow;

//public class SlideshowBlockComponent : AsyncBlockComponent<SlideshowBlock>
//{
//    protected override async Task<IViewComponentResult> InvokeComponentAsync(SlideshowBlock currentContent)
//    {
//        var model = new SlideshowBlockViewModel();

//        foreach(var item in currentContent.Slideshow.FilteredItems.Select(x => x.LoadContent()))
//        {
//            if (item is SlideshowPage)
//            {
//                var page = item as SlideshowPage;
                
//                model.Pages.Add(page!);  
//            }
//        }

//        return await Task.FromResult(View("~/business/blocks/slideshow/default.cshtml", model));
//    }
//}


