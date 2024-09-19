using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Serilog;
using TechTalk.SpecFlow;

namespace BDD_TastyNibbles.Hooks
{
    [Binding]
    public sealed class AllHooks
    {
        public static IWebDriver? driver;

        [BeforeFeature]
        public static void InitializeBrowser()
        {
            driver = new ChromeDriver();
        }

        [BeforeFeature]
        public static void LogFileCreation()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/logs_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }

        [AfterFeature]
        public static void CleanUp()
        {
            driver?.Quit();
        }

        [AfterScenario]
        public static void NavigateToHomePage()
        {
            driver?.Navigate().GoToUrl("https://www.tastynibbles.in/");
        }

    }
}