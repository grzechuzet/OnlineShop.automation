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

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void gotoMainPage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
    }
}
