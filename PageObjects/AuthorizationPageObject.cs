
namespace GosuslugiPasswordTests.PageObjects
{
    internal class AuthorizationPageObject
    {
        private IWebDriver _driver;
        private readonly By _noSingnInButton = By.XPath("//button[text()=' Не удаётся войти? ']");
        private int _waitin = 2000;
        public AuthorizationPageObject(IWebDriver _driver)
        {
            this._driver = _driver;
        }
        public CanNotGetInPageObject HelpSigIn()
        {
            _driver.FindElement(_noSingnInButton).Click();
            Thread.Sleep(_waitin);
            return new CanNotGetInPageObject(_driver);
        }
    }
}
