using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class GoogleSearchChrome  {

  public static void main(String[] args) {

    IWebDriver driver = new ChromeDriver();

    // And now use this to visit GoogleC:\Users\Monicca2502\Downloads\Software\Selenium WebDriver Recipes in CSharp Second Edition\9781484217412\selenium-recipes-source\SeleniumRecipes\ch01_introduction\GoogleSearchChrome.cs
    driver.Navigate().GoToUrl("http://www.google.com");

    // Find the text input element by its name
    IWebElement element = driver.FindElement(By.Name("q"));
    
    // Enter something to search for
    element.SendKeys("Hello Selenium WebDriver!");

    // Now submit the form. WebDriver will find the form for us from the element
    element.Submit();

    // Check the title of the page
    Console.WriteLine("Page title is: " + driver.Title);
	
	//driver.Quit();
  }
}