using AutomationPracticeTests.Pages;
using OpenQA.Selenium;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections
{
    public class Footer : BasePage
    {
        public Footer(WebDriver driver) 
            : base (driver)
        { 
        }

        public string URL { get { return "http://automationpractice.com/index.php"; } }

        public WebElement FooterLinks(string lincText)
        {
            return Driver.FindElement(By.XPath($"//div[@class='footer-container']//a[normalize-space(.) = '{lincText}']"));

        }

        public WebElement ReturnToHomePageBut => Driver.FindExistingElement(By.XPath("//span[@class='navigation_page']"));
    }
}
