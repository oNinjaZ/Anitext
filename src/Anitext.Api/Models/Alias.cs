namespace Anitext.Api.Models;

public class Alias
{
    public int Id { get; set; }
    public string AliasName { get; set; } = default!;
    public int CharacterId { get; set; }

    public Character Character { get; set; } = default!;
}
