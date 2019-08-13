using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMethods
{
    class LoremIpsum
    {
        public IWebDriver driver;
        public LoremIpsum(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetLoremIpsumString(string length)
        {
            LoremIpsumPage loremIpsumPage = new LoremIpsumPage(driver);
            PageFactory.InitElements(driver, loremIpsumPage);
            driver.Navigate().GoToUrl("https://www.lipsum.com");
            return loremIpsumPage.GetLoremIpsumString(length);
        }
    }
}
