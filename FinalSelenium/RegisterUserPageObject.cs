using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FinalSelenium
{
    class RegisterUserPageObject
    {
        public RegisterUserPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        #region Elements

        [FindsBy(How = How.Name, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement txtFemale { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement txtHindi { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/div[1]/p/a")]
        public IWebElement lnkHTMLPopup { get; set; }

        [FindsBy(How = How.Name, Using = "generate")]
        public IWebElement btnGenerate { get; set; }

        #endregion

        public void RegisterNewUser(string title, string initial, string firstName, string middleName)
        {
            ddlTitleId.SelectDropDown(title);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            txtFemale.ClickElement();
            txtHindi.ClickElement();

            Console.WriteLine(GetMethods.GetDDLValue(ddlTitleId));
            Console.WriteLine(GetMethods.GetText(txtInitial));
            Console.WriteLine(GetMethods.GetText(txtFirstName));
            Console.WriteLine(GetMethods.GetText(txtMiddleName));
            Console.WriteLine(GetMethods.GetText(txtFemale));
            Console.WriteLine(GetMethods.GetText(txtHindi));
        }



    }
}
