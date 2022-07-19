using Anitext.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Anitext.Api.Data;


public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public virtual DbSet<Anime> Anime => Set<Anime>();
    public virtual DbSet<Character> Character => Set<Character>();
    public virtual DbSet<Quote> Quote => Set<Quote>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alias>()
            .HasOne(a => a.Character)
            .WithMany(c => c.Aliases)
            .HasForeignKey(a => a.CharacterId);
        
        modelBuilder.Entity<Character>()
            .HasOne(c => c.Anime)
            .WithMany(a => a.Characters)
            .HasForeignKey(c => c.AnimeId);

        modelBuilder.Entity<Quote>()
            .HasOne(q => q.Anime)
            .WithMany(a => a.Quotes)
            .HasForeignKey(q => q.AnimeId);
        
        modelBuilder.Entity<Quote>()
            .HasOne(q => q.Character)
            .WithMany(c => c.Quotes)
            .HasForeignKey(q => q.CharacterId);
    }
}
