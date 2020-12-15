

using SeleniumTests.Core;

namespace AutomationPracticeTests.Pages.ContactUs
{
    public class ContactUsPage : BasePage
    {
        public ContactUsPage(WebDriver driver) : base(driver)
        {
        }

        public string URL {get { return "http://automationpractice.com/index.php?controller=contact"; } }
    }
}
