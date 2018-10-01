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
    /// Enterprise Branding.
    /// </summary>
    class Enterprise_Branding : General_Methods
    {

        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Enterprise Branding Methods
        [Test]
        public void AllEnterpriseBranding()
        {
            try
            {
                //Update Company Logo in branding
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Branding_ID)))
                {
                    BrandingCompanyLogoPrivate();

                    //Reset to default branding
                    dashboard.NavigationToEnterpriseSettings();
                    BrandingResetDefaultPrivate();

                    //Update branding color
                    dashboard.NavigationToEnterpriseSettings();
                    BrandingColorsPrivate();

                    //Update settings in role
                    dashboard.NavigationToEnterpriseSettings();
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Branding_CheckBox_ID);

                    //Valdate Update Branding
                    ValidateUpdateBrandingPrivate();

                    //Valdate Reset Branding
                    ValidateResetBrandingPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Branding_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Test Method to Configure Company Logo and Favicon Icon
        /// <summary>
        /// Update Company Logo.
        /// </summary>
        [Test]
        public void BrandingCompanyLogo()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                BrandingCompanyLogoPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        #endregion

        #region Reset Branding
        /// <summary>
        /// Reset Branding
        /// </summary>
        [Test]
        public void BrandingResetDefault()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                BrandingResetDefaultPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion

        #region Update Branding Colors
        /// <summary>
        /// Update Branding Colors.
        /// </summary>
        [Test]
        public void BrandingColors()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                BrandingColorsPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        #endregion

        #region Validate update Branding
        /// <summary>
        ///Validate security checks while update branding 
        /// </summary>
        [Test]
        public void ValidateUpdateBranding()
        {
            try
            {
                //Update settings in role
                dashboard.NavigationToEnterpriseSettings();
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Branding_CheckBox_ID);

                //Valdate Update Branding
                ValidateUpdateBrandingPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Validate reset Branding
        /// <summary>
        ///Validate security checks while reset branding 
        /// </summary>
        [Test]
        public void ValidateResetBranding()
        {
            try
            {
                //Update settings in role
                dashboard.NavigationToEnterpriseSettings();
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Branding_CheckBox_ID);

                //Valdate Reset Branding
                ValidateResetBrandingPrivate();                

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion


        /// <summary>
        /// Private Method to Update Company Logo.
        /// </summary>

        #region Private Method to set Company Logo and Favicon Icon
        void BrandingCompanyLogoPrivate()
        {
            try
            {
                //Click on Enterprise Branding             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Branding_ID)).Click();

                //Upload logo
                UploadDocument(Elements_Paths.Enterprise_Branding_CompanyLogo_Upload_CSSSelector, TestData.Sample_Black_My_Desk_Image, 1000);

                //Upload favicon
                UploadDocument(Elements_Paths.Enterprise_Branding_Favicon_Upload_CSSSelector, TestData.Sample_SH_Faivcon_Image, 1000);
                
                // To click on SAVE button to set branding
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Branding_Save_Button_CSSSelector)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Update_Branding_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Branding company logo activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Update_Branding_UserActivity_Text, AddIntegrationActivity.Text);

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        #endregion

        #region Private Method to reset branding to default
        void BrandingResetDefaultPrivate()
        {
            try
            {
                //Click on Enterprise Branding             
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Branding_ID)).Click();

                // To click on Reset to Default button
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Branding_ResetDefault_Button_ID)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                if (!IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    //Success message validation
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                    NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Update_Branding_ResetDefault_SuccessMessage_Text, element_SuccessMessage.Text);

                    //Go to user activity log
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                    FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                    //Reset branding activity validation
                    IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                    Assert.AreEqual(TestData.Enterprise_Update_Branding_ResetDefault_UserActivity_Text, AddIntegrationActivity.Text);
                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        #endregion

        #region Private Method to Update Branding Colours
        /// <summary>
        /// Private Method to Update Branding Colors.
        /// </summary>
        void BrandingColorsPrivate()
        {
            try
            {
                //Click on Enterprise Branding
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Branding_ID)).Click();

                // Click on Colours tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Integration_WorkflowCompletion_Tab_CSSSelector)).Click();

                // NEEDS TO ADD CODE HERE TO CHANGE BRANDING COLOURS


                // To click on SAVE button to set branding
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Branding_Save_Button_CSSSelector)).Click();

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                IWebElement element_SuccessMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                NUnit.Framework.Assert.AreEqual(TestData.Enterprise_Update_Branding_SuccessMessage_Text, element_SuccessMessage.Text);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Update branding colour activity validation
                IWebElement AddIntegrationActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Enterprise_Update_Branding_UserActivity_Text, AddIntegrationActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }

        /// <summary>
        /// Validate security checks while update branding 
        /// </summary>
        void ValidateUpdateBrandingPrivate()
        {
            try
            {
                //Update
                BrandingCompanyLogoPrivate();
                
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
        /// Validate security checks while reset branding 
        /// </summary>
        void ValidateResetBrandingPrivate()
        {
            try
            {
                //Reset Branding               
                BrandingResetDefaultPrivate();

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

        #endregion
    }
}
