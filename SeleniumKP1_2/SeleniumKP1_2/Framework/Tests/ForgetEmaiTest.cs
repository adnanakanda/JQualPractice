using SeleniumKP1_2.Framework.PageForms;

namespace SeleniumKP1_2.Framework.Tests
{
    internal class ForgetEmaiTest : BaseTest
    {
        [Test]
        public void TestForgetEmail()
        {
            var forgetEmailPage = new ForgotPasswordPage(driver);
            forgetEmailPage.EnterEmail("abc@gmail.com");
        }
    }
}
