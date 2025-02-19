using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using Reqnroll;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumKP1_2.Framework.Hooks
{
    [Binding]
    internal class Hooks
    {
        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    Setup();
        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    TearDown();
        //}
        protected WebDriver driver;
        protected static string url = "https://the-internet.herokuapp.com/";
        protected WebDriverWait wait = null;
        protected static readonly int maxWait = 10;

        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Allure.CleanupResultDirectory();
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            var scenarioName = scenarioContext.ScenarioInfo.Title;

            // Ensure Allure test case starts correctly
            Allure.StartTestCase(new TestResult
            {
                name = scenarioName,
                description = scenarioContext.ScenarioInfo.Description,
                start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            });

            // Initialize WebDriver
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxWait));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
            Allure.StopTestCase();
        }
    }
}
