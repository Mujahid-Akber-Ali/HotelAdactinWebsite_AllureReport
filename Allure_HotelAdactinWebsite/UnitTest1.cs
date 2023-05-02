
using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Allure_Report
{

    [AllureNUnit]
    [TestFixture]
    public class Tests : Allure
    {
        [OneTimeSetUp]
        public void inti()
        {
            driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }

        [Test]
        [AllureStep]
        public void AllureReport()
        {
            driver.Url = "https://adactinhotelapp.com/";
            TakeScreenshot("Open Url");

            //driver.FindElement(By.Id("username")).SendKeys("AmirImam");
            //TakeScreenshot("Enter Username");
            Write(By.Id("username"), "mujahidakberali", "Enter Username");

            //driver.FindElement(By.Id("password")).SendKeys("AmirImam");
            //TakeScreenshot("Enter password");
            Write(By.Id("password"), "mujahid123", "Enter password");

            //driver.FindElement(By.Id("login")).Click();
            //TakeScreenshot("login Pressed");
            CLick(By.Id("login"), "login Pressed");

            //driver.FindElement(By.Id("location")).SendKeys("Sydney");
            //TakeScreenshot("Enter Location");
            Write(By.Id("location"), "Sydney", "Enter Location");

            //driver.FindElement(By.Id("Submit")).Click();
            //TakeScreenshot("Submit Click");
            CLick(By.Id("Submit"), "Submit Pressed");

        }


    }
}
