using AutomationPracticeTests.Pages.ContactUs;
using AutomationPracticeTests.Pages.LogIn;
using AutomationPracticeTests.Sections.Header;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Tests.HeaderTest.FunctionalTests
{
    [TestFixture]
    public class FunctionalTests : BaseTest
    {
        private Header _headerSection;
        private SingInPage _singInPage;
        private ContactUsPage _contactUsPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _headerSection = new Header(Driver);
            _singInPage = new SingInPage(Driver);
            _contactUsPage = new ContactUsPage(Driver);
            Driver.GoToUrl(_headerSection.URL);
        }
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                TakeScreenshot(@"..\..\..\");
                Driver.Quit();
            }
        }
        [Test]
        public void RelocatedToContactUsPageWhenClickContactUsButton()
        {

            _headerSection.ContactUsButton.Click();

            var currentUrl = Driver.Url();

            Assert.AreEqual(currentUrl, _contactUsPage.URL);
        }
    }
}
