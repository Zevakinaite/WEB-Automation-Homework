using OpenQA.Selenium;

namespace WEB_Automation_Homework
{
    internal class Homepage: WebDriver
    {
        private IWebElement GetEmailField()
        { return Driver.FindElement(By.Id("email")); }

        private IWebElement GetPaswordField()
        { return Driver.FindElement(By.Id("passwd")); }

        private IWebElement GetLoginButton()
        {
            return Driver.FindElement(By.Name("SubmitLogin"));
        }

        public void DoSigninProcess()
        {
            GetEmailField().SendKeys("abcabc@abc.lt"); //enter sign in email
            GetPaswordField().SendKeys("slaptazodis123"); //enter sign in password
            GetLoginButton().Click();
        }

    }
}
