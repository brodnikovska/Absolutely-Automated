using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Test;

namespace TestMethods
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private ChromeDriver driver;
        LoremIpsum loremIpsum;
        HaveYourSay haveYourSay;
        LoremIpsumPage loremIpsumPage;
        HomePage homePage;
        NewsPage newsPage;
        HaveYourSayPage haveYourSayPage;
        DoYouHaveAQuestionPage doYouHaveAQuestionPage;
        GetInTouchForm getInTouchForm;
        private string sample;

        [BeforeScenario()]
        public void Setup1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            haveYourSay = new HaveYourSay(driver);
            loremIpsum = new LoremIpsum(driver);
            loremIpsumPage = new LoremIpsumPage(driver);
            homePage = new HomePage(driver);
            newsPage = new NewsPage(driver);
            haveYourSayPage = new HaveYourSayPage(driver);
            doYouHaveAQuestionPage = new DoYouHaveAQuestionPage(driver);
            getInTouchForm = new GetInTouchForm(driver);
        }

        [Given(@"I go to https://www\.lipsum\.com page")]
        public void GivenIGoToHttpsWww_Lipsum_ComPage()
        {
            driver.Navigate().GoToUrl("https://www.lipsum.com");
        }
        
        [Given(@"I get the sample of Lorem Ipsum text of the length (.*) bytes")]
        public void GivenIGetTheSampleOfLoremIpsumTextOfTheLengthBytes(string p0)
        {
            this.sample = loremIpsumPage.GetLoremIpsumString(p0);
        }
        
        [Given(@"I go to https://www\.bbc\.com page")]
        public void GivenIGoToHttpsWww_Bbc_ComPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
        }
        
        [When(@"I navigate to Do You Have a Question Page")]
        public void WhenINavigateToDoYouHaveAQuestionPage()
        {
            homePage.ClickOnNews();
            newsPage.ClickMore();
            newsPage.ClickHaveYourSay();
            haveYourSayPage.ClickDoYouHaveAQuestion();
        }
        
        [When(@"I put my Lorem Ipsum text in a question field")]
        public void WhenIPutMyLoremIpsumTextInAQuestionField()
        {
            doYouHaveAQuestionPage.ToAskAQuestion(sample);
        }
        
        [When(@"I sign up for BBC News Daily")]
        public void WhenISignUpForBBCNewsDaily()
        {
            doYouHaveAQuestionPage.SignUpForTheDaily();
        }
        
        [When(@"I provide all required fields with my personal information")]
        public void WhenIProvideAllRequiredFieldsWithMyPersonalInformation()
        {
            getInTouchForm.FillForm();
        }
        
        [When(@"I provide required fields with my personal information except of my Name")]
        public void WhenIProvideRequiredFieldsWithMyPersonalInformationExceptOfMyName()
        {
            getInTouchForm.FillFormWithoutName();
        }
        
        [When(@"I try to submit")]
        public void WhenITryToSubmit()
        {
            doYouHaveAQuestionPage.pressSubmit();
        }
        
        [When(@"I provide required fields with my personal information except of my email")]
        public void WhenIProvideRequiredFieldsWithMyPersonalInformationExceptOfMyEmail()
        {
            getInTouchForm.FillFormWithoutEmail();
        }
        
        [Then(@"I get the screenshot")]
        public void ThenIGetTheScreenshot()
        {
            doYouHaveAQuestionPage.GetScreenshot();
        }
        
        [Then(@"I get a name error message")]
        public void ThenIGetANameErrorMessage()
        {
            doYouHaveAQuestionPage.CheckNameErrorMessage();
        }

        [Then(@"I get an email error message")]
        public void ThenIGetAnEmailErrorMessage()
        {
            doYouHaveAQuestionPage.CheckEmailErrorMessage();
        }
    }
}
