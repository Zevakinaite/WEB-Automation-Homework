using OpenQA.Selenium;

namespace WEB_Automation_Homework
{
    internal class Signin: WebDriver
    {
        private IWebElement GetSigninButton()
        {
            return Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
        }
        public void  ClicSigninBtn()
        {
            GetSigninButton().Click();
        }
    }
}
