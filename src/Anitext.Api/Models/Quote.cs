namespace Anitext.Api.Models;
public class Quote
{
    public int Id { get; set; }
    public string Text { get; set; } = default!;
    public int AnimeId { get; set; }
    public int CharacterId { get; set; }

    public Anime Anime { get; set; } = default!;
    public Character Character { get; set; } = default!;
}
