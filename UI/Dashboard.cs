using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Linq;
using System.Threading;

namespace IntegrationTest
{
    [TestFixture]
    [Parallelizable]
    /// <summary>
    /// Verify the links on dashboard
    /// </summary>

    public class Dashboard : General_Methods
    {
        #region All Methods
        
        /// <summary>
        /// Verify all links on dashboard for enterprise user
        /// </summary>        
        [Test]
        public void AllDashboardEnterpriseNavigation()
        {
            try
            {
                //Dashboard documents counts
                NavigationToDocumentCountsPrivate();                

                //Start new workflow 
                WorkflowLinkPrivate();

                //Personal settings
                PersonalSettingsOptionsPrivate();

                //Enterprise Settings
                EnterpriseSettingsOptionsPriavte();

                //Dashboard page footer settings
                PageFooterPrivate();

                //Menu options
                NavigationToMenuOptionsPrivate();

                //Log test
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
        /// Verify all links on dashboard for indvdiual user
        /// </summary>
        [Test]
        public void AllDashboardIndvidualNavigation()
        {
            try
            {
                //Dashboard documents counts
                NavigationToDocumentCountsPrivate();

                //Start new workflow 
                WorkflowLinkPrivate();

                //Personal settings
                PersonalSettingsOptionsPrivate();

                //Dashboard page footer settings
                PageFooterPrivate();

                //Menu options
                NavigationToMenuOptionsPrivate();
                
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Verify the links that navigate to counts
        /// </summary>        
        [Test]
        public void NavigationToDocumentCounts()
        {
            try
            {              
                NavigationToDocumentCountsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links of workflow
        /// </summary>
        [Test]
        public void WorkflowLink()
        {
            try
            {                
                WorkflowLinkPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Verify the links that to perosnal settings
        /// </summary>        
        [Test]
        public void PersonalSettingsOptions()
        {
            try
            {
                PersonalSettingsOptionsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }        

        /// <summary>
        /// Verify the links that to enterprise settings  links
        /// </summary>        
        [Test]
        public void EnterpriseSettingsOptions()
        {
            try
            {              
                EnterpriseSettingsOptionsPriavte();
                
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }        

        /// <summary>
        /// Verify the links that navigates to my settings method
        /// </summary>        
        [Test]
        public void NavigationToMySettings()
        {
            try
            {                
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                FindElement(driver, By.Id(Elements_Paths.Dashboard_MySettings_ID)).Click();                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links that navigates to enterprise settings method
        /// </summary>
        [Test]
        public void NavigationToEnterpriseSettings()
        {
            try
            {
                //Open menu options
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                //Click Enterprise Settings        
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Enterprise_Settings_ID)).Click();                                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links on page footer
        /// </summary>
        [Test]
        public void PageFooter()
        {
            try
            {               
                PageFooterPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Verify the links menu options
        /// </summary>
        [Test]
        public void NavigationToMenuOptions()
        {
            try
            {              
                NavigationToMenuOptionsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }     

        /// <summary>
        /// logged out user
        /// </summary>
        [Test]
        public void Logout()
        {
            try
            {
                Thread.Sleep(1000);
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Logout_ID)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Verify the links that navigate to counts  private method
        /// </summary>
        void NavigationToDocumentCountsPrivate()
        {
            try
            {                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                FindElement(driver, By.Id(Elements_Paths.Dashboard_Count_Pending_ID)).Click();
                Thread.Sleep(1000);

                //Clic Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click In Progress Count Filter    
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Count_InProgress_ID)).Click();
                Thread.Sleep(1000);

                //Click  Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Declined Count Filter    
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Count_Declined_ID)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(2000);

                //Click Completed Count Filter    
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Count_Completed_ID)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                string error = ex.StackTrace;
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links of workflow private method
        /// </summary>        
        void WorkflowLinkPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Click New Workflow link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_New_Workflow_CSSSelector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Cancel_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on workflow drop down     
                var dropdown = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Dropdown_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", dropdown);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);

                //Click Workflow only me link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Only_ME_CSSSelector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Cancel_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on workflow drop down     
                var dropdown1 = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Dropdown_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", dropdown1);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);

                //Click workflow just others link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Just_Others_CSSSelector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Cancel_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on workflow drop down     
                var dropdown2 = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Dropdown_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", dropdown2);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);

                //Click workflow me and others link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Me_Others_CSSSelector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Cancel_CSSSelector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }        

        /// <summary>
        /// Private methods for navigate to My settings
        /// </summary>
        void NavigationToMySettingsPrivate()
        {
            try
            {
                //Open menu options
                Thread.Sleep(2000);
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                //Click My Settings        
                FindElement(driver, By.Id(Elements_Paths.Dashboard_MySettings_ID)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Private methods to navigate to Enterprise settings
        /// </summary>
        void NavigationToEnterpriseSettingsPrivate()
        {
            try
            {
                //Open menu options
                Thread.Sleep(2000);
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                //Click Enterprise Settings        
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Enterprise_Settings_ID)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links that to perosnal settings priavte method
        /// </summary>        
        void PersonalSettingsOptionsPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Click on edit link of profile
                var edit = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Perosnal_Edit_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", edit);
                Thread.Sleep(1000);

                //Clic Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on template link    
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Personal_Templates_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click  Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on contact link    
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Personal_Contacts_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on delegate signing link  
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Personal_Delegate_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on notification link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Personal_Notifications_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click dashboard link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on signature setting link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Perosnal_Signature_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Dashboard link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on upgrade button
                var serviceplan = FindElement(driver, By.Id(Elements_Paths.Dashboard_Service_Plan_Button_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", serviceplan);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", serviceplan);
                Thread.Sleep(2000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Service_Cancel_Button_CSSSelector)).Click();

                //Click dashboard link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links that to enterprise settings private method
        /// </summary>
        void EnterpriseSettingsOptionsPriavte()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Click on users link                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_Users_CssSelector)).Click();
                Thread.Sleep(1000);

                //Clic Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on template link    
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_Templates_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click  Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on API key link   
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_APIKey_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on branding link 
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_Branding_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on conatct link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_Contacts_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on viaew user status link
                var view = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Enterprise_Users_View_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", view);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", view);
                Thread.Sleep(1000);

                //Click Home link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);              

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links on page footer private method
        /// </summary>
        void PageFooterPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Click on about link      
                var about = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Footer_About_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", about);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", about);
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Close_Model_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click local option
                var locale = FindElement(driver, By.Id(Elements_Paths.Dashboard_Locale_Dropdown_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", locale);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", locale);

                FindElement(driver, By.Id(Elements_Paths.Dashboard_Locale_ID)).Click();
                Thread.Sleep(1000);

                //Click on term of service
                var term = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_terms_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", term);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", term);
                Thread.Sleep(3000);

                ((IJavaScriptExecutor)driver).ExecuteScript("window.close('');");
                Thread.Sleep(3000);

                driver.SwitchTo().Window(driver.WindowHandles.First());

                //Log the test case                
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Verify the links menu option for enterprise private method
        /// </summary>
        void NavigationToMenuOptionsPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(2000);

                //Click on menu option                
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                //Click on Service Plan and upgade button  
                FindElement(driver, By.Id(Elements_Paths.Dashboard_ServicePlan_ID)).Click();
                Thread.Sleep(2000);

                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Service_Upgrade_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Back to first window
                driver.SwitchTo().Window(driver.WindowHandles.First());

                //Close model
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();                

                //Click on menu option                
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                //Click on billing       
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Billing_ID)).Click();
                Thread.Sleep(1000);

                //Click Dashboard link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on menu option                
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                //Click on About  and close dialogue      
                FindElement(driver, By.Id(Elements_Paths.Dashboard_About_ID)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Close_Model_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click Dashboard link to go back to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on menu option                
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();

                //Click on Help       
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Help_ID)).Click();
                Thread.Sleep(2000);

                ((IJavaScriptExecutor)driver).ExecuteScript("window.close('');");
                Thread.Sleep(3000);

                driver.SwitchTo().Window(driver.WindowHandles.First());

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }          
        
        #endregion
    }
}

