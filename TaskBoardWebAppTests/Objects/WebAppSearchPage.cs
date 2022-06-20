using OpenQA.Selenium;

namespace TaskBoardWebAppTests.Objects
{
    public class WebAppSearchPage : WebAppBasePage
    {
        public WebAppSearchPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://taskboard.nakov.repl.co/tasks/search";

        public IWebElement TextBoxKeyword =>
            driver.FindElement(By.Id("keyword"));
        public IWebElement ButtonSearch =>
            driver.FindElement(By.Id("search"));
        public IReadOnlyCollection<IWebElement> ListOfTasks => driver
            .FindElements(By.CssSelector("#task2 > tbody > tr > td"));
        public IWebElement ElementTaskMatchingKeyword =>
            driver.FindElement(By.CssSelector("body > main > h1"));
        public IWebElement ElementSearchResult =>
            driver.FindElement(By.Id("searchResult"));

        public void SearchTask(string keyword)
        {
            TextBoxKeyword.Clear();
            TextBoxKeyword.SendKeys(keyword);
            ButtonSearch.Click();
        }
        public string[] GetAllTasks()
        {
            var tasks = ListOfTasks
                .Select(t => t.Text)
                .ToArray();
            return tasks;
        }
    }
}
