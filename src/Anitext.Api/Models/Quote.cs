namespace Anitext.Api.Models;
public class Quote
{
    public int Id { get; set; }
    public string Text { get; set; } = default!;
    public int CharacterId { get; set; }
                            
    public Character Character { get; set; } = default!;
}
