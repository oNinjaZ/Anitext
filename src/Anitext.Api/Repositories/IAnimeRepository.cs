using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface IAnimeRepository
{
    Task<IEnumerable<Anime>> GetAllAsync();
    Task<Anime?> FindByIdAsync(int id);
    Task<Anime?> FindByIdIncludeCharacterQuotesAsync(int id);
    Task<Anime?> FindByTitleAsync(string title);
    Task<bool> CreateAsync(Anime anime);
    Task<bool> UpdateAsync(Anime anime);
    Task<bool> DeleteAsync(int id);
}
