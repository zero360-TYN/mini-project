using Microsoft.AspNetCore.Mvc;

namespace mini_project.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
