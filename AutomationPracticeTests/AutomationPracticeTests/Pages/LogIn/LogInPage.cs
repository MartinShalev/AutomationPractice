using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Pages.LogIn
{
    class LogInPage : BasePage
    {
        public LogInPage(WebDriver driver) 
            : base(driver)
        {
        }

        public string URL { get { return ""; } }
    }
}
