using OpenQA.Selenium;

namespace TaskBoardWebAppTests.Objects
{
    public class WebAppBasePage
    {
        protected readonly IWebDriver driver;

        public WebAppBasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public virtual string PageUrl { get; }

        public IWebElement LinkCreate => driver
            .FindElement(By.XPath("//a[contains(.,'Create')]"));
        public IWebElement LinkSearch => driver
            .FindElement(By.XPath("(//a[contains(.,'Search')])[1]"));
        public void Open()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }
    }
}
