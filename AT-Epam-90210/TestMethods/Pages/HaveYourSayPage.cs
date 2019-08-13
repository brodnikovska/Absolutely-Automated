using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMethods
{
    class HaveYourSayPage
    {
        public IWebDriver driver;
        public HaveYourSayPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        [FindsBy(How = How.LinkText, Using = "Do you have a question for BBC News?")]
        private IWebElement doYouHaveAQuestion;
        public void ClickDoYouHaveAQuestion()
        {
            doYouHaveAQuestion.Click();
        }
    }
}
