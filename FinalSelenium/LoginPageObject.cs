using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FinalSelenium;


namespace FinalSelenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        #region (Elements)

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        #endregion

        public void Login(string userName, string password)
        {
            txtUsername.EnterText(userName);
            txtPassword.EnterText(password);
            btnLogin.ClickElement();
        }
    }
}
