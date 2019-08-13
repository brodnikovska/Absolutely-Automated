using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TestMethods;

namespace Test
{
    class DoYouHaveAQuestionPage
    {
        public IWebDriver driver;
        public DoYouHaveAQuestionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = "//*[@class='embed-content-container']//div[5]/label/input")]
        private IWebElement signUp;
        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'long-text-input-container')]//textarea")]
        private IWebElement question;
        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        private IWebElement errorMessage;
        [FindsBy(How = How.XPath, Using = "//*[@class='button-container']//button")]
        private IWebElement submitButton;
        public GetInTouchForm FillForm()
        {
            return new GetInTouchForm(driver);
        }
        public void ToAskAQuestion(string text)
        {
            question.SendKeys(text);
        }

        public void GetScreenshot()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }
        public void SignUpForTheDaily()
        {
            signUp.Click();
        }
        public void CheckNameErrorMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => errorMessage.Displayed);
            Assert.AreEqual("Name can't be blank", errorMessage.Text);
        }
        public void CheckEmailErrorMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => errorMessage.Displayed);
            Assert.AreEqual("Email address can't be blank", errorMessage.Text);
        }
        public void pressSubmit()
        {
            submitButton.Click();
        }
    }
}
