using DotaCounterPicker.Services;
using OpenQA.Selenium.Chrome;

namespace DotaCounterPicker.Selenium
{
	public class SeleniumParser : IHTMLLoader
	{
		public string GetHtml(string url)
		{
			var options = new ChromeOptions();

			using (var driver = new ChromeDriver(options))
			{
				driver.Navigate().GoToUrl(url);
				return driver.PageSource;
			}
		}
	}
}
