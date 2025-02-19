using OpenQA.Selenium;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class FileDownloadPage
    {
        private readonly WebDriver _driver;
        private IWebElement SampleFileLink => _driver.FindElement(By.LinkText("firefox.txt"));

        public FileDownloadPage(WebDriver driver)
        {
            _driver = driver;
        }

        public void DownloadSampleFile()
        {
            SampleFileLink.Click();
        }
    }
}
