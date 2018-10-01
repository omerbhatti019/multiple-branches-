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
    /// Enterprise Notifications
    /// </summary>
    public class Enterprise_Notifications : General_Methods
    {

        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Enterprise Notifications
        /// <summary>
        /// All Enterprise Notifications
        /// </summary>
        [Test]
        public void AllEnterpriseNotifications()
        {
            try
            {
                //Update Notifications
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Notifications_ID)))
                {
                    EnterpriseNotificationsPrivate();

                    //Update Notifications Content
                    dashboard.NavigationToEnterpriseSettings();
                    EnterpriseNotificationContentPrivate();

                    //Reset Notifications
                    dashboard.NavigationToEnterpriseSettings();
                    EnterpriseEmailsResetToDefaultPrivate();

                    //Validate Enterprise Mandatory content
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateEnterpriseNotificationMandatoryContentPrivate();

                    //Navigate to enterprise settings
                    dashboard.NavigationToEnterpriseSettings();

                    //Update settings in role
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Notification_CheckBox_ID);

                    //Validate Notification                
                    EnterpriseNotificationsPrivate();

                    //Validate Notification content
                    EnterpriseNotificationContentPrivate();

                    //Validate Reset Notification
                    EnterpriseEmailsResetToDefaultPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Notifications_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Update Enterprise Notifications
        /// <summary>
        /// Update Enterprise Notifications
        /// </summary>
        [Test]
        public void EnterpriseNotifications()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EnterpriseNotificationsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Update Enterprise Notifications Content
        /// <summary>
        /// Update Enterprise Notifications Content
        /// </summary>
        [Test]
        public void EnterpriseNotificationContent()
        {

            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EnterpriseNotificationContentPrivate();                
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Enterprise Notifications reset to default
        /// <summary>
        /// Enterprise Notifications reset to default
        /// </summary>
        [Test]
        public void EnterpriseEmailsResetToDefault()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EnterpriseEmailsResetToDefaultPrivate();               
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region  Validate Enterprise Mandatory content
        /// <summary>
        ///  Validate Enterprise Mandatory content
        /// </summary>
        [Test]
        public void ValidateEnterpriseNotificationMandatoryContent()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateEnterpriseNotificationMandatoryContentPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Enterprise Notifications Update
        /// <summary>
        /// Validate Enterprise Notifications update
        /// </summary>
        [Test]
        public void ValidateUpdateNotification()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Notification_CheckBox_ID);

                //Validate Notification                
                EnterpriseNotificationsPrivate();

                //Log result
                LogResult(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Enterprise Notifications Update Content
        /// <summary>
        /// Validate Enterprise Notifications update content
        /// </summary>
        [Test]
        public void ValidateUpdateNotificationContent()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Notification_CheckBox_ID);

                //Validate Notification
                EnterpriseNotificationContentPrivate();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate Enterprise Notifications reset content
        /// <summary>
        /// Validate Enterprise Notifications reset content
        /// </summary>
        [Test]
        public void ValidateResetNotificationContent()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Notification_CheckBox_ID);

                //Validate Reset Notification
                EnterpriseEmailsResetToDefaultPrivate();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion


        #region Private Method to Update  Enterprise Notifications.    
        /// <summary>
        /// Private Method to Update  Enterprise Notifications.
        /// </summary>
        void EnterpriseNotificationsPrivate()
        {
            try
            {

                //Click Notifications
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Notifications_ID)).Click();

                //Select check box for email of password change              
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Notification_Email_Password_Change_CheckBox_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Select check box for on screen notification of payment
                var checkbox1 = FindElement(driver, By.Id(Elements_Paths.Notification_OnScreen_Payment_Received_CheckBox_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", checkbox1);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);


                //Select check box for push notification of workflow completed
                var checkbox2 = FindElement(driver, By.Id(Elements_Paths.Notification_Push_Workflow_Complete_CheckBox_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", checkbox2);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Click on save button
                var save = FindElement(driver, By.Id(Elements_Paths.Notifications_Save_Button_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", save);
                Thread.Sleep(2000);

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    //Success message validation                    
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    Assert.AreEqual(TestData.MySetting_Notification_Success_Message, ToasterMessage.Text);

                    //User activity log verfication
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Save notification validation
                    IWebElement SaveNotification = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.MySetting_Notification_Activity_Text, SaveNotification.Text);

                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Private Method to Update  Enterprise Notifications Content       
        /// <summary>
        /// Private Method to Update  Enterprise Notifications Content
        /// </summary>
        void EnterpriseNotificationContentPrivate()
        {
            try
            {
                //Click Notifications
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Notifications_ID)).Click();

                //Click on email content tab option
                FindElement(driver, By.CssSelector(Elements_Paths.Notifications_Email_Content_CSSSelector)).Click();

                //Select the type of email              
                FindElement(driver, By.CssSelector(Elements_Paths.Notifications_Email_Type_Dropdown_CSSSelector)).Click();
                driver.FindElement(By.Id(Elements_Paths.Notifications_Email_Type_Dropdown_Value_ID)).Click();

                //Update subject text
                FindElement(driver, By.Name(Elements_Paths.Notifications_Email_Content_Subject_Name)).Click();
                driver.FindElement(By.Name(Elements_Paths.Notifications_Email_Content_Subject_Name)).Click();
                driver.FindElement(By.Name(Elements_Paths.Notifications_Email_Content_Subject_Name)).Clear();
                driver.FindElement(By.Name(Elements_Paths.Notifications_Email_Content_Subject_Name)).SendKeys(TestData.Notification_Email_Content_Subject);

                //Click on save button
                var save = FindElement(driver, (By.Id(Elements_Paths.Notifications_Email_Content_Save_Button_ID)));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", save);
                Thread.Sleep(1000);

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    //Success message validation                    
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    Assert.AreEqual(TestData.MySetting_Notification_Content_Success_Message, ToasterMessage.Text);

                    //User activity log verfication
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Save notification validation
                    IWebElement SaveNotification = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.MySetting_Notification_Content_Activity_Text, SaveNotification.Text);

                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Enterprise Notifications reset to default private method       
        /// <summary>
        ///  Enterprise Notifications reset to default private method
        /// </summary>
        void EnterpriseEmailsResetToDefaultPrivate()
        {
            try
            {

                //Click Notifications
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Notifications_ID)).Click();

                //Click on email content tab option
                FindElement(driver, By.CssSelector(Elements_Paths.Notifications_Email_Content_CSSSelector)).Click();

                //Reset to default                
                var save = FindElement(driver, (By.Id(Elements_Paths.Notifications_Reset_Default_Button_ID)));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", save);

                //Confirm the reset option
                var save1 = FindElement(driver, (By.CssSelector(Elements_Paths.Notifications_Confirm_Yes_Button_CSSSelector)));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", save1);
                Thread.Sleep(1000);
                
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    LogResult(GetCurrentMethod());
                else
                {
                    //Success message validation                    
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    Assert.AreEqual(TestData.MySetting_Notification_Reset_Success_Message, ToasterMessage.Text);

                    //User activity log verfication
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                    //Save notification validation
                    IWebElement SaveNotification = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.MySetting_Notification_Reset_Activity_Text, SaveNotification.Text);

                    LogTestCase(GetCurrentMethod());
                }

                //Click on error message
                FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)).Click();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        /// <summary>
        /// Validate Enterprise Mandatory content
        /// </summary>
        void ValidateEnterpriseNotificationMandatoryContentPrivate()
        {
            try
            {
                //Click Notifications
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Notifications_ID)).Click();

                //Click on email content tab option
                FindElement(driver, By.CssSelector(Elements_Paths.Notifications_Email_Content_CSSSelector)).Click();

                //Clear search
                driver.FindElement(By.Name(Elements_Paths.Notifications_Email_Content_Subject_Name)).Clear();

                //Click on Save
                FindElement(driver, (By.Id(Elements_Paths.Notifications_Email_Content_Save_Button_ID))).Click();

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


    }
}
