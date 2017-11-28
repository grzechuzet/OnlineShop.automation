using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlineShop.Automation.Pages
{
    class MainPage
    {
        private IWebDriver driver;
        private string baseURL = @"http://automationpractice.com";

        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement ContactUsLink;

				[FindsBy(How = How.ClassName, Using = "header_user_info")]
				private IWebElement SignInLink;

				public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void gotoMainPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public ContactUsPage goToContactPage()
        {
            ContactUsLink.Click();
            return new ContactUsPage(driver);
        }
				public SignInPage goToSignPage()
				{
						SignInLink.Click();
						return new SignInPage(driver);
				}
    }
}
