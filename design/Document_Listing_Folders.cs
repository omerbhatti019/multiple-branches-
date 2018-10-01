using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture]
    [Parallelizable]    
    public class Document_Listing_Folders : General_Methods
    {
        #region All Methods 

        /// <summary>
        /// Test all methods of folder class
        /// </summary>
        [Test]
        public void AllFolderOprations()
        {
            try
            {
                //Add folder
                AddFolderPrivate();

                //Update folder name
                EditFolderPrivate();

                //Delete folder
                DeleteFolderPrivate();
                
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Public Methods
        
        /// <summary>
        /// Add new folder
        /// </summary>
        [Test]
        public void AddFolder()
        {
            try
            {
                AddFolderPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        /// <summary>
        /// Update folder
        /// </summary>
        [Test]
        public void EditFolder()
        {
            try
            {
                EditFolderPrivate();

                // Log the test case result
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        
        /// <summary>
        /// Delete folder
        /// </summary>
        [Test]
        public void DeleteFolder()
        {
            try
            {
                DeleteFolderPrivate();

                // Log the test case result
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        
        #endregion

        #region Private Methods

        /// <summary>
        /// Add new folder
        /// </summary>
        void AddFolderPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000); 

                //Click on add folder button
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Folder_Icon_CssSelector)).Click();

                //Add folder name
                FindElement(driver, By.CssSelector(Elements_Paths.FolderName_TextField_CssSelector)).SendKeys(TestData.Folder_Name);

                //Save folder name
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Add folder activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Folder_Add_Activity, AddIntegrationActivity.Text);

                // Log the test case result
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        /// <summary>
        /// Update folder
        /// </summary>
        void EditFolderPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();

                //Open folder options box          
                FindElement(driver, By.XPath(Elements_Paths.Folder_Options_XPath)).Click();

                //Click on Update folder name option
                FindElement(driver, By.XPath(Elements_Paths.Folder_Name_Update_XPath)).Click();

                //Update folder name
                FindElement(driver, By.CssSelector(Elements_Paths.FolderName_TextField_CssSelector)).SendKeys(TestData.Folder_Name_Update);

                //Update folder
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit folder activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Folder_Edit_Activity, AddIntegrationActivity.Text);

                // Log the test case result
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        void DeleteFolderPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Open folder options box          
                FindElement(driver, By.XPath(Elements_Paths.Folder_Options_XPath)).Click();

                //Click on delete option 
                FindElement(driver, By.XPath(Elements_Paths.Folder_Delete_XPath)).Click();

                //Delete folder
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Folder_Delete_Success_Message, ToasterMessage.Text);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Delete Folder activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Folder_Delete_Activity, AddIntegrationActivity.Text);

                // Log the test case result
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion
    }
}
