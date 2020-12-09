using AutomationPracticeTests.Sections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Tests.FooterTest.FooterElements
{
    [TestFixture]
    public class PresentsOfFooteerElements : BaseTest
    {
        private Footer _footerSection;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _footerSection = new Footer(Driver);
            Driver.GoToUrl(_footerSection.URL);
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
        [TestCase("My orders")]
        [TestCase("My credit slips")]
        [TestCase("My addresses")]
        [TestCase("My personal info")]
        public void PresentsOfFooterLinkElements(string linkText)
        {
            Driver.ScrollToElement(_footerSection.FooterLinks(linkText));

            Assert.IsTrue(_footerSection.FooterLinks(linkText).Displayed);
        }

        [Test]
        [TestCase("facebook")]
        [TestCase("twitter")]
        [TestCase("youtube")]
        [TestCase("google")]
        public void PresenceOfFooterSocialMediaImages(string mediaName)
        {
            Driver.ScrollToElement(_footerSection.SocialMediaLinksImages(mediaName));

            Assert.IsTrue(_footerSection.SocialMediaLinksImages(mediaName).Displayed);
        }

        [Test]
        public void PreseceOfNewsletterTextElement()
        {
            Driver.ScrollToElement(_footerSection.NewsletterTextElement);

            Assert.IsTrue(_footerSection.NewsletterTextElement.Displayed);
        }

        [Test]
        public void PreseceOfNewsletterEmailInputField()
        {
            Driver.ScrollToElement(_footerSection.NewsLetterEmailInputElement);

            Assert.IsTrue(_footerSection.NewsLetterEmailInputElement.Displayed);
        }


    }
}
