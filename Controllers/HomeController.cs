using HighscoresApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace HighscoresApp.Controllers;

public class HomeController : Controller
{

    private readonly ApplicationDbContext context;

    public HomeController(ApplicationDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {

        return View();
    }
}



