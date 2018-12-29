/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
using System.Collections.ObjectModel;

namespace SeleniumRecipes
{

    [TestClass]
    public class LocatorTest
    {

        static IWebDriver driver = new ChromeDriver("C:/Users/Monicca2502/Downloads/Software/chromedriver_win32");

        //static IWebDriver driver = new EdgeDriver();

        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {
        }

        [TestInitialize]
        public void Before()
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl() + "/locators.html");
        }

        [TestCleanup]
        public void AfterEach()
        {
        }

        /// <summary>
        ///Cleanup() is called once during test execution after
        ///</summary>
        [ClassCleanup]
        public static void AfterAll()
        {
            //driver.Quit();
        }


        [TestMethod]
        public void testByID()
        {
            driver.FindElement(By.Id("submit_btn")).Click();
        }

        [TestMethod]
        public void testByName()
        {
            driver.FindElement(By.Name("comment")).SendKeys("Selenium Cool");
        }

        [TestMethod]
        public void testByLinkedText()
        {
            driver.FindElement(By.LinkText("Cancel")).Click();
        }


        [TestMethod]
        public void testByPartialLinkedText()
        {
            // will click the "Cancel" link
            driver.FindElement(By.PartialLinkText("ance")).Click();
        }

        [TestMethod]
        public void testByXPath()
        {
            //driver.FindElement(By.XPath("//*[@id='div2']/input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//*[@id='div2']/input")).Click();
            //*[@id="div2"]/input
            //*[@id="div2"]
        }

        [TestMethod]
        public void testByTag()
        {
            Assert.IsTrue(driver.FindElement(By.TagName("h2")).Text.Contains("Selenium Locators"));
        }


        [TestMethod]
        public void testByClassName()
        {
            //driver.FindElement(By.ClassName("btn-default")).Click();
            //System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("btn")).Click();

            // the below will return error "Compound class names not permitted"
            // driver.FindElement(By.className("btn btn-deault btn-primary")).Click()
        }

        [TestMethod]
        public void testByCSSSelector()
        {
            driver.FindElement(By.CssSelector("#div2 > input[type='checkbox']")).Click();

        }

        [TestMethod]
        public void testFindMultipleElements()
        {
            ReadOnlyCollection<IWebElement> checkbox_elems = driver.FindElements(By.XPath("//div[@id='container']//input[@type='checkbox']"));
            System.Console.WriteLine(checkbox_elems); // => 2
            checkbox_elems[1].Click();
        }

        [TestMethod]
        public void TestChainFindElement()
        {
            driver.FindElement(By.Id("div2")).FindElement(By.Name("same")).Click();
        }

    }
}

    /*internal class chromeDriver : IWebDriver
    {
        private string v;

        public chromeDriver(string v)
        {
            this.v = v;
        }

        public string CurrentWindowHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string PageSource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ReadOnlyCollection<string> WindowHandles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }
    }
}*/