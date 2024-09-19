using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo1
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://qa.sureprep.com/";

            driver.FindElement(By.Id("DomainName")).SendKeys("Automation-01");
            driver.FindElement(By.Id("UserName")).SendKeys("Sanjay");
            driver.FindElement(By.Id("Password")).SendKeys("Abcd@12345");

            //click on login
            driver.FindElement(By.Name("btnLogin")).Click();

        }
    }
}
