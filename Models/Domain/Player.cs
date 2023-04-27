
namespace HighscoresApp.Models.Domain;

public class Player
{
    public int Id { get; set; } 
    public string Name { get; set; }

    public DateTime Date { get; set; }

    public int Score { get; set; }

    public Game Game { get; set; }
}
