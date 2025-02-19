using SeleniumKP1_2.Framework.PageForms;
using SeleniumKP1_2.Framework.Utils;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class FileDownloadTest : BaseTest
    {
        [Test]
        public void TestFileDownload()
        {
            var mainPage = new MainPage(driver);
            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened.");

            mainPage.ClickFileDownload();

            var fileDownloadPage = new FileDownloadPage(driver);

            fileDownloadPage.DownloadSampleFile();

            var downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "firefox.txt");

            wait.Until(d => File.Exists(downloadPath));

            Assert.That(File.Exists(downloadPath), Is.True, "The file 'firefox.txt' was not downloaded properly.");

            if (File.Exists(downloadPath))
            {
                TestUtils.DeleteFileIfExists(downloadPath);
            }
        }
    }
}
