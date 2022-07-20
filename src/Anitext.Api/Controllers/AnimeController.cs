using Anitext.Api.Mappers;
using Anitext.Api.Models;
using Anitext.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Anitext.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class AnimeController : ControllerBase
{
    private readonly IAnimeRepository _animeRepo;
    public AnimeController(IAnimeRepository animeRepo)
    {
        _animeRepo = animeRepo;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Anime anime)
    {
        var created = await _animeRepo.CreateAsync(anime);

        if (!created)
            return BadRequest();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var anime = await _animeRepo.GetAllAsync();
        return Ok(anime.Select(a => a.AsDto()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (await _animeRepo.FindByIdAsync(id) is not Anime anime)
            return NotFound();
        return Ok(anime.AsDto());
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Anime anime)
    {
        anime.Id = id;
        var updated = await _animeRepo.UpdateAsync(anime);

        if (!updated)
            return NotFound();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteById(int id)
    {
        return await _animeRepo.DeleteAsync(id)
            ? Ok()
            : NotFound();
    }
}
