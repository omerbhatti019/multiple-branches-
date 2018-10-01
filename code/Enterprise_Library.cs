//using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationTest
{
    [TestFixture][Parallelizable]
    /// <summary>
    /// Enterprise Library
    /// </summary>
    public class Enterprise_Library : General_Methods
    {
        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Enterprise Library Methods
        [Test]
        public void AllEnterpriseLibrary()
        {
            try
            {
                //Add library document
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Library_ID)))
                {
                    AddEnterpriseDocumentPrivate();

                    //Update library document
                    dashboard.NavigationToEnterpriseSettings();
                    EditEnterpriseDocumentPrivate();

                    //Delete library document
                    dashboard.NavigationToEnterpriseSettings();
                    DeleteEnterpriseDocumentPrivate();

                    //Search library document
                    dashboard.NavigationToEnterpriseSettings();
                    SearchEnterpriseDocumentPrivate();

                    // Validate Enterprise Library Mandatory fields 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateEnterpriseLibraryMandatoryfieldsPrivate();

                    //Add library document for next test cases 
                    dashboard.NavigationToEnterpriseSettings();
                    AddEnterpriseDocumentPrivate();

                    //Navigate to enterprise settings
                    dashboard.NavigationToEnterpriseSettings();

                    //Update settings in role
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Library_CheckBox_ID);

                    //Validate add document
                    ValidateAddLibararyDocumentPrivate();

                    //Validate Update document
                    EditEnterpriseDocumentPrivate();

                    //Validate delete document
                    DeleteEnterpriseDocumentPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Library_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion 

        #region Add Enterprise Documents in Library.
        [Test]
        public void AddEnterpriseDocument()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddEnterpriseDocumentPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit Enterprise Document.
        [Test]
        public void EditEnterpriseDocument()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditEnterpriseDocumentPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }
        #endregion

        #region Delete Enterprise Document.
        [Test]
        public void DeleteEnterpriseDocument()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteEnterpriseDocumentPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Search Enterprise Document.
        [Test]
        public void SearchEnterpriseDocument()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                SearchEnterpriseDocumentPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region  Validate Enterprise Library Mandatory fields  
        [Test]
        public void ValidateEnterpriseLibraryMandatoryfields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateEnterpriseLibraryMandatoryfieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate add document 
        /// <summary>
        /// Validate security checks while add library document
        /// </summary>
        [Test]
        public void ValidateAddLibararyDocument()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Library_CheckBox_ID);

                //Validate add document
                ValidateAddLibararyDocumentPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Update document 
        /// <summary>
        /// Validate security checks while update library document
        /// </summary>
        [Test]
        public void ValidateUpdateLibararyDocument()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Library_CheckBox_ID);

                //Validate Update document
                EditEnterpriseDocumentPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Delete document 
        /// <summary>
        /// Validate security checks while Delete library document
        /// </summary>
        [Test]
        public void ValidateDeleteLibararyDocument()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Library_CheckBox_ID);

                //Validate Delete document
                DeleteEnterpriseDocumentPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Add Enterprise Documents in Library.
        void AddEnterpriseDocumentPrivate()
        {
            try
            {
                //Add document
                AddDocument();

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Upload_Template_Fail_CSS_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    Thread.Sleep(1000);
                    //Clicks on dropdown
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    //clicks on Activity
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                    // Comparison
                    if (!FindElement(driver, By.XPath(Elements_Paths.Activity_Logs_Verify_XPath)).Text.Equals(TestData.Library_AddDocument_Activity_Text))
                        throw new Exception();
                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Edit Enterprise Document.        
        public void EditEnterpriseDocumentPrivate()
        {
            try
            {
                //Click on Library tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Library_ID)).Click();
                //Edit existing document

                //Search for document
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);

                try
                {
                    //Click on edit icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                }
                catch (Exception)
                {
                    //Add new document
                    AddDocument();

                    //Click on edit icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                }

                //Edit Document name
                //clear value in document name
                FindElement(driver, By.Name(Elements_Paths.Library_DocumentNameField_Name)).Clear();
                //Enter New Value
                FindElement(driver, By.Name(Elements_Paths.Library_DocumentNameField_Name)).SendKeys(TestData.Enterprise_Document_Name);
                //click on template dropdown
                FindElement(driver, By.ClassName(Elements_Paths.Library_ApplyTemplateDropDown_ClassName)).Click();
                //select template
                FindElement(driver, By.CssSelector(Elements_Paths.Library_Select_Template_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on SAVE button
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);
                
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    //Clicks on dropdown
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    //clicks on Activity
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    if (!FindElement(driver, By.XPath(Elements_Paths.Activity_Logs_Verify_XPath)).Text.Equals(TestData.Library_EditDocument_Activity_Text))
                        throw new Exception();
                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Delete Enterprise Document.       
        public void DeleteEnterpriseDocumentPrivate()
        {
            try
            {
                //Click on Library tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Library_ID)).Click();
                //Search document from library                
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);

                try
                {
                    //Check checkbox
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                    //Click on delete icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
                }
                catch (Exception)
                {
                    //Add document
                    AddDocument();
                    Thread.Sleep(1000);

                    //Check checkbox
                    FindElement(driver, By.ClassName(Elements_Paths.General_Checkbox_ClassName)).Click();
                    
                    //Click on delete icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();

                }
                
                //Confirmation yes
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1500);

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    //Clicks on dropdown
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    //clicks on Activity
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    if (!FindElement(driver, By.XPath(Elements_Paths.Activity_Logs_Verify_XPath)).Text.Equals(TestData.Library_DeleteDocument_Activity_Text))
                        throw new Exception();
                    //log test method
                    LogTestCase(GetCurrentMethod());
                }

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Search Enterprise Document.

        void SearchEnterpriseDocumentPrivate()
        {
            try
            {

                //Click on Library tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Library_ID)).Click();

                // Enterprise Library
                // Enter Value in search field
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.SearchPersonalLibrary_EnterpriseDocument);
                // Clear value from search field
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while add library document when option no more allowed in role 
        /// <summary>
        /// Validate security checks while add library document when option no more allowed in role
        /// </summary>
        void ValidateAddLibararyDocumentPrivate()
        {
            try
            {
                //Add document in library
                AddDocument();

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Upload_Template_Fail_CSS_Selector)))
                {
                    IWebElement UploadtemplateFail = FindElement(driver, By.CssSelector(Elements_Paths.Upload_Template_Fail_CSS_Selector));

                    //log test case
                    LogTestCase(GetCurrentMethod(), UploadtemplateFail.Text);
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate Enterprise Library Mandatory fields  
        /// </summary>
        void ValidateEnterpriseLibraryMandatoryfieldsPrivate()
        {
            try
            {
                //Click on Library tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Library_ID)).Click();

                //Search template
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);

                //Check if template already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add Library document
                    AddDocument();
                    Thread.Sleep(1000);

                    //Clear search
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                    //Search template
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);
                }

                //Click on edit icon
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                //clear value in document name
                FindElement(driver, By.Name(Elements_Paths.Library_DocumentNameField_Name)).Clear();

                //Click on SAVE button
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)))
                    LogTestCase(GetCurrentMethod(), "Required fields should not save empty.", new Exception());
                else
                    LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region AddDocument

        void AddDocument()
        {
            try
            {
                //Click on Library tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Library_ID)).Click();
                //Upload Dcoument
                //Click on icon
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();
                
                //Upload document
                UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Sample_Upload_Document_Name, 1000);
                
                //Apply template - click on dropdown
                FindElement(driver, By.ClassName(Elements_Paths.Library_ApplyTemplateDropDown_ClassName)).Click();
                //Select value of template from dropdown            
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Library_Select_Template_CSSSelector)).Click();
                //Click on UPLOAD button
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Library_Upload_and_Done_Button_CssSelector)).Click();

                Thread.Sleep(2000);
                //Check no error exist
                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.Upload_Template_Fail_CSS_Selector)))
                {
                    //Click on DONE button                    
                    FindElement(driver, By.CssSelector(Elements_Paths.Library_Upload_and_Done_Button_CssSelector)).Click();
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
    }
}
