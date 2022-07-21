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
        => await _context.Character
            .AsNoTracking()
            .Include(c => c.Anime)
            .ToListAsync();

    public async Task<Character?> FindByIdAsync(int id)
        => await _context.Character
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);


    public async Task<Character?> FindByNameAsync(string name)
        => await _context.Character
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name.ToUpper() == name.ToUpper());

    public async Task<bool> UpdateAsync(Character character)
    {
        _context.Update(character);
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
