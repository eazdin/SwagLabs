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


namespace SwagLabClassLib
{
    public class ProductsPage
    {
         private IWebDriver _driver;
        //sidebar elements
        [FindsBy(How= How.Id, Using="react-burger-menu-btn")]
        private IWebElement _menubtn;
        
        [FindsBy(How= How.Id, Using="inventory_sidebar_link")]
        private IWebElement _allitemslink;
        
        [FindsBy(How= How.Id, Using="logout_sidebar_link")]
        private IWebElement _logoutlink;
        
        [FindsBy(How= How.Id, Using="reset_sidebar_link")]
        private IWebElement _resetlink;
       
        [FindsBy(How= How.Id, Using="react-burger-cross-btn")]
        private IWebElement _crossbtn;

        [FindsBy(How= How.XPath, Using="//span[@class='title']")]
         private IWebElement _products;

        [FindsBy(How= How.Id, Using="item_4_title_link")]
        private IWebElement _backpack;

        [FindsBy(How= How.Id, Using="add-to-cart-sauce-labs-backpack")]
        private IWebElement _backpackcart;

        [FindsBy(How= How.Id, Using="tem_0_title_link")]
        private IWebElement _bikelight;

        [FindsBy(How= How.Id, Using="add-to-cart-sauce-labs-bike-light")]
        private IWebElement _bikelightcart;

      //  [FindsBy(How= How.Id, Using="//*[@id='item_5_title_link']/div")]
       // private IWebElement _FleeceJacket;

      //  [FindsBy(How= How.XPath, Using="//*[@id='add-to-cart-sauce-labs-fleece-jacket']")]
       // private IWebElement _Jacketcart;
        
        public ProductsPage(IWebDriver driver)
        {

            _driver =driver;

        PageFactory.InitElements(_driver,this);
         }
        
        
       //cart link
        [FindsBy(How= How.Id, Using="shopping_cart_container")]
        private IWebElement _cartlink;

        
        [FindsBy(How= How.ClassName, Using="product_sort_container")]
        private IWebElement _sortdropdown;
        
    

        public void menubtn(){

            _menubtn.Click();
        }

        public void allitemslink(){

            _allitemslink.Click();
        }

        public void logoutlink(){

             _logoutlink.Click();
        }

        public void resetlink(){

           _resetlink.Click();
        }
        public void crossbtn(){

            _crossbtn.Click();
        }

        public void cartlink(){

            _cartlink.Click();
        }

          public void backpack()
        {
        _backpack.Click();
        }
        public void backpackcart()
        {
        _backpackcart.Click();
        }
        public void bikelight()
        {
        _bikelight.Click();
        }

        public void bikelightcart()
        {
        _bikelightcart.Click();
        }

        /*public void FleeceJacket()
        {
        _FleeceJacket.Click();
        }

         public void Jacketcart()
        {
        _Jacketcart.Click();
        }*/
    }
}