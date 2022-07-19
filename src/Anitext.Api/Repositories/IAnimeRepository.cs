using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface IAnimeRepository
{
    Task<IEnumerable<Anime>> GetAllAsync();
    Task<Anime?> GetByIdAsync(int id);
    Task<bool> CreateAsync(Anime alias);
    Task<bool> Update(Anime alias);
    Task<bool> Delete(int id);
}
