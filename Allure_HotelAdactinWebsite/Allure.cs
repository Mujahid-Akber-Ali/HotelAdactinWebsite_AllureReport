using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_Report
{
    public class Allure
    {

        public static IWebDriver driver;

        public void Write(By by, string text, string detail)
        {
            driver.FindElement(by).SendKeys(text);
            TakeScreenshot(detail);
        }

        public void CLick(By by, string detail)
        {
            driver.FindElement(by).Click();
            TakeScreenshot(detail);
        }
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"C:\Users\aadil\Downloads\AllureReport_HotelAdactinWebsite-master\Allure_HotelAdactinWebsite\TestExecutionReport" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            AllureLifecycle.Instance.AddAttachment(stepDetail, "image/png", path);
        }
    }
}
