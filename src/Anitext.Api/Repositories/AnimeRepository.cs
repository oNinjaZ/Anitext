using Anitext.Api.Data;
using Anitext.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Anitext.Api.Repositories;

public class AnimeRepository : IAnimeRepository
{
    private readonly DataContext _context;
    public AnimeRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateAsync(Anime anime)
    {
        _context.Anime.Add(anime);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<IEnumerable<Anime>> GetAllAsync()
        => await _context.Anime.ToListAsync();


    public async Task<Anime?> GetByIdAsync(int id)
        => await _context.Anime.FindAsync(id);

    public async Task<bool> DeleteAsync(int id)
    {
        if (await GetByIdAsync(id) is not Anime anime)
            return false;

        _context.Remove(anime);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateAsync(Anime alias)
    {
        if (await GetByIdAsync(alias.Id) is not Anime anime)
            return false;
        _context.Update(alias);
        return await _context.SaveChangesAsync() > 0;
    }
}
