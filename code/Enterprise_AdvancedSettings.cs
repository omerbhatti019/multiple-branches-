using NUnit.Framework;
using OpenQA.Selenium;
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
    /// Enterprise Advanced Settings.
    /// </summary>
    class Enterprise_AdvancedSettings : General_Methods
    {
        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Enterprise Advanced Settings Methods
        [Test]
        public void AllEnterpriseAdvancedSettings()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)))
                {
                    UpdateDefaultSettingsPrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    AddEnterpriseLegalNoticePrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    EditEnterpriseLegalNoticePrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    DeleteEnterpriseLegalNoticePrivate();

                    //Validate duplicate Add Legal Notice
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddDuplicateLegalNoticePrivate();

                    //Validate duplicate update Legal Notice
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateDuplicateLegalNoticePrivate();

                    //Validate Mandatory fields on Add legal notice
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddEnterpriseLegalNoticeMandatoryFieldsPrivate();

                    //Validate Mandatory fields on Update legal notice
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateEnterpriseLegalNoticeMandatoryFieldsPrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    AddCertificateFiltersPrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    EditCertificateFiltersPrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    DeleteCertificateFiltersPrivate();

                    dashboard.NavigationToEnterpriseSettings();
                    AddSANCertificateFiltersPrivate();

                    //Validate Mandatory fields while add certificate 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateMandatoryFieldsAddCertificatePrivate();

                    //Add Certificate again
                    dashboard.NavigationToEnterpriseSettings();
                    AddCertificateFiltersPrivate();                    

                    dashboard.NavigationToEnterpriseSettings();
                    UpdateAdvancedOthersPrivate();

                    //Validate invalid address not be save while update
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUrlInMorePrivate();

                    //Test URL while update more option
                    TestUrlInMorePrivate();

                    //Remove enterprise account
                    EnterpriseRemoveAccountPrivate();

                    //Validate security checks for advance Tab
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                    //Validate remove enterprise account when advance tab not allowed in role
                    ValidateRemoveEnterpriseAccountPrivate();

                    ValidateAddLegalNoticePrivate();

                    //Validate security checks while update legal notice 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateLegalNoticePrivate();

                    //Validate security checks while delete legal notice 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateDeleteLegalNoticePrivate();

                    //Validate security checks while add certificate  
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddCertificatePrivate();

                    //Validate security checks while update certificate  
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateCertificatePrivate();

                    //Validate security checks while delete certificate  
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateDeleteCertificatePrivate();                    

                    //Validate security checks while update more option 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateOtherOptionsPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Advanced_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region  Update Default Settings
        /// <summary>
        /// Update Advanced Storage Policy.
        /// </summary>
        [Test]
        public void UpdateDefaultSettings()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                UpdateDefaultSettingsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Add Enterprise Legal Notice
        /// <summary>
        /// Add Enterprise Legal Notice.
        /// </summary>
        [Test]
        public void AddEnterpriseLegalNotice()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddEnterpriseLegalNoticePrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit Enterprise Legal Notice
        /// <summary>
        /// Edit Enterprise Legal Notice.
        /// </summary>
        [Test]
        public void EditEnterpriseLegalNotice()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditEnterpriseLegalNoticePrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Delete Enterprise Legal Notice
        /// <summary>
        /// Delete Enterprise Legal Notice.
        /// </summary>
        [Test]
        public void DeleteEnterpriseLegalNotice()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteEnterpriseLegalNoticePrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate duplicate Add Legal Notice.
        /// <summary>
        /// Validate duplicate Add Legal Notice
        /// </summary>
        [Test]
        public void ValidateAddDuplicateLegalNotice()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddDuplicateLegalNoticePrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate duplicate Update Legal Notice.
        [Test]
        public void ValidateUpdateDuplicateLegalNotice()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateDuplicateLegalNoticePrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region  Validate Mandatory fields on Add legal notice
        [Test]
        public void ValidateAddEnterpriseLegalNoticeMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddEnterpriseLegalNoticeMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region  Validate Mandatory fields on Update legal notice
        [Test]
        public void ValidateUpdateEnterpriseLegalNoticeMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateEnterpriseLegalNoticeMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Add Certificate Filters
        /// <summary>
        /// Add Certificate Filters.
        /// </summary>
        [Test]
        public void AddCertificateFilters()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddCertificateFiltersPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit Certificate Filters
        /// <summary>
        /// Edit Certificate Filters.
        /// </summary>
        [Test]
        public void EditCertificateFilters()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditCertificateFiltersPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Delete Certificate Filter
        /// <summary>
        /// Delete Certificate Filters.
        /// </summary>
        [Test]
        public void DeleteCertificateFilters()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteCertificateFiltersPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Add SAN Certificate Filters
        /// <summary>
        /// Add Certificate Filters.
        /// </summary>
        [Test]
        public void AddSANCertificateFilters()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddSANCertificateFiltersPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion        

        #region Validate Mandatory fields while add certificate 
        [Test]
        public void ValidateMandatoryFieldsAddCertificate()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();
                ValidateMandatoryFieldsAddCertificatePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Advanced Others
        /// <summary>
        /// Advanced Others.
        /// </summary>
        [Test]
        public void UpdateAdvancedOthers()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                UpdateAdvancedOthersPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Public Negative Test Cases       

        #region Remove enterprise account
        [Test]
        public void EnterpriseRemoveAccount()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                EnterpriseRemoveAccountPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Remove enterprise account
        [Test]
        public void ValidateRemoveEnterpriseAccount()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                ValidateRemoveEnterpriseAccountPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while add legal notice 
        [Test]
        public void ValidateAddLegalNotice()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while add legal notice 
                ValidateAddLegalNoticePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while update legal notice 
        [Test]
        public void ValidateUpdateLegalNotice()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while update legal notice 
                ValidateUpdateLegalNoticePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while delete legal notice 
        [Test]
        public void ValidateDeleteLegalNotice()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while delete legal notice 
                ValidateDeleteLegalNoticePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion        

        #region Validate security checks while add certificate 
        [Test]
        public void ValidateAddCertificate()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while add certificate  
                ValidateAddCertificatePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while update certificate 
        [Test]
        public void ValidateUpdateCertificate()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while update certificate  
                ValidateUpdateCertificatePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while delete certificate 
        [Test]
        public void ValidateDeleteCertificate()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while delete certificate  
                ValidateDeleteCertificatePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion       

        #region Validate security checks while update more option 
        [Test]
        public void ValidateUpdateOtherOptions()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID);

                //Validate security checks while update more option 
                ValidateUpdateOtherOptionsPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while update more option 
        /// <summary>
        /// Validate invalid address not be save while update 
        /// </summary>
        [Test]
        public void ValidateUrlInMore()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Validate invalid address not be save while update
                ValidateUrlInMorePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Test URL while update more option
        /// <summary>
        /// Test URL while update more option
        /// </summary>
        [Test]
        public void TestUrlInMore()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Test URL while update more option
                TestUrlInMorePrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #endregion

        #region Private Methods 

        #region Private Method to Update Advanced Storage Policy
        /// <summary>
        /// Private Method to Update Advanced Storage Policy.
        /// </summary>
        void UpdateDefaultSettingsPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();
                Thread.Sleep(1000);

                var allowPrint = driver.FindElement(By.Id(Elements_Paths.Enterprise_Advanced_Allow_Print_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", allowPrint);

                var allowText = driver.FindElement(By.Id(Elements_Paths.Enterprise_Advanced_Allow_Add_Text_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", allowText);

                var passwordNum = driver.FindElement(By.Id(Elements_Paths.Enterprise_Advanced_Password_Policy_Number_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", passwordNum);
                Thread.Sleep(1000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", passwordNum);

                var documentRev = driver.FindElement(By.Id(Elements_Paths.Enterprise_Advanced_Document_Revision_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", documentRev);
                Thread.Sleep(1000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", documentRev);

                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_StoragePolicy_Save_Button_ID)).Click();

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Update_Settings_SuccessMessage_Text, element_SuccessMessage.Text);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Update Storage Policy activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Advanced_Update_Settings_UserActivity_Text, AddIntegrationActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Private Method to Add Enterprise Legal Notice  
        /// <summary>
        /// Private Method to Add Enterprise Legal Notice.
        /// </summary>
        void AddEnterpriseLegalNoticePrivate()
        {
            try
            {
                //Add Legal Notice
                AddLegalNotice(TestData.LegalNotice_Name);


                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Enterprise_Duplicate_Legal_Notice_Message_CSS_Selector)))
                {
                    //Check error message
                    IWebElement errorMessage = FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Duplicate_Legal_Notice_Message_CSS_Selector));

                    //log test case
                    LogTestCase(GetCurrentMethod(), errorMessage.Text);
                }
                else
                {
                    //Success message validation                 
                    if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Css_Selector)))
                    {
                        //Success message validation               
                        IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                        NUnit.Framework.Assert.AreEqual(TestData.LegalNotice_Name + TestData.Enterprise_Advanced_Add_LegalNotice_SuccessMessage_Text, element_SuccessMessage.Text);
                    }
                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Add Legal Notice activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Add_LegalNotice_UserActivity_Text, AddIntegrationActivity.Text);

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

        #region Private Method to Edit Enterprise Legal Notice     
        /// <summary>
        /// Private Method to Edit Enterprise Legal Notice.
        /// </summary>
        void EditEnterpriseLegalNoticePrivate()
        {
            try
            {
                //Update Legal Notice
                UpdateLegalNotice(TestData.LegalNotice_Name, TestData.LegalNotice_Name);

                //Success message validation                 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Css_Selector)))
                {
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                    NUnit.Framework.Assert.AreEqual(TestData.LegalNotice_Name + TestData.Enterprise_Advanced_Edit_LegalNotice_SuccessMessage_Text, element_SuccessMessage.Text);
                }
                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit Legal Notice activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Advanced_Edit_LegalNotice_UserActivity_Text, AddIntegrationActivity.Text);
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Delete Enterprise Legal Notice        
        /// <summary>
        /// Private Method to Delete Enterprise Legal Notice.
        /// </summary>
        void DeleteEnterpriseLegalNoticePrivate()
        {
            try
            {
                //Delete Legal Notice
                DeleteLegalNotice();

                //Success message validation                 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Css_Selector)))
                {
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                    NUnit.Framework.Assert.AreEqual(TestData.LegalNotice_Name + TestData.Enterprise_Advanced_Delete_LegalNotice_SuccessMessage_Text, element_SuccessMessage.Text);
                }
                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Delete Legal Notice activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Advanced_Delete_LegalNotice_UserActivity_Text, AddIntegrationActivity.Text);
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Add Certificate Filters     
        /// <summary>
        /// Private Method to Add Certificate Filters.
        /// </summary>
        void AddCertificateFiltersPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Certificate Filter tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_CertificateFilters_Tab_CSSSelector)).Click();

                //Add Certificate Filter
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Tab_Icon_CssSelector)).Click();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_CertificateFilters_FilterValue_Name)).SendKeys(TestData.Enterprise_Advanced_CertificateFilter_IssuerDN_Value);

                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Save_CSSSelector)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation                 
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Add_CertificateFilter_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Add Certificate Filter activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Add_CertificateFilter_UserActivity_Text, AddIntegrationActivity.Text);

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

        #region Private Method to Edit Certificate Filters   
        /// <summary>
        /// Private Method to Edit Certificate Filters.
        /// </summary>
        public void EditCertificateFiltersPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Certificate Filter tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_CertificateFilters_Tab_CSSSelector)).Click();

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Common_Tab_Search_CssSelector)).Clear();

                // Search Certificate Filter to be edited
                FindElement(driver, By.CssSelector(Elements_Paths.Common_Tab_Search_CssSelector)).SendKeys(TestData.Enterprise_Advanced_CertificateFilter_IssuerDN_Value);

                // Click on edit icon to edit certificate filter
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Enterprise_User_CssSelector)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Save_CSSSelector)).Click();
                Thread.Sleep(1000);

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation                  
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Edit_CertificateFilter_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Edit Certificate Filter activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Edit_CertificateFilter_UserActivity_Text, AddIntegrationActivity.Text);
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

        #region Private Method to Delete Certificate Filters
        /// <summary>
        /// Private Method to Delete Certificate Filters.
        /// </summary>
        void DeleteCertificateFiltersPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Certificate Filter tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_CertificateFilters_Tab_CSSSelector)).Click();

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Common_Tab_Search_CssSelector)).Clear();

                // Search Certificate Filter to be deleted
                FindElement(driver, By.CssSelector(Elements_Paths.Common_Tab_Search_CssSelector)).SendKeys(TestData.Enterprise_Advanced_CertificateFilter_IssuerDN_Value);

                //Select check box to delete searched certificate filter
                FindElement(driver, By.CssSelector(Elements_Paths.Active_Tab_Checkbox_CSS_Selector)).Click();

                // Click on delete icon to delete certificate filter
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Tab_Item_Icon_CssSelector)).Click();                

                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation                 
                    if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Css_Selector)))
                    {
                        IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                        NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Delete_CertificateFilter_SuccessMessage_Text, element_SuccessMessage.Text);
                    }

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Delete certificate filter activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Delete_CertificateFilter_UserActivity_Text, AddIntegrationActivity.Text);

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

        #region Private Method to Add Certificate Filters     
        /// <summary>
        /// Private Method to Add SAN Certificate Filters.
        /// </summary>
        void AddSANCertificateFiltersPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Certificate Filter tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_CertificateFilters_Tab_CSSSelector)).Click();

                //Add Certificate Filter
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Tab_Icon_CssSelector)).Click();

                //Dropdown
                FindElement(driver, By.ClassName(Elements_Paths.Enterprise_Advanced_CertificateFilters_Dropdown_Css_Selector)).Click();

                //Select Value
                FindElement(driver, By.XPath(Elements_Paths.Enterprise_Advanced_CertificateFilters_SAN_Css_Selector)).Click();

                //Value
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_CertificateFilters_FilterValue_Name)).SendKeys(TestData.Enterprise_Advanced_CertificateFilter_SAN_Value);


                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Save_CSSSelector)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation                 

                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Add_SAN_CertificateFilter_Success_Message_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Add Certificate Filter activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Add_CertificateFilter_UserActivity_Text, AddIntegrationActivity.Text);

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

        #region Update Advance Other     
        /// <summary>
        /// Update Advance Other
        /// </summary>
        void UpdateAdvancedOthersPrivate()
        {
            try
            {

                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Password Policy tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_Tab_CSSSelector)).Click();

                var Check_Box = driver.FindElement(By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_CheckBox_CSSSelector));
                if (!Check_Box.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Check_Box);

                //To Enter a value for Redirect URL
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).SendKeys(TestData.Enterprise_Advanced_Others_Redirect_URL);

                //To save configurations
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_Others_Save_Button_ID)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation                    
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Update_Others_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Update Others activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Advanced_Update_Others_UserActivity_Text, AddIntegrationActivity.Text);

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

        #endregion

        #region Private Negative Test Cases

        /// <summary>
        /// Duplicate check while add legal notice on base of name and validate alert
        /// </summary>
        void ValidateAddDuplicateLegalNoticePrivate()
        {
            try
            {
                //Click on Advance tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.LegalNotice_Name);

                //Check if already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add Legal Notice
                    AddLegalNotice(TestData.LegalNotice_Name);
                }

                //Add again same                 
                AddLegalNotice(TestData.LegalNotice_Name);
                Thread.Sleep(1000);

                //Check error message
                IWebElement errorMessage = FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Duplicate_Legal_Notice_Message_CSS_Selector));

                //log test case
                LogTestCase(GetCurrentMethod(), errorMessage.Text);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Duplicate check while Update legal notice on base of name and validate alert
        /// </summary>
        void ValidateUpdateDuplicateLegalNoticePrivate()
        {
            try
            {
                //Click on Advance tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.LegalNotice_Name);

                //Check if already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add
                    AddLegalNotice(TestData.LegalNotice_Name);
                }

                //Clear the search box
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.New_LegalNotice_Name);

                //Check if already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add
                    AddLegalNotice(TestData.New_LegalNotice_Name);
                }

                //Clear the search box
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Update with existing legal notice
                UpdateLegalNotice(TestData.LegalNotice_Name, TestData.New_LegalNotice_Name);
                Thread.Sleep(1000);

                //Check error message
                IWebElement errorMessage = FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Duplicate_Legal_Notice_Message_CSS_Selector));

                //log test case
                LogTestCase(GetCurrentMethod(), errorMessage.Text);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add legal notice when option no more allowed in role
        /// </summary>
        void ValidateAddLegalNoticePrivate()
        {
            try
            {
                //Add legal notice
                AddLegalNotice(TestData.Validate_LegalNotice_Name);

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while Update legal notice when option no more allowed in role
        /// </summary>
        void ValidateUpdateLegalNoticePrivate()
        {
            try
            {
                //Update legal notice
                UpdateLegalNotice(TestData.New_LegalNotice_Name, TestData.Validate_LegalNotice_Name);
                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while Update legal notice when option no more allowed in role
        /// </summary>
        void ValidateDeleteLegalNoticePrivate()
        {
            try
            {
                //Delete legal notice
                DeleteLegalNotice();
                Thread.Sleep(1000);

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add certificate 
        /// </summary>
        void ValidateAddCertificatePrivate()
        {
            try
            {
                //Add Certificate Filters
                AddCertificateFiltersPrivate();
                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while update certificate 
        /// </summary>
        void ValidateUpdateCertificatePrivate()
        {
            try
            {
                //Update Certificate Filters
                EditCertificateFiltersPrivate();

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while delete certificate 
        /// </summary>
        void ValidateDeleteCertificatePrivate()
        {
            try
            {
                //Update Certificate Filters
                DeleteCertificateFiltersPrivate();
                Thread.Sleep(1000);

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while update more option 
        /// </summary>
        void ValidateUpdateOtherOptionsPrivate()
        {
            try
            {
                //Update 
                UpdateAdvancedOthersPrivate();
                Thread.Sleep(1000);

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);
                }
                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate invalid address not be save while update 
        /// </summary>
        void ValidateUrlInMorePrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Password Policy tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_Tab_CSSSelector)).Click();

                var Check_Box = driver.FindElement(By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_CheckBox_CSSSelector));
                if (!Check_Box.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Check_Box);

                //To Enter a value for Redirect URL
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).SendKeys(TestData.Enterprise_Advanced_Others_Incorrect_URL);

                //To Enter a value for XML URL
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Name)).SendKeys(TestData.Enterprise_Advanced_Others_Redirect_URL);

                ////Test XML Url
                //FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Test_Id)).Click();
                //Thread.Sleep(1000);

                //Success message validation                 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation               
                    IWebElement errorMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Others_Test_Url_Error_Message, errorMessage.Text);
                }

                //To save configurations
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_Others_Save_Button_ID)).Click();

                //Log the test case
                LogResult(GetCurrentMethod(), "Invalid Url");

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Test URL while update more option 
        /// </summary>
        void TestUrlInMorePrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Password Policy tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_Tab_CSSSelector)).Click();

                var Check_Box = driver.FindElement(By.CssSelector(Elements_Paths.Enterprise_Advanced_Others_CheckBox_CSSSelector));
                if (!Check_Box.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Check_Box);

                //To Enter a value for Redirect URL
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_URL_Name)).SendKeys(TestData.Enterprise_Advanced_Others_Redirect_URL);

                //To Enter a value for XML URL
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Name)).SendKeys(TestData.Integration_Settings_Allowed_Domain);

                ////Test XML Url
                //FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_Others_XML_URL_Test_Id)).Click();
                //Thread.Sleep(1000);

                //Success message validation                 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Css_Selector)))
                {
                    //Success message validation               
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Toaster_Message_Text_Css_Selector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Advanced_Others_Test_Url_Message, element_SuccessMessage.Text);
                }

                //To Test URL
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_Others_Save_Button_ID)).Click();

                //Log the test case
                LogResult(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate Mandatory fields on Add legal notice
        /// </summary>
        void ValidateAddEnterpriseLegalNoticeMandatoryFieldsPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Click on ADD icon
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on Save
                FindElement(driver, By.CssSelector(Elements_Paths.LegalNotice_SaveButton_CssSelector)).Click();
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

        /// <summary>
        /// Validate Mandatory fields on Update legal notice
        /// </summary>
        void ValidateUpdateEnterpriseLegalNoticeMandatoryFieldsPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.LegalNotice_Name);

                //Check if already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add
                    AddLegalNotice(TestData.LegalNotice_Name);
                    Thread.Sleep(1000);

                    FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)).Click();
                }

                //Click on Edit icon
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                // Clear Name field
                FindElement(driver, By.Name(Elements_Paths.LegalNotice_NameField_Name)).Clear();

                //Click on Save
                FindElement(driver, By.CssSelector(Elements_Paths.LegalNotice_SaveButton_CssSelector)).Click();
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

        /// <summary>
        /// Validate Mandatory fields on add Certificate
        /// </summary>
        void ValidateMandatoryFieldsAddCertificatePrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Certificate Filter tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_CertificateFilters_Tab_CSSSelector)).Click();

                //Add Certificate Filter
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Tab_Icon_CssSelector)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Save_CSSSelector)).Click();
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

        /// <summary>
        /// Enterprise Remove account
        /// </summary>
        void EnterpriseRemoveAccountPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                //Click on Remove Enterprise tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_Remove_Enterprise_Tab_CSSSelector)).Click();
               
                //Click on delete button
                FindElement(driver, By.Id(Elements_Paths.Personal_Advance_Remove_Account_Button_By_Id)).Click();

                //Click on No button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Default_Button_CSSSelector)).Click();

                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate remove enterprise account when advance tab not allowed in role
        /// </summary>
        void ValidateRemoveEnterpriseAccountPrivate()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                //Click on Remove Enterprise tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_Remove_Enterprise_Tab_CSSSelector)).Click();

                //Click on delete button
                FindElement(driver, By.Id(Elements_Paths.Personal_Advance_Remove_Account_Button_By_Id)).Click();

                //Click on yes button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                LogResult(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region CRUD
        void AddLegalNotice(string name)
        {
            try
            {
                //Click on Advance tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Click on ADD icon
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();
                Thread.Sleep(2000);
                //Enter Legal Notice Name in NAME field
                FindElement(driver, By.Name(Elements_Paths.LegalNotice_NameField_Name)).SendKeys(name);
                Thread.Sleep(2000);

                //Enter Legal Notice Content in CONTENT field
                FindElement(driver, By.CssSelector(Elements_Paths.LegalNotice_ContentFie_CssSelector)).SendKeys(TestData.LegalNotice_Content);

                //Click on Save Button
                IWebElement SaveButtonPath = FindElement(driver, By.CssSelector(Elements_Paths.LegalNotice_SaveButton_CssSelector));
                SaveButtonPath.Click();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UpdateLegalNotice(string search, string update)
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Search the legal notice to be edited in search field
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(search);

                //Click on Edit icon
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                // Clear Name field
                FindElement(driver, By.Name(Elements_Paths.LegalNotice_NameField_Name)).Clear();

                //Enter Legal Notice Name in NAME field
                FindElement(driver, By.Name(Elements_Paths.LegalNotice_NameField_Name)).SendKeys(update);

                //Click on Save Button
                IWebElement SaveButtonPath = FindElement(driver, By.CssSelector(Elements_Paths.LegalNotice_SaveButton_CssSelector));
                SaveButtonPath.Click();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void DeleteLegalNotice()
        {
            try
            {
                //Click on Enterprise Advanced Settings
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Advanced_ID)).Click();

                // Click on Legal Notice tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Advanced_LegalNotice_Tab_CSSSelector)).Click();

                //Search the legal notice to be edited in search field
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.LegalNotice_Name);
                //Click on chekcbox to delete 
                FindElement(driver, By.CssSelector(Elements_Paths.Active_Tab_Checkbox_CSS_Selector)).Click();
                //Click on Delete icon
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
                //Confirmation yes
                FindElement(driver, By.XPath(Elements_Paths.Delete_ConfirmationYes_XPath)).Click();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion  
    }
}
