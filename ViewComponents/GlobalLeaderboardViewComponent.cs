using HighscoresApp.Data;
using HighscoresApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighscoresApp.ViewComponents;

public class GlobalLeaderboardViewComponent : ViewComponent
{
    private readonly ApplicationDbContext context;

    public GlobalLeaderboardViewComponent(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync(string gameName)
    {

        var games = context.Games.Include(g => g.Leaderboards).ToList();
        var viewModel = new List<GlobalHighscoreViewModel>();


        foreach (var game in games)
        {

            var highscore = game.Leaderboards.Where(o => o.GameId == game.Id).OrderByDescending(l => l.Score).FirstOrDefault();

            if (highscore != null)
            {
                viewModel.Add(
                new GlobalHighscoreViewModel
                {
                    Highscore = highscore,
                    Games = game
                });

            }
        }

        return View(viewModel);
    }
}