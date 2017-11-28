using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace OnlineShop.Automation.Pages
{
	class SignInPage
	{
		private IWebDriver driver;
		private WebDriverWait wait;

		[FindsBy(How = How.Id, Using = "email_create")]
		IWebElement EmailCreateInput;

		[FindsBy(How = How.Id, Using = "SubmitCreate")]
		IWebElement SubmitAccountButton;

		public SignInPage(IWebDriver driver)
		{
			this.driver = driver;
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			PageFactory.InitElements(driver, this);
		}
		
		public void InsertEmailSignIn(string email)
		{
			EmailCreateInput.Clear();
			EmailCreateInput.SendKeys(email);
		}

		public void SubmitAccount()
		{
			SubmitAccountButton.Click();
		}
		
	}
}
