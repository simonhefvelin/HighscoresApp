using HighscoresApp.Models.Domain;

namespace HighscoresApp.Models.ViewModels;

public class NewScoreViewModel
{
    // behöcver bara ett highscore
    public Leaderboard Highscore { get; set; }

    // behöver flera spel
    public IEnumerable<Game> Games { get; set; }
    

}
