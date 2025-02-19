using OpenQA.Selenium;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class DataTablePage
    {
        private readonly WebDriver _driver;
        private IWebElement GetEmailCell(string email) => _driver.FindElement(By.XPath($"//table[@id='table2']//td[text()='{email}']"));
        private IWebElement FirstNameHeader => _driver.FindElement(By.XPath("//span[@class='first-name']"));
        private IWebElement LastNameColumn => _driver.FindElement(By.XPath("//table[@id='table2']//td[1]"));
        public DataTablePage(WebDriver driver)
        {
            _driver = driver;
        }


        public string GetWebSiteValue(string email)
        {
            var emailCell = GetEmailCell(email);
            return emailCell.FindElement(By.XPath("./following-sibling::td[2]")).Text;
        }

        public void SortByFirstName()
        {
            FirstNameHeader.Click();
        }

        public bool IsWebSiteValuePresent(string webSiteValue)
        {
            var webSiteValues = _driver.FindElements(By.XPath("//table[@id='table2']//td[5]")).Select(e => e.Text).ToList();
            return webSiteValues.Contains(webSiteValue);
        }

        public bool AreLastNamesPresent(params string[] lastNames)
        {
            var lastNameValues = _driver.FindElements(By.XPath("//table[@id='table2']//td[1]")).Select(e => e.Text).ToList();
            return lastNames.All(lastName => lastNameValues.Contains(lastName));
        }
    }
}
