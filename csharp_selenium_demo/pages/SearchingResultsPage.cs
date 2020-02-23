using OpenQA.Selenium;
using System.Collections.Generic;

namespace csharp_selenium_demo
{
    class SearchingResultsPage : Base
    {
        IWebDriver driver;
        public SearchingResultsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        internal IWebElement searchingPhraseLabel => get_element(By.XPath("//h1/span[.='toster']"));

        internal IReadOnlyCollection<IWebElement> articles => get_elements(By.XPath("//article//h2/a"));

    }
}
