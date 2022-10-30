using HtmlAgilityPack;

namespace DotaCounterPicker.Core;

public class HeroParser
{
    public IEnumerable<DotaHero> ParseHero(string html)
    {
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);
        var nodes = doc.DocumentNode.SelectNodes("//section/article/table/tbody/tr").Where(n => n.Attributes.Contains("data-link-to")).Select(n => n.ChildNodes);
        List<DotaHero> heroes = new List<DotaHero>();
        foreach (var node in nodes)
        {
            var name = node[1].InnerText;
            var disadvantage = double.Parse(node[2].InnerText.Replace("%", null).Replace(".", ","));
            heroes.Add(new DotaHero(name, disadvantage));
        }
        return heroes;
    }
}
