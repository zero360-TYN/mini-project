using Microsoft.AspNetCore.Mvc;

namespace mini_project.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var vm = new Home.SampleVM
        {
            code = 1,
            value = "Hello World"
        };
        return View();
    }
}
