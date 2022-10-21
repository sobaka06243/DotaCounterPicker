using DotaCounterPicker.Contracts.Entities;
using DotaCounterPicker.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotaCounterPicker.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ParseHero : ControllerBase
{
    [HttpGet(Name = "ParseHero")]
    public async Task<IEnumerable<DotaHero>> HandleAsync(
         [FromQuery] string heroName,
        [FromServices] IHeroParser heroParser
        )
    {
        return await heroParser.GetCounterHeroes(heroName);
    }
}