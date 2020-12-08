using AutomationPracticeTests.Sections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Linq;
using System.Threading;

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
        [TestCase("Women")]
        [TestCase("Specials")]
        [TestCase("Best sellers")]
        [TestCase("Our stores")]
        [TestCase("Contact us")]
        [TestCase("Terms and conditions of use")]
        [TestCase("About us")]
        [TestCase("Sitemap")]

        public void FooterLinksWhenUserIsNOTLogIn(string linkText)
        {
            var elementUrlBeforeClick = _footterSection.FooterLinks(linkText).GetAttribute("href").ToString();

            _footterSection.FooterLinks(linkText).Click();

            var curentURL = Driver.Url().ToString();

            Assert.AreEqual(elementUrlBeforeClick, curentURL);

        }
        [TestCase("My orders")]
        [TestCase("My credit slips")]
        [TestCase("My addresses")]
        [TestCase("My personal info")]
        public void FooterLinksMyAccountOptionsWhenUserIsNOTLogIn(string linkText)
        {

            _footterSection.FooterLinks(linkText).Click();

            var test = Driver.Url().ToString();

            Assert.IsTrue(Driver.Url().Contains("authentication&back"));
        }
        [Test]
        public void ClikFacebookLinkButton()
        {
            _footterSection.FacebookLinkButton.Click();

            Driver.WrappedDriver.SwitchTo().Window(Driver.WrappedDriver.WindowHandles.Last());

            var currentUrl = Driver.Url().ToString();

            Assert.IsTrue(currentUrl.Contains("www.facebook.com"));
        }

        [Test]
        public void ClikTwitterLinkButton()
        {
            _footterSection.TwitterLinkButton.Click();

            Driver.WrappedDriver.SwitchTo().Window(Driver.WrappedDriver.WindowHandles.Last());

            var currentUrl = Driver.Url().ToString();

            Assert.IsTrue(currentUrl.Contains("twitter.com"));
        }

        [Test]
        public void ClikYoutubeLinkButton()
        {
            _footterSection.YoutubeLinkButton.Click();

            Driver.WrappedDriver.SwitchTo().Window(Driver.WrappedDriver.WindowHandles.Last());

            var currentUrl = Driver.Url().ToString();

            Assert.IsTrue(currentUrl.Contains("www.youtube.com"));
        }

        [Test]
        public void ClikGooglePlusLinkButton()
        {
            _footterSection.GooglePlusLinkButton.Click();

            Driver.WrappedDriver.SwitchTo().Window(Driver.WrappedDriver.WindowHandles.Last());

            var currentUrl = Driver.Url().ToString();

            Assert.IsTrue(currentUrl.Contains("plus.google.com"));
        }
        [Test]
        public void NewsLetterFieldWithCorrectNweEmail()
        {
            var email = _footterSection.CreateRandomEmail();

            Driver.ScrollToElement(_footterSection.NewsLetterField)
                .SendKeys(email);
            _footterSection.NewsLetterSubmitButton.Submit();

            Assert.AreEqual(_footterSection.Message.Text, "Newsletter : You have successfully subscribed to this newsletter.");
        }
    }
}
