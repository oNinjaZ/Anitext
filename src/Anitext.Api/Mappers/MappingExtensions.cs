using Anitext.Api.Dtos;
using Anitext.Api.Dtos.Anime;
using Anitext.Api.Dtos.Character;
using Anitext.Api.Models;

namespace Anitext.Api.Mappers;

public static class MappingExtensions
{
    public static AnimeReadDto AsDto(this Anime anime)
    {
        return new(
            anime.Id,
            anime.Title,
            anime.Characters.Select(
                c => new AnimeCharacterDto(
                    c.Name,
                    c.Quotes.Select(q => q.Text).ToList())));
    }

    public static CharacterReadDto AsDto(this Character character) => new(character.Id, character.Name, character.Anime.Title);

}
