using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;


namespace SwagLabsClassLib
{
     public class MultiBrowsers
    {
         private IWebDriver driver;
    
      public  MultiBrowsers(IWebDriver driver)
        {
             this.driver =driver;
        }
         public  IWebDriver Browser(string browser)

        {

            if (browser=="FF")
            {
                driver = new FirefoxDriver(@"C:\mitra c#\WebDriver");
            }
            else if (browser=="CH")
            {
                 driver = new ChromeDriver(@"C:\mitra c#\WebDriver");
            }
            else
            {
                driver = new EdgeDriver(@"C:\mitra c#\WebDriver");
            }
            return driver;
}
    }
}
