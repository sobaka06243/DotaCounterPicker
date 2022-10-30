using DotaCounterPicker.Services;

namespace DotaCounterPicker.Server.Services;

public class HeroLoader : IHeroLoader
{
    private readonly HttpClient _client;

    public HeroLoader(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> LoadHero(string heroName)
    {
        var url = $"https://www.dotabuff.com/heroes/{heroName}/counters";
        HttpClient httpClient = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
        var res = await httpClient.SendAsync(request);
        return await res.Content.ReadAsStringAsync();
    }
}
