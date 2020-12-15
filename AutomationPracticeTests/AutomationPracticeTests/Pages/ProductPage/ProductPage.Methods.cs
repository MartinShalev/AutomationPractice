using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Pages.ProductPage
{
    public partial class ProductPage : BasePage
    {
        public ProductPage(WebDriver driver) : base(driver)
        {
        }

        public string URL { get { return "http://automationpractice.com/index.php?id_product=5&controller=product"; } }
    }
}
