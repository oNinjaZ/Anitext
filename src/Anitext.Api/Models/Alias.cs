namespace Anitext.Api.Models;

public class Alias
{
    public int Id { get; set; }
    public int CharacterId { get; set; }

    public Character Character { get; set; } = default!;
}
