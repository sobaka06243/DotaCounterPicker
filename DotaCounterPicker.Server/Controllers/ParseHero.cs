using DotaCounterPicker.Contracts.Entities;
using DotaCounterPicker.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DotaCounterPicker.Server.Controllers;

[ApiController]
public class ParseHero : ControllerBase
{
    [Produces("application/json")]
    [HttpGet(nameof(ParseHero), Name = nameof(ParseHero))]
    [SwaggerOperation(
        Description = "Parse hero with given heroName",
        OperationId = nameof(ParseHero),
        Tags = new[] { $"{nameof(ParseHero)}" })
        ]
    public async Task<IEnumerable<DotaHero>> HandleAsync(
        [FromQuery] string heroName,
        [FromServices] IHeroParser heroParser
        )
    {
        return await heroParser.GetCounterHeroes(heroName);
    }
}