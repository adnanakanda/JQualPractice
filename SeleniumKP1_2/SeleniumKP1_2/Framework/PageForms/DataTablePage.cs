using OpenQA.Selenium;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class DataTablePage
    {
        private readonly WebDriver _driver;

        private readonly By _emailCellLocator = By.XPath("//table[@id='table2']//td[text()='{0}']");
        private readonly By _firstNameHeaderLocator = By.XPath("//span[@class='first-name']");
        private readonly By _lastNameColumnLocator = By.XPath("//table[@id='table2']//td[1]");
        private readonly By _webSiteValueLocator = By.XPath("//table[@id='table2']//td[5]");

        private IWebElement GetEmailCell(string email) => _driver.FindElement(By.XPath($"//table[@id='table2']//td[text()='{email}']"));
        private IWebElement FirstNameHeader => _driver.FindElement(_firstNameHeaderLocator);
        private IWebElement LastNameColumn => _driver.FindElement(_lastNameColumnLocator);

        public DataTablePage(WebDriver driver)
        {
            _driver = driver;
        }

        public string GetEmail(string email)
        {
            return GetEmailCell(email).Text;
        }

        public string GetWebSiteValue(string email)
        {
            var emailCell = GetEmailCell(email);
            var webSiteValueLocator = By.XPath("./following-sibling::td[2]");
            return emailCell.FindElement(webSiteValueLocator).Text;
        }

        public void SortByFirstName()
        {
            FirstNameHeader.Click();
        }

        public bool IsWebSiteValuePresent(string webSiteValue)
        {
            var webSiteValues = _driver.FindElements(_webSiteValueLocator).Select(e => e.Text).ToList();
            return webSiteValues.Contains(webSiteValue);
        }

        public bool AreLastNamesPresent(params string[] lastNames)
        {
            var lastNameValues = _driver.FindElements(_lastNameColumnLocator).Select(e => e.Text).ToList();
            return lastNames.All(lastName => lastNameValues.Contains(lastName));
        }

        public bool IsEmailPresent(string email)
        {
            try
            {
                return GetEmailCell(email) != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsFirstNamePresent(string firstName)
        {
            try
            {
                return _driver.FindElement(By.XPath($"//table[@id='table2']//td[text()='{firstName}']")) != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
