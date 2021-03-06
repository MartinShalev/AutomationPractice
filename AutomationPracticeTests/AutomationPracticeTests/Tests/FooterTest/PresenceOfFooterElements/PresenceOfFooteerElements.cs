﻿using AutomationPracticeTests.Sections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTests.Tests.FooterTest.FooterElements
{
    [TestFixture]
    public class PresenceOfFooteerElements : BaseTest
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
        public void PresenceOfFooterLinkElements(string linkText)
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
        [TestCase("icon-map-marker")]
        [TestCase("icon-phone")]
        [TestCase("icon-envelope-alt")]
        public void PreseceOfInformationSectionIcons(string iconName)
        {
            Driver.ScrollToElement(_footerSection.InformationSectionIconMarkers(iconName));

            Assert.IsTrue(_footerSection.InformationSectionIconMarkers(iconName).Displayed);
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
        [Test]
        public void PresenceOfNewsletterSubmitButton()
        {
            Driver.ScrollToElement(_footerSection.NewsLetterSubmitButton);

            Assert.IsTrue(_footerSection.NewsLetterSubmitButton.Displayed);
        }

        [Test]
        public void PresenceOfCreatorsLink()
        {
            Driver.ScrollToElement(_footerSection.CreatorsLink);

            Assert.IsTrue(_footerSection.CreatorsLink.Displayed);
        }
        
        [Test]
        public void PresenceOfInformationSection()
        {
            Driver.ScrollToElement(_footerSection.InformationSection);

            Assert.IsTrue(_footerSection.InformationSection.Displayed);
        }


    }
}
