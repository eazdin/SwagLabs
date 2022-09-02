using System;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SwagLabsClassLib
{
    public class CheckOutPage
    {
        private IWebDriver _driver;
        
        [FindsBy(How= How.Id, Using="first-name")]
        private IWebElement _FirstName;

        [FindsBy(How= How.Id, Using="last-name")]
        private IWebElement _LastName;

        [FindsBy(How= How.Id, Using="postal-code")]
        private IWebElement _PostalCode;

        [FindsBy(How= How.Id, Using="continue")]
        private IWebElement _Continue;

        [FindsBy(How= How.Id, Using="finish")]
        private IWebElement _Finish;

         [FindsBy(How= How.XPath, Using="//div[contains(text(),'Sauce Labs Backpack')]")]
        private IWebElement _SauceLabsBackpack;

        [FindsBy(How= How.XPath, Using="//*[@id='item_0_title_link']")]
        private IWebElement _SauceLabsBikeLight;

        public CheckOutPage (IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }


        public void FirstName(string Fname){

            _FirstName.SendKeys(Fname);
        }

         public void LastName(string Lname){

            _LastName.SendKeys(Lname);
        }

          public void PostalCode(string Pin){

            _PostalCode.SendKeys(Pin);
        }

         public void Continue(){

            _Continue.Click();
        }

         public void Finish()
         {

            _Finish.Click();
        }

        public string SauceLabsBackpack(){
         string actual5 =  _SauceLabsBackpack.Text;
          return actual5;
         }

         public string SauceLabsBikeLight(){
         string actual6 =  _SauceLabsBikeLight.Text;
          return actual6;
         }


    }
}