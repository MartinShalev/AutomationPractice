using OpenQA.Selenium.Interactions;
using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Pages
{
    class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Builder = new Actions(Driver.WrappedDriver);

        }

        public WebDriver Driver { get; }
        protected Actions Builder { get; set; }
    }
}
