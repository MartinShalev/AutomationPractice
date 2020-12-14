using OpenQA.Selenium;
using SeleniumTests.Core;

namespace AutomationPracticeTests.Sections.Header
{
    public partial class Header 
    {
        public WebElement Banner => Driver.FindElement(By.ClassName("banner"));
        public WebElement NavigationBar => Driver.FindElement(By.XPath("//div[@class='nav']"));
        public WebElement NavCallUsElemet => Driver.FindElement(By.XPath("//span[@class='shop-phone']"));
        public WebElement SingInButton => Driver.FindElement(By.XPath("//div[@class='header_user_info']"));
        public WebElement ContactUsButton => Driver.FindElement(By.Id("contact-link"));
        public WebElement CompanyLogo => Driver.FindElement(By.Id("header_logo"));
        public WebElement SearchBox => Driver.FindElement(By.Id("searchbox"));
        public WebElement SearchBoxSubmmitButton => Driver.FindElement(By.XPath("//button[@name='submit_search']"));
        public WebElement ShopingCart => Driver.FindElement(By.ClassName("shopping_cart"));
        public WebElement BlogTopMenuWomenButton => Driver.FindElement(By.XPath("//a[@title='Women']"));
        public WebElement BlogTopMenuDressesButton => Driver.FindElement(By.XPath("//a[@title='Dresses']"));
        public WebElement BlogTopMenuTshirtsButton => Driver.FindElement(By.XPath("//a[@title='T-shirts']"));
    }
}
