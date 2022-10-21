using DotaCounterPicker.Contracts.Entities;

namespace DotaCounterPicker.Services;

public interface IHeroParser
{
    /// <summary>
    /// Get counter heroes at given <paramref name="heroName"/>
    /// </summary>
    /// <param name="heroName"></param>
    /// <returns></returns>
    Task<IEnumerable<DotaHero>> GetCounterHeroes(string heroName);
}
