using OpenQA.Selenium.Interactions;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Pages
{
    public class BasePage
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
