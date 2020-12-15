using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Pages.LogIn
{
    class SingInPage : BasePage
    {
        public SingInPage(WebDriver driver) 
            : base(driver)
        {
        }

        public string URL { get { return "http://automationpractice.com/index.php?controller=authentication&back=my-account"; } }
    }


}
