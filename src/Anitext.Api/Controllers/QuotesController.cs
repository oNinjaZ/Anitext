using Anitext.Api.Data;
using Anitext.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Anitext.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class QuotesController : ControllerBase
{
    private readonly IQuoteRepository _quoteRepo;
    public QuotesController(IQuoteRepository quoteRepo)
    {
        _quoteRepo = quoteRepo;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
