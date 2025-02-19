using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Reqnroll;
using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.StepDefinitions
{
    [Binding]
    internal class DataTestStep
    {
        private readonly DataTablePage _dataTablePage;
        private static readonly AllureLifecycle Allure = AllureLifecycle.Instance;

        public DataTestStep(WebDriver driver)
        {
            _dataTablePage = new DataTablePage(driver);
        }

        [When(@"I find the '(.*)' email")]
        [AllureStep("Finding email {0}")]
        public void IFindTheEmail(string email)
        {
            var emailCell = _dataTablePage.GetEmail(email);
            if (emailCell == null)
            {
                throw new Exception($"Email '{email}' not found in the table.");
            }
        }

        [Then(@"The '(.*)' is on the table")]
        [AllureStep("Verifying email {0} is on the table")]
        public void TheEmailIsOnTable(string email)
        {
            Assert.That(_dataTablePage.IsEmailPresent(email), Is.True, "Email is not found!");
        }

        [Then(@"the table has the following first names:")]
        [AllureStep("Verifying the table has the following first names")]
        public void IsValueInTable(Table fname)
        {
            var firstNames = fname.Rows.Select(row => row["FirstName"]).ToList();
            foreach (var firstName in firstNames)
            {
                Assert.That(_dataTablePage.IsFirstNamePresent(firstName), Is.True, $"First name '{firstName}' is not found in the table.");
            }
        }
    }
}
