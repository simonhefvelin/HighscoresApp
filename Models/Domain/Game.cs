using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HighscoresApp.Models.Domain;

[Index(nameof(UrlSlug), IsUnique = true)]
public class Game
{
    
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(250)]
    public string Description { get; set; }

    [MaxLength(100)]
    public string Genre { get; set; }

    [MaxLength(4)]
    public int LaunchYear { get; set; }

    public Uri ImageUrl { get; set; }

    [MaxLength(50)]
    public string UrlSlug { get; set; }

    public List<Leaderboard> Leaderboards { get; set; } = new List<Leaderboard>();
}
