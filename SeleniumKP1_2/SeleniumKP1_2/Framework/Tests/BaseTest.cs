using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class BaseTest
    {
        protected WebDriver driver;

        protected static string url = "https://the-internet.herokuapp.com/";
        protected WebDriverWait wait = null;
        protected static readonly int maxWait = 10;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWait));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
