using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public class AnimeRepository : IAnimeRepository
{
    public Task<bool> CreateAsync(Anime alias)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Anime>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Anime?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Anime alias)
    {
        throw new NotImplementedException();
    }
}
