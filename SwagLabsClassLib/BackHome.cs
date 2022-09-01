using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsClassLib
{
    public class BackHomePage
    {
         private IWebDriver _driver;


        
        [FindsBy(How= How.Id, Using="back-to-products")]
        private IWebElement _BackHome;

        public BackHomePage (IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }

          public void BackHome(){

        _BackHome.Click();
        }
    }
}