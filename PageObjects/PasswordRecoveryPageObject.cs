using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosuslugiPasswordTests.PageObjects
{
    internal class PasswordRecoveryPageObject
    {
        private IWebDriver _driver;
        private readonly By _actual = By.XPath("//h3[@class='title-h3 mb-24 text-center']");
        public PasswordRecoveryPageObject(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public string Verification()
        {
            string actual = _driver.FindElement(_actual).Text;
            return actual;

        }


    }
}
