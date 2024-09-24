using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo3SalesForce
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("Sanjay");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Chellikattil");
            driver.FindElement(By.Name("UserEmail")).SendKeys("Sanjay.Chellikattil@thomsonreuters.com");
            driver.FindElement(By.Name("CompanyName")).SendKeys("TR");
            driver.FindElement(By.Name("UserTitle")).SendKeys("Sales Manager");
            //driver.FindElement(By.Id("UserName")).SendKeys("Sanjay");
            //driver.FindElement(By.Id("Password")).SendKeys("Abcd@12345");

            // check box
            driver.FindElement(By.XPath("(//div[@class=' Ccheckbox-ui'])[2]")).Click();

            // get header and print
            string actualHeader= driver.FindElement(By.TagName("H1"))


            //2.Enter first name as “John”
            //3.Enter last name as “wick”
            //4.Enter work email as “john @gmail.com”
            //5.Select Job title as “IT Manager”
            //6.Select Employees as “101 - 500 employees”
            //7.Select country as “United Kingdom”
            //8.Do not fill the phone number
            //9.Click on check box
            //10.Click on start my free trial
            //11.Get the error message displayed “Enter a valid phone number”
        }
    }
}
