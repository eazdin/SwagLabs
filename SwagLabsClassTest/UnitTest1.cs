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
    public class UnitTest1

     
    {
        IWebDriver driver;
        [TestInitialize]
        public void start_Browser()
        {
            driver = new ChromeDriver (@"C:\mitra c#\WebDriver");
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            
        }

        [DataTestMethod]
         [Ignore]
        [DataRow("standard_user","secret_sauce")]
        [DataRow("locked_out_user","secret_sauce")]
        [DataRow("problem_user","secret_sauce")]
        [DataRow("performance_glitch_user","secret_sauce")]
        
        public void Login_(string user, string pass)
        {
            LoginPage log =new LoginPage(driver);
            log.username(user);
            log.password(pass);
            log.loginbutton();
        }

         [TestMethod]

        public void productpage(){

            LoginPage log =new LoginPage(driver);
            log.username("standard_user");
            log.password("secret_sauce");
            log.loginbutton();
          SwagLabClassLib.ProductsPage products =new SwagLabClassLib.ProductsPage(driver);
            Thread.Sleep(3000);
            products.backpackcart();
            products.bikelightcart();
            products.cartlink();
            Thread.Sleep(2000);
            
            SwagLabsClassLib.YourCartPage YCpage =new SwagLabsClassLib.YourCartPage(driver);
            Thread.Sleep(2000);
            
            string actual =YCpage.SauceLabsBackpack();
            string expectedname ="Sauce Labs Backpack";
            Assert.AreEqual(expectedname,actual,"method fail");
            YCpage.SauceLabsBackpack();

            string actual1 =YCpage.SauceLabsBikeLight();
            string expectedname1 ="Sauce Labs Bike Light";
            Assert.AreEqual(expectedname1,actual1,"method fail");
            YCpage.SauceLabsBikeLight();

            /*string actual2 =YCpage.FleeceJacket();
            string expectedname2 ="Sauce Labs Fleece Jacket";
            Assert.AreEqual(expectedname2,actual2,"method fail");
            YCpage.FleeceJacket();*/

            YCpage.CheckOut();
            SwagLabsClassLib.CheckOutPage COpage =new SwagLabsClassLib.CheckOutPage(driver);
             COpage.FirstName("mitra");
             Thread.Sleep(2000);
            COpage.LastName("patra");
            Thread.Sleep(2000);
            COpage.PostalCode("50049");
            Thread.Sleep(2000);
            COpage.Continue();
            Thread.Sleep(2000);
            COpage.Finish();
            Thread.Sleep(2000);

             SwagLabsClassLib.BackHomePage HPpage =new SwagLabsClassLib.BackHomePage(driver);
            Thread.Sleep(2000);
            HPpage.BackHome();
            Thread.Sleep(2000);

        }

        [DataTestMethod]
        
        public void YourCartPage()
        {
            SwagLabsClassLib.YourCartPage YCpage =new SwagLabsClassLib.YourCartPage(driver);
            YCpage.CheckOut();
        }

         [DataTestMethod]
        
         [DataRow("mitra","patra","50049")]
          
        public void CheckOut_(string Fname, string Lname, string Pin)
        {
            SwagLabsClassLib.CheckOutPage COpage =new SwagLabsClassLib.CheckOutPage(driver);
            COpage.FirstName(Fname);
            COpage.LastName(Lname);
            COpage.PostalCode(Pin);
            COpage.Continue();
            COpage.Finish();
        }

           [DataTestMethod]
        
        public void BackHomePage()
        {
            SwagLabsClassLib.BackHomePage HPpage =new SwagLabsClassLib.BackHomePage(driver);
            HPpage.BackHome();
        }


        [TestCleanup]
        
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}

