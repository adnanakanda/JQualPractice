using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.Tests
{
    [AllureNUnit]
    [AllureSuite("DataTable Tests")]
    internal class DataTableTest : BaseTest
    {
        [Test]
        //[AllureIssue("BUG-1234")]
        //[Ignore("Skipping due to known issue BUG-1234")]
        [AllureTag("NUnit", "Selenium")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Data Table")]
        [AllureStory("Sort and verify data in the table")]
        public void TestDataTable()
        {
            var mainPage = new MainPage(driver);
            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened.");
            mainPage.ClickSortableDataTable();
            var dataTablesPage = new DataTablePage(driver);
            var webSiteValue = dataTablesPage.GetWebSiteValue("jsmith@gmail.com");
            Assert.That(webSiteValue, Is.Not.Null, "Web site value for 'jsmith@gmail.com' is not found.");
            dataTablesPage.SortByFirstName();
            Assert.That(dataTablesPage.IsWebSiteValuePresent(webSiteValue), Is.True, "Saved web site value is not present after sorting.");

            Assert.That(dataTablesPage.AreLastNamesPresent("Smith", "Bach", "Doe", "Conway"), Is.True, "One or more expected last names are not present.");
        }
    }
}
