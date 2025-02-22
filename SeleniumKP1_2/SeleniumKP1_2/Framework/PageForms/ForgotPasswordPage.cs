using OpenQA.Selenium;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class ForgotPasswordPage
    {
        private readonly WebDriver _driver;
        private IWebElement EmailTxtBox => _driver.FindElement(RelativeBy.WithLocator(By.Id("email")).Above(SubmitButton));
        private IWebElement SubmitButton => _driver.FindElement((By.Id("form_submit")));

        public ForgotPasswordPage(WebDriver driver)
        {
            _driver = driver;
        }
        public void EnterEmail(string email)
        {
            EmailTxtBox.SendKeys(email);
        }
    }
}
