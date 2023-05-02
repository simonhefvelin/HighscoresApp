using HighscoresApp.Data;
using HighscoresApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HighscoresApp.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext context;

        public GamesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("games/{urlSlug}")]
        public IActionResult Game(string urlSlug)
        {
            var game = context.Games.FirstOrDefault(x => x.UrlSlug == urlSlug);
            var viewModel = new GamePlayerViewModel
            {
                Games = game,
                Highscores = context.Leaderboards.Where(x => x.Game.Name == game.Name)
                .OrderByDescending(s => s.Score)
                .Take(10)

            };

            return View(viewModel);
        }


    }
}
