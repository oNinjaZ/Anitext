using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface ICharacterRepository
{
    Task<IEnumerable<Character>> GetAllAsync();
    Task<Character?> GetByIdAsync(int id);
    Task<bool> CreateAsync(Character character);
    Task<bool> Update(Character character);
    Task<bool> Delete(int id);
}
