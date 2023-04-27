using System.ComponentModel.DataAnnotations.Schema;

namespace HighscoresApp.Models.Domain;

public class Leaderboard
{
    public int Id { get; set; }

    public string Name { get; set; }


    public DateTime Date { get; set; }

    public int Score { get; set; }
    
    public int GameId { get; set; }


    public Game? Game { get; set; }
}
