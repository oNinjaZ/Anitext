namespace Anitext.Api.Models;
public class Anime
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;

    public List<Character> Characters { get; set; } = new();
    public List<Quote> Quotes { get; set; } = new();
}
