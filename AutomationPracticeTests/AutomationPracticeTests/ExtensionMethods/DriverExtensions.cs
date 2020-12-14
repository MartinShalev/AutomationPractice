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

    public static WebElement HoverElement(this WebDriver driver, WebElement element)
    {
        ((IJavaScriptExecutor)driver.WrappedDriver).
            ExecuteScript
            (
            "var evObj = document.createEvent('MouseEvents'); " +
            "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);" +
            "arguments[0].dispatchEvent(evObj);",
             element.WrappedElement
             );

        return element;

    }
}
