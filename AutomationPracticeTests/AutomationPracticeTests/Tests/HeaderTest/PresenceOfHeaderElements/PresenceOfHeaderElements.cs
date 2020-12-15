
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
        public void PresencsOfBaberImg()
        {
            Assert.IsTrue(_headerSection.Banner.Displayed);           
        }

        [Test]
        public void PresencsOfNavCallElement()
        {
            Assert.IsTrue(_headerSection.NavCallUsElemet.Displayed);
        }

        [Test]
        public void PresencsOfNavContactUsButton()
        {
            Assert.IsTrue(_headerSection.ContactUsButton.Displayed);
        }

        [Test]
        public void PresencsOfNavSingInButton()
        {
            Assert.IsTrue(_headerSection.SingInButton.Displayed);
        }

        [Test]
        public void PresencsOfCompanyLogo()
        {
            Assert.IsTrue(_headerSection.CompanyLogo.Displayed);
        }

        [Test]
        public void PresencsOfSearchBox()
        {
            Assert.IsTrue(_headerSection.SearchBox.Displayed);
        }

        [Test]
        public void PresencsOfShopingCart()
        {
            Assert.IsTrue(_headerSection.ShopingCart.Displayed);
        }

        [Test]
        public void PresencsOfWomenMenuButton()
        {
            Assert.IsTrue(_headerSection.BlogTopMenuWomenButton.Displayed);
        }

        [Test]
        public void PresencsOfDressMenuButton()
        {
            Assert.IsTrue(_headerSection.BlogTopMenuDressesButton.Displayed);
        }

        [Test]
        public void PresencsOfTshirtsMenuButton()
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
        public void PreseceOfWomenCategorySubMenus(string subMenu)
        {
           Driver.HoverElement(_headerSection.BlogTopMenuWomenButtonSubMenus(subMenu));

            Assert.IsTrue(_headerSection.BlogTopMenuWomenButtonSubMenus(subMenu).Displayed);
        }


    }
}
