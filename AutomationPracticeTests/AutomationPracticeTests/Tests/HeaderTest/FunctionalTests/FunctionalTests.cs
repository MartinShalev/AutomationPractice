using AutomationPracticeTests.Pages.CategoryPage;
using AutomationPracticeTests.Pages.ContactUs;
using AutomationPracticeTests.Pages.LogIn;
using AutomationPracticeTests.Sections.Header;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Linq;

namespace AutomationPracticeTests.Tests.HeaderTest.FunctionalTests
{
    [TestFixture]
    public class FunctionalTests : BaseTest
    {
        private Header _headerSection;
        private SingInPage _singInPage;
        private ContactUsPage _contactUsPage;
        private CategoryPage _categoyPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _headerSection = new Header(Driver);
            _singInPage = new SingInPage(Driver);
            _contactUsPage = new ContactUsPage(Driver);
            _categoyPage = new CategoryPage(Driver);
            Driver.GoToUrl(_headerSection.URL);
        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                TakeScreenshot(@"..\..\..\");
            }
            Driver.Quit();
        }
        [Test]
        public void SuccessRelocationWhenClickContactUsButton()
        {

            _headerSection.ContactUsButton.Click();

            var currentUrl = Driver.Url();

            Assert.AreEqual(currentUrl, _contactUsPage.URL);
        }

        [Test]
        public void SuccessRelocationWhenClickSingInButton()
        {
            _headerSection.SingInButton.Click();

            var currentUrl = Driver.Url();

            Assert.AreEqual(currentUrl, _singInPage.URL);
        }

        [Test]
        public void RelocatedToMainPageWhenLogoIsClicked()
        {
            _headerSection.SingInButton.Click();

            Assert.AreEqual(Driver.Url(), _singInPage.URL);

            _headerSection.CompanyLogo.Click();

            Assert.AreEqual(Driver.Url(), _headerSection.URL);
        }

        [Test]
        public void SuccessRelocationWhenClickWomenCategoryButton()
        {
            _headerSection.BlogTopMenuWomenButton.Click();

            Assert.AreEqual(Driver.Url(), _categoyPage.URL);
        }

        [Test]
        public void SuccessRelocationWhenClicDressesCategoryButton()
        {
            _headerSection.BlogTopMenuDressesButton.Click();

            Assert.IsTrue(Driver.Url().Contains("http://automationpractice.com/index.php?id_category"));
        }

        
    }
}
