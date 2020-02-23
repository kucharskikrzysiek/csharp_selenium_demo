using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace csharp_selenium_demo
{
    public class application
    {
        private IWebDriver driver;
        private AllegroLandingPage allegroLangingPage;
        private SearchingResultsPage searchingResultsPage;

        public application()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            allegroLangingPage = new AllegroLandingPage(driver);
            searchingResultsPage = new SearchingResultsPage(driver);
        }

        public void Quit()
        {
            driver.Quit();
        }

        internal void searchTosters()
        {
            allegroLangingPage.Open();
            Assert.IsTrue(allegroLangingPage.Logo.Displayed);
            try
            {
                allegroLangingPage.acceptTerms.Click();
            }
            catch { }
            allegroLangingPage.searchBox.SendKeys("toster");
            allegroLangingPage.buttonSearch.Click();
            Assert.IsTrue(searchingResultsPage.searchingPhraseLabel.Text.ToLower().Contains("toster"));
            var articles = searchingResultsPage.articles;
            foreach (IWebElement article in articles)
            {
                string article_title = article.Text.ToLower();
                Assert.IsTrue(article_title.Contains("toster"),
                    $"Article '{article_title.ToLower()}' does not contain word 'toster'");
            }
        }
    }
}