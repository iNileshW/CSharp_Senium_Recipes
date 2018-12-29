

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace SeleniumRecipes
{

    [TestClass]
    public class ButtonTest
    {

        static IWebDriver driver = new ChromeDriver("C:/Users/Monicca2502/Downloads/chromedriver_win32");

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {
        }

        [TestInitialize]
        public void Before()
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl() + "/button.html");
        }

        [TestMethod]
        public void TestClickButtonContainsValue()
        {
            //driver.FindElement(By.XPath("//button[contains(text(),'Choose Selenium')]")).Click();
            driver.FindElement(By.XPath("//*[@id='container']/div[1]/form/input[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='container']/div[1]/form/input[2]")).Click();
            //*[@id="choose_selenium_btn"]
        }

        [TestMethod]
        public void TestClickButtonByExactText()
        {
            // the below will fail, as value contains space characters
            // browser.find_element(:xpath, "//input[@value='Space After']").Click
            driver.FindElement(By.XPath("//input[@value='Space After ']")).Click();
        }

        [TestMethod]
        public void TestClickButtonByID()
        {
            // <button id="choose_selenium_btn" class="nav" data-id="123" style="font-size: 14px;">Choose Selenium</button><
            driver.FindElement(By.Id("choose_selenium_btn")).Click();
        }

        [TestMethod]
        public void TestSubmitForm()
        {
            IWebElement element = driver.FindElement(By.Name("user"));
            element.Submit();
            //driver.FindElement(By.Name("user")).Submit();
            //element.Submit();
        }

        [TestMethod]
        public void TestClickSubmitButton()
        {
            // <input type="submit" name="submit_action" value="Submit">
            driver.FindElement(By.Name("submit_action")).Click();
        }

        [TestMethod]
        public void TestClickImageButton()
        {
            //<input type="image" src="images/button_go.gif">
            //driver.FindElement(By.XPath("//input[contains(@src, 'button_go.jpg')]")).Click();
            driver.FindElement(By.XPath("//*[@id='container']/div[2]/form/input")).Click();
            //*[@id="container"]/div[2]/form/input
        }

        [TestMethod]
        public void TestClickButtonViaJavaScript()
        {
            IWebElement the_btn = driver.FindElement(By.Id("choose_selenium_btn"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", the_btn);
        }

        [TestMethod]
        public void TestVerifyButtonDisplayedOrHidden() 
        {
            Assert.IsTrue(driver.FindElement(By.Id("choose_selenium_btn")).Displayed);
            driver.FindElement(By.LinkText("Hide")).Click();

            System.Threading.Thread.Sleep(500);

            Assert.IsFalse(driver.FindElement(By.Id("choose_selenium_btn")).Displayed);
            driver.FindElement(By.LinkText("Show")).Click();
            System.Threading.Thread.Sleep(500);
            Assert.IsTrue(driver.FindElement(By.Id("choose_selenium_btn")).Displayed);
        }


        [TestMethod]
        public void TestVerifyButtonEnabledOrDisabled()
        {
            Assert.IsTrue(driver.FindElement(By.Id("choose_selenium_btn")).Enabled);
            driver.FindElement(By.LinkText("Disable")).Click();
            System.Threading.Thread.Sleep(500);
            Assert.IsFalse(driver.FindElement(By.Id("choose_selenium_btn")).Enabled);
            driver.FindElement(By.LinkText("Enable")).Click();
            System.Threading.Thread.Sleep(500);
            Assert.IsTrue(driver.FindElement(By.Id("choose_selenium_btn")).Enabled);
        }

        [TestMethod]
        public void TestEnabledButtonUsingJS()
        {
            IWebElement aBtn = driver.FindElement(By.Id("choose_selenium_btn"));
            Assert.IsTrue(aBtn.Enabled);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].disabled = true;", aBtn);
            Assert.IsFalse(driver.FindElement(By.Id("choose_selenium_btn")).Enabled);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].disabled = false;", aBtn);
            Assert.IsTrue(driver.FindElement(By.Id("choose_selenium_btn")).Enabled);

        }

        [TestCleanup]
        public void After()
        {
        }

        [ClassCleanup]
        public static void AfterAll()
        {
//  driver.Quit();
        }
    }

}