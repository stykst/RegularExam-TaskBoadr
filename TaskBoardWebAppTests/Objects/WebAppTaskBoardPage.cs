using OpenQA.Selenium;

namespace TaskBoardWebAppTests.Objects
{
    public class WebAppTaskBoardPage : WebAppBasePage
    {
        public WebAppTaskBoardPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://taskboard.nakov.repl.co/boards";

        public IReadOnlyCollection<IWebElement> ListOfTasks =>
            driver.FindElements(By.CssSelector("body > main > div > div > table > tbody > tr > td"));
        public IReadOnlyCollection<IWebElement> ListOfBoards =>
            driver.FindElements(By.CssSelector("body > main > div > div"));

        public string[] GetAllTasks()
        {
            var tasks = ListOfTasks
                .Select(t => t.Text)
                .ToArray();
            return tasks;
        }
    }
}
