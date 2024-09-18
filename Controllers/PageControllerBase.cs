using EPiServer.Web.Mvc;
using EpiServerProject.Models.Pages;

namespace EpiServerProject.Controllers;

public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
{
    
}
