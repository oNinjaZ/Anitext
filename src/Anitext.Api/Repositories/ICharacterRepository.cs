using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public interface ICharacterRepository
{
    Task<IEnumerable<Character>> GetAllAsync();
    Task<Character?> FindByIdAsync(int id);
    Task<Character?> FindByNameAsync(string name);
    Task<bool> CreateAsync(Character character);
    Task<bool> UpdateAsync(Character character);
    Task<bool> DeleteAsync(int id);
}
