using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskBoardWebAppTests.Tests
{
    public class WebAppBaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
    }
}