using AutomationPracticeTests.Sections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationPracticeTests.Tests.FooterTest
{
    [TestFixture]
    public class FooterLink : BaseTest
    {
        private Footer _footterSection;
        [SetUp]
        public void SetUp()
        {
            base.Initialize();
            _footterSection = new Footer(Driver);
            Driver.GoToUrl(_footterSection.URL);

        }

        [Test]
        [TestCase("Women")]
        [TestCase("Specials")]
        [TestCase("Best sellers")]
        [TestCase("Our stores")]
        [TestCase("Contact us")]
        [TestCase("Terms and conditions of use")]
        [TestCase("About us")]
        [TestCase("Sitemap")]
        [TestCase("My orders")]
        [TestCase("My credit slips")]
        [TestCase("My addresses")]
        [TestCase("My personal info")]

        public void CheckFooterLinks(string linkText)
        {
            var urlBeforeClick = _footterSection.FooterLinks(linkText).GetAttribute("href").ToString();

            _footterSection.FooterLinks(linkText).Click();

            var curentURL = Driver.Url().ToString();

            Assert.AreEqual(urlBeforeClick, curentURL);

        }

        // TODO Last 4 testCases when finished the LogIn tests !!!! 

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                TakeScreenshot(@"..\..\..\");
            }
            Driver.Quit();
        }
    }
}
