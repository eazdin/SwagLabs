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
    public class YourCartPage
    {
         private IWebDriver _driver;

        
        [FindsBy(How= How.XPath, Using="//div[contains(text(),'Sauce Labs Backpack')]")]
        private IWebElement _SauceLabsBackpack;

        [FindsBy(How= How.XPath, Using="//*[@id='item_0_title_link']")]
        private IWebElement _SauceLabsBikeLight;

        [FindsBy(How= How.XPath, Using="//*[@id='item_5_title_link']/div")]
        private IWebElement _FleeceJacket;
        
        [FindsBy(How= How.XPath, Using="//button[@id='checkout']")]
        private IWebElement _CheckOut;

        public YourCartPage (IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }

         public string SauceLabsBackpack(){
         string actual =  _SauceLabsBackpack.Text;
          return actual;
         }

         public string SauceLabsBikeLight(){
         string actual1 =  _SauceLabsBikeLight.Text;
          return actual1;
         }

          public void CheckOut(){

        _CheckOut.Click();
        }
    }
}