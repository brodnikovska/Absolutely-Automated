using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMethods
{
    class LoremIpsumPage
    {
        public IWebDriver driver;
        public LoremIpsumPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        [FindsBy(How = How.CssSelector, Using = "input[value='bytes']")]
        private IWebElement bytes;
        [FindsBy(How = How.XPath, Using = "//*[@id='amount']")]
        private IWebElement amount;
        [FindsBy(How = How.XPath, Using = "//*[@id='lipsum']/p")]
        private IWebElement generatedSample;

        public string GetLoremIpsumString(string length)
        {
            bytes.Click();
            amount.Clear();
            amount.SendKeys(length.ToString());
            amount.Submit();
            return generatedSample.Text;
        }
    }
}
