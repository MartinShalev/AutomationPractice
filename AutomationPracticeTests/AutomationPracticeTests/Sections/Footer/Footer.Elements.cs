using AutomationPracticeTests.Pages;
using OpenQA.Selenium;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections
{
    public partial class Footer
    {
        public WebElement FooterLinks(string linkText)
        {
            return Driver.FindElement(By.XPath($"//div[@class='footer-container']//a[normalize-space(.) = '{linkText}']"));

        }
        public WebElement SocialMediaLinksImages(string mediaName)
        {

            return Driver.FindElement(By.XPath($"//a[contains(@href, '{mediaName}')]"));

        }
        public WebElement FacebookLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'facebook')]"));
        public WebElement TwitterLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'twitter')]"));
        public WebElement YoutubeLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'youtube')]"));
        public WebElement GooglePlusLinkButton => Driver.FindElement(By.XPath("//a[contains(@href, 'google')]"));
        public WebElement NewsLetterField => Driver.FindElement(By.Id("newsletter-input"));
        public WebElement SuccessMessage => Driver.FindElement(By.XPath("//div[@id='columns']//p[contains(@class, 'alert-success')]"));
        public WebElement ErrorMessage => Driver.FindElement(By.XPath("//div[@id='columns']//p[contains(@class, 'alert-danger')]"));
        public WebElement NewsLetterSubmitButton => Driver.FindElement(By.XPath("//div[@class='form-group']//button"));
        public WebElement CreatorsLink => Driver.FindElement(By.XPath("//section[contains(@class, 'bottom-footer')]//a"));
    }
}
