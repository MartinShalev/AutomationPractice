using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTests.Core;
using System;
using System.IO;
using System.Threading;

namespace AutomationPracticeTests
{
    public class BaseTest
    {
        public WebDriver Driver { get;  set; }
        public Actions Builder { get;  set; }

        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
            Builder = new Actions(Driver.WrappedDriver);
            Driver.WrappedDriver.Manage().Window.Maximize();
        }

        public void TakeScreenshot(string relativePath)
        {
            string dirPath = Path.GetFullPath(relativePath, Directory.GetCurrentDirectory());
            Thread.Sleep(500);
            var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
            string testName = TestContext.CurrentContext.Test.Name.Replace("\"", "");
            screenshot.SaveAsFile($"{dirPath}\\Screenshot\\{testName}_{DateTime.Now:ddMMyy-HH_mm}.png", ScreenshotImageFormat.Png);
        }
    }
}