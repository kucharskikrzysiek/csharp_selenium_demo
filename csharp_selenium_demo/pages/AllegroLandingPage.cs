using OpenQA.Selenium;

namespace csharp_selenium_demo
{
    class AllegroLandingPage : Base
    {
        IWebDriver driver;

        public AllegroLandingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        internal IWebElement Logo => get_element(By.CssSelector("img[itemprop = logo]"));

        internal IWebElement acceptTerms => get_element(By.CssSelector("button[data-role=close-and-accept-consent]"));

        internal IWebElement searchBox => get_element(By.CssSelector("input[data-role=search-input]"));

        internal IWebElement buttonSearch => get_element(By.CssSelector("button[data-role=search-button]"));

        internal void Open()
        {
            driver.Url = new UrlAddresses().AllegroMainUrl;
        }

    }
}
