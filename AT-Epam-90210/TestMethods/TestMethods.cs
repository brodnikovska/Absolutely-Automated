using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TestMethods;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            LoremIpsum loremIpsum = new LoremIpsum(driver);
            PageFactory.InitElements(driver, loremIpsum);
            loremIpsum.GetLoremIpsumString("140");
        }
        [TestMethod]
        public void TestMethod2()
        {
            /* submitOrTakeSS: true => submit, false => take screenhot, 
             * withoutNameOrEmail: true => without name, false => without email,  
             * string length */

            IWebDriver driver = new ChromeDriver();
            HaveYourSay haveYourSay = new HaveYourSay(driver);
            PageFactory.InitElements(driver, haveYourSay);
            haveYourSay.BBCThing(true, true, "140");
        }        
    }
}
