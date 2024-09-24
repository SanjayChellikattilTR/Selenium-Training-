using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThonsomReuters.SeleniumConceptUnitTestProject
{
    public class Demo1SeleniumAdvance
    {
        //[Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.db4free.net";
            driver.FindElement(By.LinkText("phpMyAdmin")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("Input_usernamer")).SendKeys("admin");
            driver.Close();

            

        }

       // [Test]

        public void Demo2TabsTest()

        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";
           // driver.FindElement(By.XPath("//input {@values=' -1'")).Click()
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();

            driver.FindElement(By.Id("topMnubanking")).Click();
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.LinkText("Branch/ATM")).Click();

            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
           



            //close all popup

            //click on Banking

            //click on Citi Commercial Bank

            //click on Branch/ATM

            //Select Citibank ATM as Bengaluru 

        }

        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            string actualAlertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();

            //to inspect--> f12 or ctrl+shift+c

            //click on Go
        }
    }
}
