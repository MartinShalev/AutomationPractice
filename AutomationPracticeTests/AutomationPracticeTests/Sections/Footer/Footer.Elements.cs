using AutomationPracticeTests.Pages;
using OpenQA.Selenium;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections
{
    public partial class Footer
    {
        public WebElement FooterLinks(string lincText)
        {
            return Driver.FindElement(By.XPath($"//div[@class='footer-container']//a[normalize-space(.) = '{lincText}']"));

        }

        public WebElement FacebookLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'facebook')]"));
        public WebElement TwitterLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'twitter')]"));
        public WebElement YoutubeLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'youtube')]"));
        public WebElement GooglePlusLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'google')]"));
    }
}
