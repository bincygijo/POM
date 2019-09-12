using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Global
{
    class Login
    {
        #region
        //// Initializing the web elements 
        //internal Login()
        //{
        //    PageFactory.InitElements(Driver.driver, this);
        //}

        //// Finding the Email Field
        //[FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        //private IWebElement Email { get; set; }

        //// Finding the Password Field
        //[FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        //private IWebElement PassWord { get; set; }

        //// Finding the Login Button
        //[FindsBy(How = How.XPath, Using = "//*[@id='login-form']/div[2]/button")]
        //private IWebElement loginButton { get; set; }
        #endregion
        public static int LoginBase = Int32.Parse(KeysResource.Login);

        internal void LoginSuccessfull()
        {
            
                // Populating the data from Excel
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Login");

                // Navigating to Login page using value from Excel
                Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

                // Sending the username 
                //Email.SendKeys(ExcelLib.ReadData(2, "Email"));
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "InputValue"));
                Driver.wait(5);
                 // Sending the password
              //  PassWord.SendKeys(ExcelLib.ReadData(2, "Password"));
              Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"), ExcelLib.ReadData(3, "InputValue"));

                // Clicking on the login button
                // loginButton.Click();
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));

            //Thread.Sleep(2000);
               //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "User is logged in successfully");
                        
        }


    }
}
