using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace csharp_selenium_demo
{
    class Base
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public Base(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public IWebElement get_element(By selector)
        {
            wait_for_page();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
            return driver.FindElement(selector);
        }

        public IReadOnlyCollection<IWebElement> get_elements(By selector)
        {
            wait_for_page();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
            return driver.FindElements(selector);
        }

        public void wait_for_page()
        {
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}
