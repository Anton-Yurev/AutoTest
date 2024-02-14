
namespace GosuslugiPasswordTests.PageObjects
{
    internal class CanNotGetInPageObject
    {
        private IWebDriver _driver;
        private readonly By _resetPasswordButton = By.XPath("//button[text()=' восстановления пароля ']");
        private int _waitin = 2000;
        public CanNotGetInPageObject(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public PasswordRecoveryPageObject PasswordRecovery()
        {
            _driver.FindElement(_resetPasswordButton).Click();
            Thread.Sleep(_waitin);
            return new PasswordRecoveryPageObject(_driver);
        }
    }
}
