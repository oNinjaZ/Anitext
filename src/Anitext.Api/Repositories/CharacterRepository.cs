using Anitext.Api.Data;
using Anitext.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Anitext.Api.Repositories;

public class CharacterRepository : ICharacterRepository
{
    private readonly DataContext _context;
    public CharacterRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateAsync(Character character)
    {
        if (await FindByNameAsync(character.Name) is not null)
            return false;

        _context.Character.Add(character);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<IEnumerable<Character>> GetAllAsync()
        => await _context.Character.ToListAsync();

    public async Task<Character?> FindByIdAsync(int id)
        => await _context.Character.FindAsync(id);

    public async Task<Character?> FindByNameAsync(string name)
        => await _context.Character.FirstOrDefaultAsync(c => c.Name == name);

    public async Task<bool> UpdateAsync(Character character)
    {
        if (await FindByIdAsync(character.Id) is null)
            return false;

        _context.Character.Update(character);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        if (await FindByIdAsync(id) is not Character character)
            return false;

        _context.Remove(character);
        return await _context.SaveChangesAsync() > 0;
    }
}
