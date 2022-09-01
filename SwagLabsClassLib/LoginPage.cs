using System;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;


namespace SwagLabsClassLib
{
    public class LoginPage
    {

        private IWebDriver _driver;
        
        //username TextBox
        [FindsBy(How=How.Id, Using="user-name")]
        private IWebElement _username;
         //Password TextBox
        [FindsBy(How=How.Id, Using="password")]
        private IWebElement _password;
         //LogIn button

       
        [FindsBy(How=How.Id, Using="login-button")]
        private IWebElement _loginbutton;


        public LoginPage(IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }

         public void username(string uname){

        _username.Clear();
        _username.SendKeys(uname);

        }
         public void password(string upassword){

        _password.Clear();
        _password.SendKeys(upassword);

        }


         public void loginbutton(){

            _loginbutton.Click();
        }

    }
}