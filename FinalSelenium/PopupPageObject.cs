using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace FinalSelenium
{
    class PopupPageObject
    {
        public PopupPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='details']/div[1]/p/a")]
        public IWebElement HTMLPopUp { get; set; }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddltitle { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement rbGender { get; set; }

        [FindsBy(How = How.Name, Using = "Country")]
        public IWebElement ddlCountry { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        


        public void FillInPopUp(string title, string initial, string firstname, string middleName, string lastName, string country)
        {
            HTMLPopUp.ClickElement();           

            foreach (String window in PropertyCollection.driver.WindowHandles)
            {
                string childWindow = PropertyCollection.driver.SwitchTo().Window(window).ToString();
                PropertyCollection.driver.SwitchTo().Window(window);
            }
            
            ddltitle.SelectDropDown(title);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstname);    
            txtMiddleName.EnterText(middleName);
            txtLastName.EnterText(lastName);            
            rbGender.ClickElement();            
            ddlCountry.SelectDropDown(country);
            btnSave.ClickElement();            
        }
    }
}
