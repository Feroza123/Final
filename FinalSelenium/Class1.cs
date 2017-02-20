using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace FinalSelenium
{
    public class Class1
    {
        [SetUp]
        public void Setup()
        {
            PropertyCollection.driver = new ChromeDriver();
            //PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            //PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");      
        }

        [TearDown]
        public void Teardown()
        {
            PropertyCollection.driver.Close();
            PropertyCollection.driver.Quit();
        }

        [Test]
        public void TestOne()
        {
            LoginPageObject userlogin = new LoginPageObject();
            userlogin.Login("abc", "abc");       
        }

        [Test]
        public void RegisterUser()
        {
            PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            RegisterUserPageObject regUser = new RegisterUserPageObject();
            regUser.RegisterNewUser("Mr.", "Q", "Feroz", "Ally");            
        }

        [Test]
        public void FillInPop()
        {
            PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            string parentWindow = PropertyCollection.driver.CurrentWindowHandle;

            PopupPageObject popup = new PopupPageObject();
            popup.FillInPopUp("Mr.", "A", "B", "C", "D", "India");

            PropertyCollection.driver.SwitchTo().Window(parentWindow);

            RegisterUserPageObject regUser = new RegisterUserPageObject();
            regUser.RegisterNewUser("Mr.", "Q", "Feroz", "Ally");

            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void AlertTest()
        {
            PropertyCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");

            RegisterUserPageObject regAlert = new RegisterUserPageObject();

            regAlert.btnGenerate.Click();

            IAlert ia = PropertyCollection.driver.SwitchTo().Alert();

            ia.Accept();
            Assert.AreEqual("You pressed OK!", ia.Text);

            System.Threading.Thread.Sleep(3000);

            IAlert ia2 = PropertyCollection.driver.SwitchTo().Alert();
            ia2.Accept();

            System.Threading.Thread.Sleep(3000);

        }

    }
}
