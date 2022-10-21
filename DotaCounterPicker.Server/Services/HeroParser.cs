using DotaCounterPicker.Contracts.Entities;
using DotaCounterPicker.Services;
using HtmlAgilityPack;

namespace DotaCounterPicker.Server.Services;

public class HeroParser : IHeroParser
{
    public async Task<IEnumerable<DotaHero>> GetCounterHeroes(string heroName)
    {
        var url = $"https://www.dotabuff.com/heroes/{heroName}/counters";
        HttpClient httpClient = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
        var res = await httpClient.SendAsync(request);
        Stream stream = await res.Content.ReadAsStreamAsync();
        HtmlDocument doc = new HtmlDocument();
        doc.Load(stream);
        var nodes = doc.DocumentNode.SelectNodes("//section/article/table/tbody/tr").Where(n => n.Attributes.Contains("data-link-to")).Select(n => n.ChildNodes);
        List<DotaHero> heroes = new List<DotaHero>();
        foreach (var node in nodes)
        {
            var name = node[1].InnerText;
            var disadvantage = double.Parse(node[2].InnerText.Replace("%", null).Replace(".", ","));
            heroes.Add(new DotaHero() { Name = name, Disadvantage = disadvantage });
        }
        return heroes;
    }
}
