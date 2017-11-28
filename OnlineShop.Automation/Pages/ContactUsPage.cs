using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlineShop.Automation.Pages
{
    class ContactUsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

       
        [FindsBy(How = How.ClassName, Using = "contact-form-box")]
        private IWebElement ContactFormBox;

        [FindsBy(How = How.Id, Using = "id_contact")]
        private IWebElement SubjectHeadingSelectDropdown;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement EmailAddressInput;

        [FindsBy(How = How.Id, Using = "id_order")]
        private IWebElement OrderReferenceInput;

        [FindsBy(How = How.Id, Using = "fileUpload")]
        private IWebElement FileUploadInput;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement MessageInput;

        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement SubmitMessageButton;

        [FindsBy(How = How.ClassName, Using = "alert-danger")]
        private IWebElement ErrorBox;
        
        [FindsBy(How = How.ClassName, Using = "alert-success")]
				//[FindsBy(How = How.XPath, Using = "//div[@id='center_column']/p[text()='Your message has been successfully sent to our team.']")]
				private IWebElement SuccessBox;

        public void SelectSubjectHeading(string text)
        {
           new SelectElement(SubjectHeadingSelectDropdown).SelectByText(text);
        }

        public void InsertEmailAddress(string email)
        {
            EmailAddressInput.Clear();
            EmailAddressInput.SendKeys(email);
        }

        public void InsertOrderReference(string order)
        {
            OrderReferenceInput.Clear();
            OrderReferenceInput.SendKeys(order);
        }

        public void InsertMessage(string message)
        {
            MessageInput.Clear();
            MessageInput.SendKeys(message);
        }

        public void SubmitMessage()
        {
            SubmitMessageButton.Click();
            //new WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(ExpectedConditions.ElementIsVisible(By.ClassName("alert-success")));
        }

        public bool IsErrorBoxVisible()
        {
            return ErrorBox.Displayed;
        }

        public bool IsSuccessBoxVisible()
        {
            return SuccessBox.Displayed;
        }

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
    }
}
