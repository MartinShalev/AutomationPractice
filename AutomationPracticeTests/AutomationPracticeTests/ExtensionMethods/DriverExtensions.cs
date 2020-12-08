using OpenQA.Selenium;
using SeleniumTests.Core;

public static class DriverExtensions
{
    public static void ScrollUp(this WebDriver driver, int pixels)
    {
        ((IJavaScriptExecutor)driver.WrappedDriver).ExecuteScript($"window.scrollBy(0, {-pixels})");
    }

    public static void ScrollDown(this WebDriver driver, int pixels)
    {
        ((IJavaScriptExecutor)driver.WrappedDriver).ExecuteScript($"window.scrollBy(0, {pixels})");
    }

    public static WebElement ScrollToElement(this WebDriver driver, WebElement element)
    {
        ((IJavaScriptExecutor)driver.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
        return element;
    }
}
