using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using SeleniumKP1_2.Framework.PageForms;
//using TechTalk.SpecFlow;

namespace SeleniumKP1_2.Framework.StepDefinitions
{
    [Binding]
    internal class MainPageStep
    {
        private MainPage mainPage;
        private WebDriver driver;

        public MainPageStep()
        {
            driver = new ChromeDriver();
        }

        [Given(@"Herokuapp website is open")]
        public void HeropuPageIsOpen()
        {
            mainPage = new MainPage(driver);
        }

        [Then(@"the main page is displayed")]
        public void TheMainPageIsDisplayed()
        {
            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened");
        }
    }
}
