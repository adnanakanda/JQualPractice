using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class FileUploadTest : BaseTest
    {
        [Test]
        public void TestFileUpload()
        {
            var mainPage = new MainPage(driver);

            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened.");

            mainPage.ClickFileUpload();

            var fileUploadPage = new FileUploadPage(driver);

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "testfile.txt");

            File.WriteAllText(filePath, "This is a test file.");

            var fileName = Path.GetFileName(filePath);

            fileUploadPage.ChooseFile(filePath);

            fileUploadPage.ClickUploadButton();

            Assert.That(fileUploadPage.IsUploadMessageDisplayed(), Is.True, "'File Uploaded!' message is not displayed.");

            Assert.That(fileUploadPage.GetUploadedFileName(), Is.EqualTo(fileName), "Uploaded file name is not displayed correctly.");
        }
    }
}
