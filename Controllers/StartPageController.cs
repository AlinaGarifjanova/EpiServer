using EpiServerProject.Models.Pages;
using EpiServerProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EpiServerProject.Controllers;

public class StartPageController : PageControllerBase<StartPage>
{
    public IActionResult Index (StartPage currentPage)
    {
        var model = new StartPageViewModel(currentPage);
       
        return View(model);
    }
}
