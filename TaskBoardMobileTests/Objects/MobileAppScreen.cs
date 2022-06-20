using OpenQA.Selenium.Appium.Android;

namespace TaskBoardMobileTests.Objects
{
    public class MobileAppScreen
    {
        private readonly AndroidDriver<AndroidElement> driver;

        public MobileAppScreen(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public AndroidElement TextBoxConnectToAPI =>
            driver.FindElementById("taskboard.androidclient:id/editTextApiUrl");
        public AndroidElement ButtonConnect =>
            driver.FindElementById("taskboard.androidclient:id/buttonConnect");
        public AndroidElement TextBoxKeywordSearching =>
            driver.FindElementById("taskboard.androidclient:id/editTextKeyword");
        public AndroidElement ButtonSearch =>
            driver.FindElementById("taskboard.androidclient:id/buttonSearch");
        public AndroidElement ButtonAdd =>
            driver.FindElementById("taskboard.androidclient:id/buttonAdd");
        public AndroidElement TextBoxAddNewTaskTitle =>
            driver.FindElementById("taskboard.androidclient:id/editTextTitle");
        public AndroidElement ButtonCreate =>
            driver.FindElementById("taskboard.androidclient:id/buttonCreate");
        public IReadOnlyCollection<AndroidElement> ElementTaskTitle =>
            driver.FindElementsById("taskboard.androidclient:id/textViewTitle");

        public void ConnectToAPI(string apiUrl)
        {
            TextBoxConnectToAPI.Clear();
            TextBoxConnectToAPI.SendKeys(apiUrl);

            ButtonConnect.Click();
        }
        public void SearchForTask(string text)
        {
            TextBoxKeywordSearching.Clear();
            TextBoxKeywordSearching.SendKeys(text);

            ButtonSearch.Click();
        }
        public void AddNewTask(string text)
        {
            ButtonAdd.Click();
            TextBoxAddNewTaskTitle.SendKeys(text);
            ButtonCreate.Click();
        }
        public string[] GetAllTasks()
        {
            var tasks = ElementTaskTitle
                .Select(t => t.Text)
                .ToArray();
            return tasks;
        }
    }
}
