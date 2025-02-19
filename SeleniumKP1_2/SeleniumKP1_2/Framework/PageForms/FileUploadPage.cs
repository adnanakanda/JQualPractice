using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class FileUploadPage
    {
        private readonly WebDriver _driver;
        private WebDriverWait _wait;

        public FileUploadPage(WebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement ChooseFileButton => _driver.FindElement(By.Id("file-upload"));
        private IWebElement UploadButton => _driver.FindElement(By.Id("file-submit"));
        private IWebElement UploadedFiles => _driver.FindElement(By.Id("uploaded-files"));
        private IWebElement UploadMessage => _driver.FindElement(By.TagName("h3"));

        public void ChooseFile(string filePath)
        {
            ChooseFileButton.SendKeys(filePath);
        }

        public void ClickUploadButton()
        {
            UploadButton.Click();
        }

        public string GetUploadedFileName()
        {
            return UploadedFiles.Text;
        }

        public bool IsUploadMessageDisplayed()
        {
            return UploadMessage.Text.Equals("File Uploaded!");
        }

        // Using relative locators
        public IWebElement GetUploadButtonUsingRelativeLocator()
        {
            var chooseFileButton = _driver.FindElement(By.Id("file-upload"));
            return _driver.FindElement(RelativeBy.WithLocator(By.TagName("input")).Below(ChooseFileButton));
        }

        public IWebElement GetChooseFileButtonUsingRelativeLocator()
        {
            var uploadButton = _driver.FindElement(By.Id("file-submit"));
            return _driver.FindElement(RelativeBy.WithLocator(By.Id("file-upload")).Above(uploadButton));
        }
    }
}
