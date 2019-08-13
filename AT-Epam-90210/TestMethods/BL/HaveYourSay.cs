using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using Test;

namespace TestMethods
{
    class HaveYourSay
    {
        public IWebDriver driver;
        public HaveYourSay(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void BBCThing(bool submitOrTakeSS, bool withoutNameOrEmail, string length)
        {
            LoremIpsumPage loremIpsumPage = new LoremIpsumPage(driver);
            PageFactory.InitElements(driver, loremIpsumPage);
            HomePage homePage = new HomePage(driver);
            PageFactory.InitElements(driver, homePage);
            NewsPage newsPage = new NewsPage(driver);
            PageFactory.InitElements(driver, newsPage);
            HaveYourSayPage haveYourSayPage = new HaveYourSayPage(driver);
            PageFactory.InitElements(driver, haveYourSayPage);
            DoYouHaveAQuestionPage doYouHaveAQuestionPage = new DoYouHaveAQuestionPage(driver);
            PageFactory.InitElements(driver, doYouHaveAQuestionPage);
            GetInTouchForm getInTouchForm = new GetInTouchForm(driver);
            PageFactory.InitElements(driver, getInTouchForm);

            driver.Navigate().GoToUrl("https://www.lipsum.com");
            string sample = loremIpsumPage.GetLoremIpsumString(length);

            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.Manage().Window.Maximize();

            homePage.ClickOnNews();
            newsPage.ClickMore();
            newsPage.ClickHaveYourSay();
            haveYourSayPage.ClickDoYouHaveAQuestion();
            doYouHaveAQuestionPage.ToAskAQuestion(sample);
            doYouHaveAQuestionPage.SignUpForTheDaily();
            if (submitOrTakeSS == false && (withoutNameOrEmail == true || withoutNameOrEmail == false))
            {
                getInTouchForm.FillForm();
                doYouHaveAQuestionPage.GetScreenshot();
            }
            else if (submitOrTakeSS == true && withoutNameOrEmail == true)
            {
                getInTouchForm.FillFormWithoutName();
                doYouHaveAQuestionPage.pressSubmit();
                doYouHaveAQuestionPage.CheckNameErrorMessage();
            }
            else if (submitOrTakeSS == true && withoutNameOrEmail == false)
            {
                getInTouchForm.FillFormWithoutEmail();
                doYouHaveAQuestionPage.pressSubmit();
                doYouHaveAQuestionPage.CheckEmailErrorMessage();
            }
            else
                throw new ArgumentException();
        }
    }
}
