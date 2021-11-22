using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WEB_Automation_Homework
{
    public class Tests: WebDriver
    {
        private Signin accountSignin = new Signin();
        private Homepage homePage = new Homepage();
        private Search search = new Search();
        private Checkout checkout = new Checkout();

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(); 
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void SignIn()
        {
            accountSignin.ClicSigninBtn();
            homePage.DoSigninProcess();
            IWebElement logout = Driver.FindElement(By.LinkText("Sign out"));
            Assert.AreEqual("Sign out", logout.Text, "Error message: button is not visible on the page");
        }

        [Test]
        public void SearchSomething()
        {
            accountSignin.ClicSigninBtn();
            homePage.DoSigninProcess();
            search.DoSearchProcess();
            IWebElement AddtoCartBTN = Driver.FindElement(By.LinkText("Add to cart"));
            Assert.AreEqual("Add to cart", AddtoCartBTN.Text, "Error message: button is not visible on the page");
        }

        [Test]
        public void BuyItem()
        {
            accountSignin.ClicSigninBtn();
            homePage.DoSigninProcess();
            search.DoSearchProcess();
            IWebElement AddToCart = Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default > span"));
            AddToCart.Click();
            checkout.Buy();
            IWebElement OrderComplete = Driver.FindElement(By.LinkText("Back to orders"));
            Assert.AreEqual("Back to orders", OrderComplete.Text, "Error message: text is not visible on the page");

        }
    }
}