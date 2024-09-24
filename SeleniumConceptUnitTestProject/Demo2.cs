using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Demo2
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[contains(@src,'go.gif')]")).Click();

            string actualAlertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            //to inspect--> f12 or ctrl+shift+c

            //click on Go
        }
    }
}
