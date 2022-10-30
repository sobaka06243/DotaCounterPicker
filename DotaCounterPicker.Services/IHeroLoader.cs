namespace DotaCounterPicker.Services;

public interface IHeroLoader
{
    Task<string> LoadHero(string heroName);
}
