using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumKP1_2.Framework.PageForms
{
    internal class DragAndDropPage
    {
        private readonly WebDriver _driver;
        private IWebElement BoxA => _driver.FindElement(By.Id("column-a"));
        private IWebElement BoxB => _driver.FindElement(By.Id("column-b"));

        public DragAndDropPage(WebDriver driver)
        {
            _driver = driver;
        }

        public void DragBoxAToBoxB()
        {
            var actions = new Actions(_driver);
            actions.DragAndDrop(BoxA, BoxB).Perform();
        }

        public bool IsBoxADraggedToBoxB()
        {
            return BoxB.FindElement(By.TagName("header")).Text == "A";
        }
    }
}
