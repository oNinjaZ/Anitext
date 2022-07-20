namespace Anitext.Api.Dtos.Character;

public class CharacterPostPutDto
{
    public string Name { get; set; } = default!;
    public int AnimeId { get; set; }
}
