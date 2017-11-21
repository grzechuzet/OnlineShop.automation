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

        [Test]
        [Ignore("Assert doesn't work!")]
        public void GoToContactUsPageAndSendMessage()
        {
            MainPage home = new MainPage(driver);
            home.gotoMainPage();
            ContactUsPage contactUs = home.goToContactPage();

            contactUs.SelectSubjectHeading(ConstantsHelper.subjectWebmaster);
            contactUs.InsertEmailAddress("test@testselenium.com");
            contactUs.InsertOrderReference("1234");
            contactUs.InsertMessage("TEST MESSAGE");
            contactUs.SubmitMessage();

            Assert.IsTrue(contactUs.IsSuccessBoxVisible());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
