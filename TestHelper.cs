using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumRecipes
{
    public class TestHelper
    {

        public static String SiteUrl() {
            // change to your installed location
            //return "file:///C:/agileway/books/SeleniumRecipes-C%23/site";
            return "C:\\Users\\Monicca2502\\Downloads\\Software\\Selenium\\SeleniumWebDriverRecipesinCSharpSecondEdition\\9781484217412\\site";
        }

        // change to yours
        public static String ScriptDir()
        {
            //return @"C:\agileway\books\SeleniumRecipes-C#\recipes";
            return @"C:\Users\Monicca2502\Downloads\Software\SeleniumWebDriverRecipesinCSharpSecondEdition\9781484217412\selenium-recipes-source";
        }

        public static String TempDir()
        {
            return "C:\\temp";
        }

    }
}
