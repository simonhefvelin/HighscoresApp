using HighscoresApp.Data;
using HighscoresApp.Models.Domain;
using HighscoresApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HighscoresApp.Controllers;

//för att vara tvungen att logga in för att registrera
[Authorize]
public class HighscoresController : Controller
{

    private readonly ApplicationDbContext context;

    public HighscoresController(ApplicationDbContext context)
    {
        this.context = context;
    }

    public IActionResult New()
    {

        var games = context.Games.ToList();
        var viewModel = new NewScoreViewModel()
        {
            Games = games,
            Highscore = new Leaderboard()
        };

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult New(Leaderboard highscore)
    {


        context.Leaderboards.Add(highscore);
        context.SaveChanges();

        return RedirectToAction("Index","Home");
    }

    
}



