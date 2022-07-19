using Anitext.Api.Data;
using Anitext.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opts =>
    opts.UseNpgsql(builder.Configuration.GetValue<string>("Database:ConnectionString")))
    .AddSingleton<IQuoteRepository, QuoteRepository>()
    .AddSingleton<ICharacterRepository, CharacterRepository>()
    .AddSingleton<IAliasRepository, AliasRepository>()
    .AddSingleton<IAnimeRepository, AnimeRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
