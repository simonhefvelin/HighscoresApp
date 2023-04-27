using HighscoresApp.Controllers;
using HighscoresApp.Data;
using HighscoresApp.Models.Domain;
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
        var games = await context.Games.ToListAsync();
        var highScores = await context.Leaderboards
            .Include(s => s.Game)
            .OrderByDescending(s => s.Score)
            .FirstAsync();
            


        var viewModel = new NewScoreViewModel()
        {
            Games = games,
            Highscore = new Leaderboard()
        };

        return View(viewModel);
    }
}