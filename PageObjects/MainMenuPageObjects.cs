
namespace GosuslugiPasswordTests.PageObjects
{
    internal class MainMenuPageObjects
    {
        private IWebDriver _webDraver;
        private readonly By _singnInButton = By.XPath("//button[text()='Войти']");
        private int _waitin=2000;
        public MainMenuPageObjects(IWebDriver _draver)
        {
            this._webDraver = _draver;
        }

        public AuthorizationPageObject SinIn()
        {
            _webDraver.FindElement(_singnInButton).Click();
            Thread.Sleep(_waitin);
            return new AuthorizationPageObject(_webDraver);
        }
    }
}
