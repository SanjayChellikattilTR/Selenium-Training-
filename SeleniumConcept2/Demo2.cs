using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo2
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        
            driver.Url = "https://www.facebook.com/r.php?next=https%3A%2F%2Fwww.facebook.com%2F&locale=en_GB&display=page";

            //driver.FindElement(By.Id("DomainName")).SendKeys("Automation-01");
            //driver.FindElement(By.Id("UserName")).SendKeys("Sanjay");
            //driver.FindElement(By.Id("Password")).SendKeys("Abcd@12345");

            //click on login
            // driver.FindElement(By.Name("btnLogin")).Click();
            //driver.FindElement(By.LinkText("btnLogin")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("Jun");

            driver.FindElement(By.XPath("//input {@values=' -1'")).Click();

        }
    }
}
