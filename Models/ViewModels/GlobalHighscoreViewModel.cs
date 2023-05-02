using HighscoresApp.Models.Domain;

namespace HighscoresApp.Models.ViewModels;

public class GlobalHighscoreViewModel
{
    public Leaderboard Highscore { get; set; }
    public Game Games { get; set; }
}
