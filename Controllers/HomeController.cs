using HighscoresApp.Data;
using HighscoresApp.Models.Domain;
using HighscoresApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        
        var games = context.Games.Include(g => g.Leaderboards).ToList();
        var viewModel = new GamePlayerViewModel();

        
        foreach (var game in games)
        {
            
            var highscore = game.Leaderboards.OrderByDescending(l => l.Score).FirstOrDefault();

            if (highscore != null)
            {
                
                viewModel.Highscores = new List<Leaderboard> { highscore };
                viewModel.Games = game;

                
                return View(viewModel);
            }
        }
        
        return View(viewModel);
    }
}



