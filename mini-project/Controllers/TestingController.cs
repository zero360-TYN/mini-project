using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mini_project.Controllers;

public class TestingController(IConfiguration cf) : Controller
{
    public IActionResult MapTest()
    {
        ViewBag.apikey = cf["Google:ApiKey"];
        return View();
    }
}
