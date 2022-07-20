namespace Anitext.Api.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int AnimeId { get; set; }
                    
    public Anime Anime { get; set; } = default!;
    public List<Alias>? Aliases { get; set; }
    public List<Quote>? Quotes { get; set; }

}
