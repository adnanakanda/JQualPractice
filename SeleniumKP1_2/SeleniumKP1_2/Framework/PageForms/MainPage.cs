using OpenQA.Selenium;
using SeleniumKP1_2.Framework.Utils;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class MainPage
    {
        private readonly WebDriver _driver;
        private IWebElement SortableDataTableLable => _driver.FindElement(By.LinkText("Sortable Data Tables"));
        private IWebElement JavaScriptAlertsLabel => _driver.FindElement(By.LinkText("JavaScript Alerts"));
        private IWebElement FileUploadLabel => _driver.FindElement(By.LinkText("File Upload"));
        private IWebElement FileDownloadLabel => _driver.FindElement(By.LinkText("File Download"));
        private IWebElement DragAndDropLabel => _driver.FindElement(By.LinkText("Drag and Drop"));
        private IWebElement PageTitle => _driver.FindElement(By.XPath(string.Format(LocatorConstants.PreciseTextXpath, "Welcome to the-internet")));

        public MainPage(WebDriver driver)
        {
            _driver = driver;
        }

        public void ClickSortableDataTable()
        {
            SortableDataTableLable.Click();
        }

        public void ClickJavaScriptAlerts()
        {
            JavaScriptAlertsLabel.Click();
        }

        public void ClickFileUpload()
        {
            FileUploadLabel.Click();
        }

        public void ClickFileDownload()
        {
            FileDownloadLabel.Click();
        }

        public void ClickDragAndDrop()
        {
            DragAndDropLabel.Click();
        }

        public bool IsMainPageOpened()
        {
            try
            {
                return PageTitle.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void AddCookie(string name, string value)
        {
            var cookie = new Cookie(name, value);
            _driver.Manage().Cookies.AddCookie(cookie);
        }

        public bool IsCookiePresent(string name)
        {
            return _driver.Manage().Cookies.GetCookieNamed(name) != null;
        }

        public void DeleteCookie(string name)
        {
            _driver.Manage().Cookies.DeleteCookieNamed(name);
        }

        public void DeleteAllCookie()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
