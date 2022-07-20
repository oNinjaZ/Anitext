using Anitext.Api.Data;
using Anitext.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opts =>
    opts.UseNpgsql(builder.Configuration.GetValue<string>("Database:ConnectionString")))
    .AddScoped<IQuoteRepository, QuoteRepository>()
    .AddScoped<ICharacterRepository, CharacterRepository>()
    .AddScoped<IAliasRepository, AliasRepository>()
    .AddScoped<IAnimeRepository, AnimeRepository>();

var app = builder.Build();

app.MapControllers();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
