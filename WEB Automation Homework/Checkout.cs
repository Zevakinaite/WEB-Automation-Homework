using OpenQA.Selenium;

namespace WEB_Automation_Homework
{
    internal class Checkout: WebDriver
    {
        private IWebElement GotoChart()
        { return Driver.FindElement(By.CssSelector("#header > div:nth-child(3) > div > div > div:nth-child(3) > div > a")); }
        private IWebElement ProceedCheckout1()
        { return Driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium")); }
        private IWebElement ProceedCheckout2()
        { return Driver.FindElement(By.CssSelector("#center_column > form > p > button")); }
        private IWebElement Terms()
        { return Driver.FindElement(By.Id("cgv")); }
        private IWebElement ProceedCheckout3()
        { return Driver.FindElement(By.CssSelector("#form > p > button")); }
        private IWebElement PaybyBank()
        { return Driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a")); }
        private IWebElement Confirm()
        { return Driver.FindElement(By.CssSelector("#cart_navigation > button")); }

        public void Buy()
        {
            GotoChart().Click();
            ProceedCheckout1().Click();
            ProceedCheckout2().Click();
            Terms().Click();
            ProceedCheckout3().Click();
            PaybyBank().Click();
            Confirm().Click();
        }
    }
}
