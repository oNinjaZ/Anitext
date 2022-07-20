using Anitext.Api.Dtos;
using Anitext.Api.Models;

namespace Anitext.Api.Mappers;

public static class MappingExtensions
{
    public static AnimeDto AsDto(this Anime anime) => new (anime.Id, anime.Title);
    public static CharacterDto AsDto(this Character character) => new (character.Id, character.Name);
}
