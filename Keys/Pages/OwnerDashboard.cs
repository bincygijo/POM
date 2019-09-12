using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    public class OwnerDashboard
    {
        public void Property_Owner_Dashboard()
        {
            //Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Owner_Dashboard");

            try
            {

            //navigate to Owner Dashboard
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
            Thread.Sleep(2000);

            //Click on quick button "Add Finance Details"
            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
            //Thread.Sleep(2000);

            //Click on quick button "Add New Tenant"
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
            Thread.Sleep(2000);

            //Select Property
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
            Thread.Sleep(2000);

            //Enter Tenant Email
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(6, "Email"));
            Thread.Sleep(1000);

            //Select is if main tenant or not
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
            Thread.Sleep(2000);

            //Enter First Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(8, "FirstName"));
            Thread.Sleep(1000);

            //Enter Last Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(9, "LastName"));
            Thread.Sleep(1000);

            // Rent Start Date  
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
            Thread.Sleep(2000);

            //Rent End Date
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
            Thread.Sleep(2000);


            //Rent Amount
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(12, "Rent Amount"));
            Thread.Sleep(1000);

            //Payment Frequency
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
            Thread.Sleep(2000);

            //Payment Start Date
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"));
            Thread.Sleep(2000);

            //Payment Due Date
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
            Thread.Sleep(2000);

            //Click on Next Button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"));
            Thread.Sleep(2000);

            //Add New Liablity
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));
            Thread.Sleep(2000);

            //Bond
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"));
            Thread.Sleep(2000);

            //Amount
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(19, "Rent Amount"));
            Thread.Sleep(1000);

            //Save Button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
            Thread.Sleep(2000);

            //Next Button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"));
            Thread.Sleep(4000);

            //Submit Button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));
            Thread.Sleep(4000);

            //Cancel Button
            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));
            //Thread.Sleep(2000);



             }

             catch (Exception e)

            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message);
             }
        }
    }
}

