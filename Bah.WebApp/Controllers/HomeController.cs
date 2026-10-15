using Microsoft.AspNetCore.Mvc;

namespace Bah.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
