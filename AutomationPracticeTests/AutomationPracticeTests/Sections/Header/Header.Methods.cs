using AutomationPracticeTests.Pages;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections.Header
{
    public partial class Header : BasePage
    {
        public Header(WebDriver driver) : base(driver)
        {
        }

        public string URL { get { return "http://automationpractice.com/index.php"; } }
    }
}
