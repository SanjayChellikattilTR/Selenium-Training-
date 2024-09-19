using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;

namespace SeleniumConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver obj = new ChromeDriver();
            IWebDriver obj1 = new ChromeDriver();
            obj.Url = "https://qa.sureprep.com/";
            string actualTitle = obj.Title;
            Console.WriteLine(actualTitle);

            Console.WriteLine(obj.Title);
            Console.WriteLine(obj.Url);

            obj.Quit();




        }
    }
}
