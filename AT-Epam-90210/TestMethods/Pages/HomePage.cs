using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMethods
{
    class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsByAttribute(How = How.XPath, Using = "//*[@id='orb-nav-links']//a[text()='News']")]
        private IWebElement LnkNews { get; set; }
        public void ClickOnNews()
        {
            LnkNews.Click();
        }
    }
}
