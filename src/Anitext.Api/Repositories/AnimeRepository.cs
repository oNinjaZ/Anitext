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
        if (await FindByTitleAsync(anime.Title) is not null)
            return false;

        _context.Anime.Add(anime);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<IEnumerable<Anime>> GetAllAsync()
        => await _context.Anime.ToListAsync();

    public async Task<Anime?> FindByIdAsync(int id)
        => await _context.Anime.FindAsync(id);

    public async Task<Anime?> FindByTitleAsync(string title)
        => await _context.Anime.FirstOrDefaultAsync(a => a.Title == title);

    public async Task<bool> UpdateAsync(Anime anime)
    {
        if (await FindByIdAsync(anime.Id) is null)
            return false;

        _context.Anime.Update(anime);
        return await _context.SaveChangesAsync() > 0;
    }
    
    public async Task<bool> DeleteAsync(int id)
    {
        if (await FindByIdAsync(id) is not Anime anime)
            return false;

        _context.Remove(anime);
        return await _context.SaveChangesAsync() > 0;
    }
}
