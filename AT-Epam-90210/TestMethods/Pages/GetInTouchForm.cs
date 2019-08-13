using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestMethods
{
    class GetInTouchForm
    {
        public IWebDriver driver;
        public GetInTouchForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Dictionary<string, string> form = new Dictionary<string, string>
        {
            { "Name", "Iryna" },
            { "Email", "irynabrd@gmail.com"},
            { "Age", "32"},
            { "Postcode", "02121"}
        };
        public Dictionary<string, string> formWithoutName = new Dictionary<string, string>
        {
            { "Email", "irynabrd@gmail.com"},
            { "Age", "32"},
            { "Postcode", "02121"}
        };
        public Dictionary<string, string> formWithoutEmail = new Dictionary<string, string>
        {
            { "Name", "Iryna" },
            { "Age", "32"},
            { "Postcode", "02121"}
        };

        public void FillForm()
        {
            foreach (var kv in form)
            {
                IWebElement field = driver.FindElement(By.XPath($"//label/input[contains(@placeholder, '{kv.Key}')]"));
                field.SendKeys(kv.Value);
            }
        }
        public void FillFormWithoutName()
        {
            foreach (var kv in formWithoutName)
            {
                IWebElement field = driver.FindElement(By.XPath($"//label/input[contains(@placeholder, '{kv.Key}')]"));
                field.SendKeys(kv.Value);
            }
        }
        public void FillFormWithoutEmail()
        {
            foreach (var kv in formWithoutEmail)
            {
                IWebElement field = driver.FindElement(By.XPath($"//label/input[contains(@placeholder, '{kv.Key}')]"));
                field.SendKeys(kv.Value);                
            }
        }
    }
}
