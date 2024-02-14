using GosuslugiPasswordTests.PageObjects;

namespace GosuslugiPasswordTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private string _urlGosUslugi = "https://www.gosuslugi.ru/";
        private const string EXPECTED = "Восстановление пароля";
        private string _actualyData;
        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Edge.EdgeDriver();
            _driver.Navigate().GoToUrl(_urlGosUslugi);
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObjects(_driver);
            _actualyData = mainMenu.SinIn().HelpSigIn().PasswordRecovery().Verification();
            Assert.AreEqual(EXPECTED, _actualyData, "ERROR");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}