using Anitext.Api.Models;

namespace Anitext.Api.Repositories;

public class CharacterRepository : ICharacterRepository
{
    public Task<bool> CreateAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Character>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Character?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(Character character)
    {
        throw new NotImplementedException();
    }
}
