using DotaCounterPicker.Services;
using DotaCounterPicker.Services.DTO;
using LinqToDB;
using Persistence.Database.DbContextFactory;

namespace DotaCounterPicker.Data.Services;
public class HeroesToLinesRepository : IHeroesToLinesRepository
{
    private readonly IDbContextFactory _dbContextFactory;

    public HeroesToLinesRepository(IDbContextFactory dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task ClearAsync()
    {
        await using var dbContext = _dbContextFactory.Create();

        await dbContext.HeroToLines.DeleteAsync();
    }

    public async Task CreateAsync(HeroToLine heroToLine)
    {
        await using var dbContext = _dbContextFactory.Create();

        var hero = await dbContext.Heroes.FirstOrDefaultAsync(x => x.Name == heroToLine.Name);

        var line = await dbContext.Lines.FirstOrDefaultAsync(x => x.Name == heroToLine.Line);

        if (hero is null || line is null)
        {
            throw new ArgumentException();
        }

        await dbContext.InsertAsync(new DotaCounterPicker.Data.DTO.HeroToLine() { HeroId = hero.Id, LineId = line.Id });
    }

    public async Task<IEnumerable<HeroToLine>> GetAsync()
    {
        await using var dbContext = _dbContextFactory.Create();

        var heroToLines = await dbContext.HeroToLines
            .LoadWith(x => x.Hero)
            .LoadWith(x => x.Line)
            .ToListAsync();

        return heroToLines.Select(x => new HeroToLine() { Name = x.Hero.Name, Line = x.Line.Name });
    }
}
