using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Demo3Frame
    {
        [Test]

        public void HdfcFrameTest()

        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            
            driver.Url = "https://demo.openemr.io/b/openemr/interface/login/login.php?site=default";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page")));
            driver.FindElement(By.Id("authUser")).SendKeys("Sanjay");
            driver.FindElement(By.Id("clearPass")).SendKeys("Password@123");


            driver.SwitchTo().DefaultContent();
            //enter userid as john123

        }



    }
}
