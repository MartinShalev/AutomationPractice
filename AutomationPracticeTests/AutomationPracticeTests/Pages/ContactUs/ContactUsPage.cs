using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

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
