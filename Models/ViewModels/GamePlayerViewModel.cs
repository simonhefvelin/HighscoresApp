using HighscoresApp.Models.Domain;

namespace HighscoresApp.Models.ViewModels;

public class GamePlayerViewModel
{  
    // brhöver flera highscores
    public IEnumerable<Leaderboard> Highscores { get; set; }
    // bara ett spel
    public Game Games { get; set; }

  
}

