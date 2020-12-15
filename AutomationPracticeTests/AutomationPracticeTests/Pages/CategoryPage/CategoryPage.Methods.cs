using SeleniumTests.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Pages.CategoryPage
{
    public partial class CategoryPage : BasePage
    {
        public CategoryPage(WebDriver driver) : base(driver)
        {
        }

        public string URL { get { return "http://automationpractice.com/index.php?id_category=3&controller=category"; } }
    }
}
