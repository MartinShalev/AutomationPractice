
using AutomationPracticeTests.Sections.Header;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationPracticeTests.Tests.HeaderTest.PresenceOfHeaderElements
{
    [TestFixture]
    class PresenceOfHeaderElements : BaseTest
    {
        private Header _headerSection;

        [SetUp]
        public void SetUp()
        {

            Initialize();
            _headerSection = new Header(Driver);
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
        public void PresenceOfBaberImg()
        {
            Assert.IsTrue(_headerSection.Banner.Displayed);           
        }

        [Test]
        public void PresenceOfNavCallElement()
        {
            Assert.IsTrue(_headerSection.NavCallUsElemet.Displayed);
        }

        [Test]
        public void PresenceOfNavContactUsButton()
        {
            Assert.IsTrue(_headerSection.ContactUsButton.Displayed);
        }

        [Test]
        public void PresenceOfNavSingInButton()
        {
            Assert.IsTrue(_headerSection.SingInButton.Displayed);
        }

        [Test]
        public void PresenceOfCompanyLogo()
        {
            Assert.IsTrue(_headerSection.CompanyLogo.Displayed);
        }

        [Test]
        public void PresenceOfSearchBox()
        {
            Assert.IsTrue(_headerSection.SearchBox.Displayed);
        }

        [Test]
        public void PresenceOfShopingCart()
        {
            Assert.IsTrue(_headerSection.ShopingCart.Displayed);
        }

        [Test]
        public void PresenceOfWomenMenuButton()
        {
            Assert.IsTrue(_headerSection.BlogTopMenuWomenButton.Displayed);
        }

        [Test]
        public void PresenceOfDressMenuButton()
        {
            Assert.IsTrue(_headerSection.BlogTopMenuDressesButton.Displayed);
        }

        [Test]
        public void PresenceOfTshirtsMenuButton()
        {
            Assert.IsTrue(_headerSection.BlogTopMenuTshirtsButton.Displayed);
        }

        [Test]
        [TestCase("Tops")]
        [TestCase("T-shirts")]
        [TestCase("Blouses")]
        [TestCase("Dresses")]
        [TestCase("Casual Dresses")]
        [TestCase("Evening Dresses")]
        [TestCase("Summer Dresses")]
        public void PresenceOfWomenCategorySubMenus(string subMenu)
        {
           Builder.MoveToElement(_headerSection.BlogTopMenuWomenButton .WrappedElement).Perform();

            Assert.IsTrue(_headerSection.BlogTopSubMenus(subMenu).Displayed);
        }

        [Test]
        [TestCase("Casual Dresses")]
        [TestCase("Evening Dresses")]
        [TestCase("Summer Dresses")]
        public void PresenceOfDressesCategorySubMenus(string subMenu)
        {



            Builder.MoveToElement(_headerSection.BlogTopMenuDressesButton.WrappedElement).Perform();

            Assert.IsTrue(_headerSection.BlogTopSubMenus(subMenu).Displayed);
        }


    }
}
