using AutomationPracticeTests.Pages;
using OpenQA.Selenium;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections
{
    public partial class Footer : BasePage
    {
        public Footer(WebDriver driver) 
            : base (driver)
        { 
        }

        public string URL { get { return "http://automationpractice.com/index.php"; } }

    }
}
