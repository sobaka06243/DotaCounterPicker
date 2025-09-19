using DotaCounterPicker.Selenium;
using DotaCounterPicker.Services;

namespace DotaCounterPicker.Server.Services;

public class HeroLoader : IHeroLoader
{
    private readonly IHTMLLoader _htmlLoader;

	public HeroLoader(IHTMLLoader htmlLoader)
    {
		_htmlLoader = htmlLoader;

	}

    public async Task<string> LoadHero(string heroName)
    {
        var seleniumParser = new SeleniumParser();
        return seleniumParser.GetHtml($"https://www.dotabuff.com/heroes/{heroName}/counters?date=week");
    }
}
