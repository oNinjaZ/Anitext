namespace Anitext.Api.Dtos.Anime;

public record AnimeReadDto(int Id, string Title, IEnumerable<AnimeCharacterDto> Characters);
