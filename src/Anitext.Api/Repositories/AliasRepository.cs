using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public class AliasRepository : IAliasRepository
{
    public Task<bool> CreateAsync(Alias alias)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Alias>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Alias?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Alias alias)
    {
        throw new NotImplementedException();
    }
}
