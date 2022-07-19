using Anitext.Api.Dtos.Anime;
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
    public async Task<IActionResult> Post([FromBody] AnimeDto dto)
    {
        await _animeRepo.CreateAsync(new Anime
        {
            Title = dto.Title
        });

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var anime = await _animeRepo.GetAllAsync();
        return Ok(anime);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (await _animeRepo.GetByIdAsync(id) is not Anime anime)
            return NotFound();
        return Ok(anime);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] AnimeDto dto)
    {
        var updated = await _animeRepo.UpdateAsync(new Anime
        {
            Id = id,
            Title = dto.Title
        });

        if (!updated)
            return BadRequest();
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
