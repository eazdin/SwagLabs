using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

using SwagLabsClassLib;


namespace SwagLabsClassTest
{
    [TestClass]
    public class SwagTest

     
    {
        IWebDriver driver;
        [TestInitialize]

        public void startBrowser()

        {
           SwagLabsClassLib.MultiBrowsers Browser = new SwagLabsClassLib.MultiBrowsers(driver);
            Browser.Browser("CH");

            driver = new ChromeDriver(@"C:\mitra c#\WebDriver");
            driver.Navigate().GoToUrl(SwagLabsClassLib.Program.SwagLabUrl);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            } 

         public void LoginDetails(string users, string pass)
       
        {
            LoginPage log =new LoginPage(driver);
            log.username(users);
            log.password(pass);
            log.loginbutton();

            string actualPageTitle =log.pagetitle();
            string expectedPageTitle ="Swag Labs";
            Assert.AreEqual(expectedPageTitle,actualPageTitle,"Title Not Match");
        


        }

         [TestMethod]
         
        public void productpage(){

            LoginPage log =new LoginPage(driver);
            log.username("standard_user");
            log.password("secret_sauce");
            log.loginbutton();
           
           
            SwagLabClassLib.ProductsPage products =new SwagLabClassLib.ProductsPage(driver);
            
            products.backpackcart();
            products.bikelightcart();
            products.cartlink();
            
            
            SwagLabsClassLib.YourCartPage YCpage =new SwagLabsClassLib.YourCartPage(driver);
            
            
            string actual =YCpage.SauceLabsBackpack();
            string expectedname ="Sauce Labs Backpack";
            Assert.AreEqual(expectedname,actual,"method fail");
            YCpage.SauceLabsBackpack();

            string actual1 =YCpage.SauceLabsBikeLight();
            string expectedname1 ="Sauce Labs Bike Light";
            Assert.AreEqual(expectedname1,actual1,"method fail");
            YCpage.SauceLabsBikeLight();

            YCpage.CheckOut();

            SwagLabsClassLib.CheckOutPage COpage =new SwagLabsClassLib.CheckOutPage(driver);
            COpage.FirstName("mitra");
            COpage.LastName("patra");
            COpage.PostalCode("50049");
            COpage.Continue();
            COpage.Finish();
            

            SwagLabsClassLib.BackHomePage HPpage =new SwagLabsClassLib.BackHomePage(driver);
            HPpage.BackHome();
            
             }



        [DataTestMethod]
         [Ignore]
        public void YourCartPage()
        {
            SwagLabsClassLib.YourCartPage YCpage =new SwagLabsClassLib.YourCartPage(driver);
            YCpage.CheckOut();
        }

         [DataTestMethod]
         [Ignore]
         [DataRow("mitra","patra","50049")]
          
        public void CheckOut_(string Fname, string Lname, string Pin)
        {
            SwagLabsClassLib.CheckOutPage COpage =new SwagLabsClassLib.CheckOutPage(driver);
            COpage.FirstName(Fname);
            COpage.LastName(Lname);
            COpage.PostalCode(Pin);
            COpage.Continue();
             
            string actual5 =COpage.SauceLabsBackpack();
            string expectedname ="Sauce Labs Backpack";
            Assert.AreEqual(expectedname,actual5,"method fail");
            COpage.SauceLabsBackpack();

            string actual6 =COpage.SauceLabsBikeLight();
            string expectedname1 ="Sauce Labs Bike Light";
            Assert.AreEqual(expectedname1,actual6,"method fail");
            COpage.SauceLabsBikeLight();

            COpage.Finish();
        }

           [DataTestMethod]
         [Ignore]
        public void BackHomePage()
        {
            SwagLabsClassLib.BackHomePage HPpage =new SwagLabsClassLib.BackHomePage(driver);
            HPpage.BackHome();
        }


         [TestMethod]
        
        public void locked_out_user(){

            LoginPage log =new LoginPage(driver);
            log.username(SwagLabsClassLib.Program.lockedoutuser);
            log.password(SwagLabsClassLib.Program.password);
            log.loginbutton();

            string actual4 =log.locked_out_user();
            string expectedname4 ="Epic sadface: Sorry, this user has been locked out.";
            Assert.AreNotEqual(expectedname4,actual4,"method fail");
            log.locked_out_user();
          
        }
        [TestMethod]
         
        public void problemuser(){

            LoginPage log =new LoginPage(driver);
            log.username(SwagLabsClassLib.Program.problemuser);
            log.password(SwagLabsClassLib.Program.password);
            log.loginbutton();
        SwagLabClassLib.ProductsPage products =new SwagLabClassLib.ProductsPage(driver);
            string actualbackpackimg =products.puserbackpackimage();
            string expectedbackpackimg = "/static/media/sauce-backpack-1200x1500.34e7aa42.jpg";
            Assert.AreNotEqual(expectedbackpackimg,actualbackpackimg,"problem user image doesnot match");


        }

          [TestMethod]
           
        public void performance_glitch_user(){

            LoginPage log =new LoginPage(driver);
            log.username(SwagLabsClassLib.Program.performanceglitchuser);
            log.password(SwagLabsClassLib.Program.password);
            log.loginbutton();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        SwagLabClassLib.ProductsPage products =new SwagLabClassLib.ProductsPage(driver);
            
            products.backpackcart();
            products.bikelightcart();
            products.cartlink();
            

        }  

        [TestMethod]
        
        public void Dropdown(){
            LoginPage log =new LoginPage(driver);
            log.username("standard_user");
            log.password("secret_sauce");
            log.loginbutton();
        SwagLabClassLib.ProductsPage products =new SwagLabClassLib.ProductsPage(driver);
        
            products.Dropdown();
         
        } 

        [TestCleanup]
         
        public void Cleanup()
        {
            driver.Quit();
        }
    }
        
}

