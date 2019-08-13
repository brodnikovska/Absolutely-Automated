using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMethods
{
    class NewsPage
    {
        public IWebDriver driver;
        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//button/span[contains(text(),'More')]")]
        private IWebElement more;

        [FindsByAttribute(How = How.XPath, Using = "//span[contains(text(),'Have Your Say')]")]
        private IWebElement haveYourSay;
        public void ClickMore()
        {
            more.Click();
        }
        public void ClickHaveYourSay()
        {
            haveYourSay.Click();
        }
    }
}
