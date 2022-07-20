using Anitext.Api.Dtos.Character;
using Anitext.Api.Mappers;
using Anitext.Api.Models;
using Anitext.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Anitext.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly ICharacterRepository _charRepo;
    private readonly IAnimeRepository _animeRepo;
    public CharactersController(ICharacterRepository charRepo, IAnimeRepository animeRepo)
    {
        _charRepo = charRepo;
        _animeRepo = animeRepo;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CharacterPostPutDto dto)
    {
        // todo validation 
        
        if (await _animeRepo.FindByIdAsync(dto.AnimeId) is null)
            return BadRequest($"Anime with the ID of {dto.AnimeId} does not exist.");

        var created = await _charRepo.CreateAsync(new Character
        {
            Name = dto.Name,
            AnimeId = dto.AnimeId
        });

        if (!created)
            return BadRequest();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var character = await _charRepo.GetAllAsync();
        return Ok(character.Select(a => a.AsDto()));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        if (await _charRepo.FindByIdAsync(id) is not Character character)
            return NotFound();
        return Ok(character.AsDto());
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Character character)
    {
        character.Id = id;
        var updated = await _charRepo.UpdateAsync(character);

        if (!updated)
            return NotFound();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteById(int id)
    {
        return await _charRepo.DeleteAsync(id)
            ? Ok()
            : NotFound();
    }

}
