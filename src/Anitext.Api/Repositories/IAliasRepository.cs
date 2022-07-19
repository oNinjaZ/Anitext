using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface IAliasRepository
{
    Task<IEnumerable<Alias>> GetAllAsync();
    Task<Alias?> GetByIdAsync(int id);
    Task<bool> CreateAsync(Alias alias);
    Task<bool> Update(Alias alias);
    Task<bool> Delete(int id);
}
