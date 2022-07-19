using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface IAnimeRepository
{
    Task<IEnumerable<Anime>> GetAllAsync();
    Task<Anime?> GetByIdAsync(int id);
    Task<bool> CreateAsync(Anime anime);
    Task<bool> UpdateAsync(Anime anime);
    Task<bool> DeleteAsync(int id);
}
