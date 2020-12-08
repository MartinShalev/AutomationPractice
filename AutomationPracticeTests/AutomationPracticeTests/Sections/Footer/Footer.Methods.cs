using AutoFixture;
using AutomationPracticeTests.Pages;
using SeleniumTests.Core;
using System;

namespace AutomationPracticeTests.Sections
{
    public partial class Footer : BasePage
    {
        public Footer(WebDriver driver) 
            : base (driver)
        { 
        }

        public string URL { get { return "http://automationpractice.com/index.php"; } }

        public string CreateRandomEmail()
        {
            var fixture = new Fixture();
            var email = fixture.Create<String>();
            return $"{email}@gmail.com";
        }
    }
}
