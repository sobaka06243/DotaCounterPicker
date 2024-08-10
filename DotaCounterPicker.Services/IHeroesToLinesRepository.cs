using DotaCounterPicker.Services.DTO;

namespace DotaCounterPicker.Services;

public interface IHeroesToLinesRepository
{
    public Task<IEnumerable<HeroToLine>> GetAsync();

    public Task CreateAsync(HeroToLine heroToLine);

    public Task ClearAsync();
}
