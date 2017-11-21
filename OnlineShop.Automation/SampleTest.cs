using NUnit.Framework;
using OnlineShop.Automation.Helpers;
using OnlineShop.Automation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineShop.Automation
{
    [TestFixture]
    class SampleTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FirstTest()
        {
            MainPage home = new MainPage(driver);
            home.gotoMainPage();

            Assert.AreEqual(ConstantsHelper.indexURL,driver.Url.ToString());

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
