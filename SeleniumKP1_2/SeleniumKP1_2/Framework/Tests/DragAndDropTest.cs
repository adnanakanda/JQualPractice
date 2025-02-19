using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class DragAndDropTest : BaseTest
    {
        [Test]
        public void TestDragAndDrop()
        {
            var mainPage = new MainPage(driver);

            Assert.That(mainPage.IsMainPageOpened(), Is.True, "Main page is not opened.");

            mainPage.ClickDragAndDrop();

            var dragAndDropPage = new DragAndDropPage(driver);

            dragAndDropPage.DragBoxAToBoxB();

            Assert.That(dragAndDropPage.IsBoxADraggedToBoxB(), Is.True, "Box A was not dragged to Box B.");
        }
    }
}
