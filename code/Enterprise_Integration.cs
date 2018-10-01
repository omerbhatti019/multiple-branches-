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
    /// Enterprise Integration Application.
    /// </summary>
    class Enterprise_Integration : General_Methods
    {

        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Enterprise Integration Methods
        [Test]
        public void AllEnterpriseIntegrations()
        {
            try
            {
                //Go to Enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)))
                {
                    //Add Application
                    AddApplicationIntegrationPrivate();

                    //Update Application
                    dashboard.NavigationToEnterpriseSettings();
                    EditIntegrationApplicationDetailsPrivate();

                    //Delete Application
                    dashboard.NavigationToEnterpriseSettings();
                    DeleteApplicationIntegrationPrivate();

                    //Configure Workflow Report
                    dashboard.NavigationToEnterpriseSettings();
                    ConfigureWorkflowCompletionReportPrivate();

                    //Validate workflow report mandatory fields
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateWorkflowReportMandatoryFieldsPrivate();

                    //Add External User
                    dashboard.NavigationToEnterpriseSettings();
                    AddExternalUsersPrivate();
                    Thread.Sleep(1000);

                    //Update External User
                    dashboard.NavigationToEnterpriseSettings();
                    EditExternalUsersPrivate();
                    Thread.Sleep(1000);

                    //Delete External User
                    dashboard.NavigationToEnterpriseSettings();
                    DeleteExternalUsersPrivate();
                    Thread.Sleep(1000);

                    //Validate add duplicate application
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddDuplicateApplicationPrivate();

                    //Validate update duplicate application
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateDuplicateApplicationPrivate();

                    //Validate Add Applciation Integration with Mandatory fields
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddApplicationMandatoryFieldsPrivate();

                    //Validate Update Applciation Integration with Mandatory fields
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateApplicationMandatoryFieldsPrivate();

                    //Validate add duplicate external user
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddDuplicateExternalUserPrivate();

                    //Validate update duplicate external user
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateDuplicateExternalUserPrivate();

                    //Validate add external user with mandatory fields 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddExternalUserMandatoryFieldsPrivate();

                    //Validate security checks while add application integration 
                    dashboard.NavigationToEnterpriseSettings();
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID);
                    ValidateAddApplicationPrivate();

                    //Validate Update application
                    ValidateUpdateApplicationPrivate();

                    //Validate Delete application
                    ValidateDeleteApplicationPrivate();

                    //Validate security checks while add external user
                    ValidateAddExternalUserPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Integrations_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Add Applciation Integration
        /// <summary>
        /// Add Applciation Integration.
        /// </summary>
        [Test]
        public void AddApplicationIntegration()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddApplicationIntegrationPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
        
        #region Edit Applciation Integration
        /// <summary>
        /// Edit Applciation Integration.
        /// </summary>
        [Test]
        public void EditIntegrationApplicationDetails()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditIntegrationApplicationDetailsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion        

        #region Delete Applciation Integration
        /// <summary>
        /// Delete Applciation Integration.
        /// </summary>
        [Test]
        public void DeleteApplicationIntegration()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteApplicationIntegrationPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Add External users
        /// <summary>
        /// Add External users
        /// </summary>
        [Test]
        public void AddExternalUsers()
        {

            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddExternalUsersPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit External users
        /// <summary>
        /// Edit External users.
        /// </summary>
        [Test]
        public void EditExternalUsers()
        {

            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditExternalUsersPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region delete External users
        /// <summary>
        /// delete External users.
        /// </summary>
        [Test]
        public void DeleteExternalUsers()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteExternalUsersPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Configuring Workflow Completion Report
        [Test]
        public void ConfigureWorkflowCompletionReport()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ConfigureWorkflowCompletionReportPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Configuring Workflow Completion Report
        [Test]
        public void ValidateWorkflowReportMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateWorkflowReportMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Negative Test cases

        #region Validaet Duplicate Applciation Integration
        /// <summary>
        /// Validaet Duplicate Applciation Integration
        /// </summary>
        [Test]
        public void ValidateAddDuplicateApplication()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddDuplicateApplicationPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validaet Duplicate update Applciation Integration
        /// <summary>
        /// Validaet Update Duplicate Applciation Integration
        /// </summary>
        [Test]
        public void ValidateUpdateDuplicateApplication()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateDuplicateApplicationPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Add Applciation Integration with Mandatory fields 
        /// <summary>
        /// Validate Add Applciation Integration with Mandatory fields
        /// </summary>
        [Test]
        public void ValidateAddApplicationMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddApplicationMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Update Applciation Integration with Mandatory fields 
        /// <summary>
        /// Validate Update Applciation Integration with Mandatory fields
        /// </summary>
        [Test]
        public void ValidateUpdateApplicationMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateApplicationMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Add Duplicate External User
        /// <summary>
        /// Validate Add Duplicate External User
        /// </summary>
        [Test]
        public void ValidateAddDuplicateExternalUser()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddDuplicateExternalUserPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Update Duplicate External User
        /// <summary>
        /// Validate update Duplicate External User
        /// </summary>
        [Test]
        public void ValidateUpdateDuplicateExternalUser()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateDuplicateExternalUserPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate add external user with mandatory fields 
        /// <summary>
        /// Validate add external user with mandatory fields 
        /// </summary>
        [Test]
        public void ValidateAddExternalUserMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddExternalUserMandatoryFieldsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while add application integration 
        /// <summary>
        /// Validate security checks while add application integration 
        /// </summary>
        [Test]
        public void ValidateAddApplication()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID);

                //Add application
                ValidateAddApplicationPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while update application integration 
        /// <summary>
        /// Validate security checks while update application integration 
        /// </summary>
        [Test]
        public void ValidateUpdateApplication()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID);

                //Validate Update application
                ValidateUpdateApplicationPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while delete application integration 
        /// <summary>
        /// Validate security checks while delete application integration 
        /// </summary>
        [Test]
        public void ValidateDeleteApplication()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID);

                //Validate Delete application
                ValidateDeleteApplicationPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate security checks while add external user 
        /// <summary>
        /// Validate security checks while add external user 
        /// </summary>
        [Test]
        public void ValidateAddExternalUser()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID);

                //Validate add external user
                ValidateAddExternalUserPrivate();

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

        #region Private Method for Add Enterprise Integration
        /// <summary>
        /// Private Method to Add Applciation Integration.
        /// </summary>
        void AddApplicationIntegrationPrivate()
        {
            try
            {
                //Add Application
                AddApplication(TestData.Enterprise_Integration_ClientID);

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation
                    Thread.Sleep(1000);
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Add_Integration_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Add Application integration key activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Add_Integration_UserActivity_Text, AddIntegrationActivity.Text);
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

        #region Private Method to Delete Applciation Integration
        /// <summary>
        /// Private Method to Delete Applciation Integration.
        /// </summary>
        void DeleteApplicationIntegrationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                // Search Integration Application to be edited
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                try
                {
                    //Select and Delete searched integration application
                    var Check_Box = driver.FindElement(By.CssSelector(Elements_Paths.Enterprise_Integration_Selection_CheckBox_CSSSelector));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Check_Box);
                }
                catch (Exception)
                {
                    //Add Application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                    Thread.Sleep(1000);

                    //Select and Delete searched integration application
                    var Check_Box = driver.FindElement(By.CssSelector(Elements_Paths.Enterprise_Integration_Selection_CheckBox_CSSSelector));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Check_Box);
                }
               
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation
                    //Thread.Sleep(1000);
                    //IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    //NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Integration_ClientID + TestData.Enterprise_Delete_Integration_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Delete Applictaion integration activity validation
                    IWebElement DeleteIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Delete_Integration_UserActivity_Text, DeleteIntegrationActivity.Text);

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

        #region Private Method to Edit Applciation Integration  
        /// <summary>
        /// Private Method to Edit Applciation Integration.
        /// </summary>
        void EditIntegrationApplicationDetailsPrivate()
        {
            try
            {
                //Update application                
                UpdateApplication(TestData.Enterprise_Integration_ClientID, TestData.Enterprise_Integration_ClientID);
               
                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Edit_Integration_SuccessMessage_Text, element_SuccessMessage.Text);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit application integration key activity validation
                IWebElement AddRoleActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Edit_Integration_UserActivity_Text, AddRoleActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method for Configuring Workflow Completion Report        
        void ConfigureWorkflowCompletionReportPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                // To click Workflow Completion Report tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_Tab_CSSSelector)).Click();

                // To enable workflow completion report
                var Workflow_Completion_CheckBox = driver.FindElement(By.Id(Elements_Paths.Enterprise_Integration_WorkflowCompletion_CheckBox_ID));
                if (!Workflow_Completion_CheckBox.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Workflow_Completion_CheckBox);

                // Enter Server URL
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_URL_CSSSelector)).Clear();
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_URL_CSSSelector)).SendKeys(TestData.Enterprise_Integration_WorkflowCompletionReport_Server_URL);

                //// To Verify Server URL                
                //FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_TestURL_Button_CSSSelector)).Click();
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //IWebElement URLVerify_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                //NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Update_WorkflowCompletionReport_ServerURL_SuccessMessage_Text, URLVerify_SuccessMessage.Text);


                //To click check box to add completed document in report
                Thread.Sleep(7000);
                var Workflow_Completion_AddDocument_CheckBox = driver.FindElement(By.Id(Elements_Paths.Enterprise_Integration_WorkflowCompletion_AddDocument_CheckBox_ID));
                if (!Workflow_Completion_AddDocument_CheckBox.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Workflow_Completion_AddDocument_CheckBox);

                //Click on SAVE button to save configurations
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Update_WorkflowCompletionReport_SuccessMessage_Text, element_SuccessMessage.Text);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Workflow completion report validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Update_WorkflowCompletionReport_UserActivity_Text, AddIntegrationActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Private Method to Add External users
        /// <summary>
        /// Private Method to Add External users.
        /// </summary>
        void AddExternalUsersPrivate()
        {
            try
            {
                //Integrations Tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if application already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                }

                //Add user
                AddExternalUser(TestData.Register_External_User_EmailAddress);

                //Clear Search 
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Add external user activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Integration_External_User_Added_UserActivity_Text, AddIntegrationActivity.Text);


                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Edit External users
        /// <summary>
        /// Private Method to Edit External users.
        /// </summary>
        void EditExternalUsersPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();
               
                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                    Thread.Sleep(1000);
                }

                //Click on users Icon
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                //Search User
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);

                //Check if user already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Click on done 
                    FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                    //Add user
                    AddExternalUser(TestData.Register_External_User_EmailAddress);
                    Thread.Sleep(1000);

                    //Click on users Icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                    //Search User
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);

                }

                //Update
                UpdateExternalUser(TestData.Register_External_User_EmailAddress);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit external user activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Integration_External_User_Update_UserActivity_Text, AddIntegrationActivity.Text);


                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Delete External users
        /// <summary>
        /// Private Method to Delete External users.
        /// </summary>
        void DeleteExternalUsersPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                    Thread.Sleep(1000);
                }

                //Click on users Icon
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                //Search User
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);

                //Check if user already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Click on done 
                    FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                    //Add user
                    AddExternalUser(TestData.Register_External_User_EmailAddress);
                    Thread.Sleep(1000);
                    
                    //Click on users
                    FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                    //Search User
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);
                  
                    //Select user
                    FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_CheckBox_CSS_Selector)).Click();
                }

                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_Trash_CSS_Selector)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Delete external user activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Integration_External_User_Delete_UserActivity_Text, AddIntegrationActivity.Text);


                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #endregion

        #region Negative Test cases
        /// <summary>
        /// Duplication check while add application integration 
        /// </summary>
        void ValidateAddDuplicateApplicationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                }

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Add again same application
                AddApplication(TestData.Enterprise_Integration_ClientID);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Duplicate_Add_Application_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Duplication check while Update application integration 
        /// </summary>
        void ValidateUpdateDuplicateApplicationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                }

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID_Name);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID_Name);
                }

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Update application                
                UpdateApplication(TestData.Enterprise_Integration_ClientID_Name, TestData.Enterprise_Integration_ClientID);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Duplicate_Add_Application_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Duplication check while add external user
        /// </summary>
        void ValidateAddDuplicateExternalUserPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                }

                //Click on users Icon
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                //Search User
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);


                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Click on Done
                    FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                    //Add user
                    AddExternalUser(TestData.Register_External_User_EmailAddress);
                    Thread.Sleep(1000);
                }

                //Add same user again
                AddExternalUser(TestData.Register_External_User_EmailAddress);



                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Add_External_Exist_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Duplication check while update external user
        /// </summary>
        void ValidateUpdateDuplicateExternalUserPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if application already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                }

                //Click on users Icon
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                //Search User
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Register_External_User_EmailAddress);

                //Check if user already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Click on Done
                    FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                    //Add user
                    AddExternalUser(TestData.Register_External_User_EmailAddress);

                    //Click on users Icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();
                }

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Search User
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.External_User_EmailAddress);

                //Check if user already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Click on Done
                    FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                    //Add user
                    AddExternalUser(TestData.External_User_EmailAddress);

                    //Click on users Icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                    //Search User
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.External_User_EmailAddress);
                }

                //Update user
                UpdateExternalUser(TestData.Register_External_User_EmailAddress);

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Add_External_Exist_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add application integration 
        /// </summary>
        void ValidateAddApplicationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Add Application
                AddApplication(TestData.Validate_Enterprise_Integration_ClientID);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add application integration 
        /// </summary>
        void ValidateUpdateApplicationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();
              
                //Update Application
                UpdateApplication(TestData.Enterprise_Integration_ClientID, TestData.Enterprise_Integration_ClientID);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while delete application integration 
        /// </summary>
        void ValidateDeleteApplicationPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();
                
                //Delete Application
                DeleteApplicationIntegrationPrivate();
                
                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add external user 
        /// </summary>
        void ValidateAddExternalUserPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Add user
                AddExternalUser(TestData.User_EmailAddress);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate add application mandatory fields 
        /// </summary>
        void ValidateAddApplicationMandatoryFieldsPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Click on add button
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Save button
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();
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
        /// Validate Update application mandatory fields 
        /// </summary>
        void ValidateUpdateApplicationMandatoryFieldsPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if application already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_App_Edit_CssSelecter)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);
                    Thread.Sleep(1000);

                    //Click on message  
                    FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)).Click();

                    // Click on edit icon to edit enterprise integration application
                    FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_App_Edit_CssSelecter)).Click();
                }
               

                //Clear name
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_ClientID_Name)).Clear();

                //Save button
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();
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
        /// Validate add external user with mandatory fields 
        /// </summary>
        void ValidateAddExternalUserMandatoryFieldsPrivate()
        {
            try
            {
                //Integrations Tab
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Search Application
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Enterprise_Integration_ClientID);

                //Check if application already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add application
                    AddApplication(TestData.Enterprise_Integration_ClientID);

                    //Click on message  
                    FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)).Click();
                }

                //Users option
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();

                //Add user
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_Add_CSS_Selector)).Click();

                //Save button
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Close model dialog
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();

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
        /// Validate workflow report mandatory fields 
        /// </summary>
        void ValidateWorkflowReportMandatoryFieldsPrivate()
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                // To click Workflow Completion Report tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_Tab_CSSSelector)).Click();

                // To enable workflow completion report
                var Workflow_Completion_CheckBox = driver.FindElement(By.Id(Elements_Paths.Enterprise_Integration_WorkflowCompletion_CheckBox_ID));
                if (!Workflow_Completion_CheckBox.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", Workflow_Completion_CheckBox);

                //Clear Server URL
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_URL_CSSSelector)).Clear();

                //Click on save button 
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();
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

        #region CRUD

        void AddApplication(string clientIDName)
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                // Configure Integration parameter to add new
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_ClientID_Name)).SendKeys(clientIDName);
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_CallBackURL_Name)).SendKeys(TestData.Enterprise_Integration_CallBackURL);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_ClientSecret_Button_CSSSelector)).Click();

                //Click on next tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Next_Tab_Css_Selecter)).Click();

                //Collapse Viewer Side Panels checkbox
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Enterprise_Integration_Collapse_Id_Selecter));                
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Save button
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UpdateApplication(string searchClientIDName, string updateClientID)
        {
            try
            {
                //Click on Enterprise Integrations             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Integrations_ID)).Click();

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                // Search Integration Application to be edited
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(searchClientIDName);
                
                try
                {
                    // Click on edit icon to edit enterprise integration application
                    FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_App_Edit_CssSelecter)).Click();

                }
                catch (Exception)
                {
                    //Add Application
                    AddApplication(searchClientIDName);

                    // Click on edit icon to edit enterprise integration application
                    FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_App_Edit_CssSelecter)).Click();
                }

                // Update Integration parameter to edit
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_ClientID_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_ClientID_Name)).SendKeys(updateClientID);
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_CallBackURL_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Enterprise_Integration_CallBackURL_Name)).SendKeys(TestData.Enterprise_Integration_CallBackURL);
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_ClientSecret_Button_CSSSelector)).Click();

                //Click on next tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Next_Tab_Css_Selecter)).Click();

                //Check                
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Enterprise_Integration_Is_Hidden_Id_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);


                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_Save_Button_CSSSelector)).Click();

                //Clear Search 
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void AddExternalUser(string userEmail)
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_CSS_Selector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_Add_CSS_Selector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Email_CSS_Selector)).Clear();
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Email_CSS_Selector)).SendKeys(userEmail);
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Close model incase of error
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Default_Button_CSSSelector)).Click();
                
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UpdateExternalUser(string userEmail)
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Icon_Edit_CSS_Selector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Email_CSS_Selector)).Clear();
                FindElement(driver, By.CssSelector(Elements_Paths.Enteprise_Integration_External_User_Email_CSS_Selector)).SendKeys(userEmail);
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();

                //Close model incase of error
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Default_Button_CSSSelector)).Click();

                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Register_Primary_Button_CSSSelector)).Click();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
    }
}
