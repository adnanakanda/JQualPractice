using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class ManageCookieTest : BaseTest
    {

        [Test]
        public void TestCookieOperations()
        {
            var mainPage = new MainPage(driver);

            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened.");

            mainPage.AddCookie("Heroku", "TestCookie");
            mainPage.AddCookie("JaQual", "TestCookie2");

            Assert.That(mainPage.IsCookiePresent("Heroku"), Is.True, "The cookie 'Heroku' was not added.");
            Assert.That(mainPage.IsCookiePresent("JaQual"), Is.True, "The cookie 'JaQual' was not added.");

            mainPage.DeleteCookie("Heroku");
            mainPage.DeleteAllCookie();

            Assert.That(mainPage.IsCookiePresent("Heroku"), Is.False, "The cookie 'testKey' was not deleted.");
        }
    }
}
