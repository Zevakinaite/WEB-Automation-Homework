using OpenQA.Selenium;

namespace WEB_Automation_Homework
{
    internal class Search: WebDriver
    {
        private IWebElement GetSearchField()
        { return Driver.FindElement(By.Id("search_query_top")); }
        private IWebElement GetSearchButton()
        { return Driver.FindElement(By.Name("submit_search")); }

        public void DoSearchProcess()
        {
            GetSearchField().SendKeys("Dress"); //Enter search value
            GetSearchButton().Click();
        }
    }
}
