using OpenQA.Selenium;

namespace TaskBoardWebAppTests.Objects
{
    public class WebAppCreatePage : WebAppBasePage
    {
        public WebAppCreatePage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://taskboard.nakov.repl.co/tasks/create";

        public IWebElement TextBoxTitle =>
            driver.FindElement(By.Id("title"));
        public IWebElement TextBoxDescription =>
            driver.FindElement(By.Id("description"));
        public IWebElement ButtonCreate =>
            driver.FindElement(By.Id("create"));
        public IWebElement ElementErrorMessage =>
            driver.FindElement(By.CssSelector("body > main > div"));

        public void CreateTask(string title, string description)
        {
            TextBoxTitle.Clear();
            TextBoxTitle.SendKeys(title);
            TextBoxDescription.Clear();
            TextBoxDescription.SendKeys(description);
            ButtonCreate.Click();
        }
    }
}
