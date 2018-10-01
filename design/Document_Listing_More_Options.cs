using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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
    public class Document_Listing_More_Options : General_Methods
    {
        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region All Method

        /// <summary>
        /// Test all more options methods
        /// </summary>
        [Test]
        public void MoreOptionsAllMethods()
        {
            try
            {
                //Validate document opening permission
                ValidateDocumentOpeningPasswordPrivate();

                //Validate document opening permission with OTP
                ValidateDocumentOpeningOTPPrivate();

                // Validate alert in case of print not allowed 
                ValidatePrintDocumentOptionInPendingPrivate();

                // Validate alert in case of download not allowed 
                ValidateDownloadDocumentOptionInPendingPrivate();

                //Validate document download with password
                ValidateDocumentPasswordOnDownloadDocumentPrivate();

                //Validate OTP on document download
                ValidateDocumentOTPOnDownloadDocumentPrivate();

                //Validate document password on print document from listing
                ValidateDocumentPasswordOnPrintDocumentPrivate();

                //Validate OTP on document print from listing
                ValidateDocumentOTPOnPrintDocumentPrivate();

                //Validate document access duration on print/download document
                ValidateDocumentAccessOnPrintDownloadDocumentPrivate();          
           
                //Validate document access duration via days on print/download document
                ValidateDocumentAccessViaDaysOnPrintDownloadDocumentPrivate();              

                //Preview Document
                PreviewDocumentPrivate();

                //Download Document 
                DownloadDocumentPrivate();

                //Delete Document
                DeleteDocumentPrivate();

                //Send reminder
                SendReminderPrivate();

                //Rename Document package 
                RenameDocumentPrivate();

                //Add comment on document package 
                AddCommentOnDocumentPrivate();

                //Print document fron document listing
                PrintDocumentPrivate();

                //Start new workflow from document listing
                StartNewWorkflowPrivate();

                //Workflow history from document listing
                WorkflowHistoryPrivate();

                //Download Evidence Report
                WorkflowEvidenceReportPrivate();

                //Document Move To folder
                MoveToFolderPrivate();

                //Recall document from document listing
                RecallDocumentPrivate();

                //Validate download document size limit
                ValidateDownloadDocumentSizeLimitPrivate();

                //Validate bulk sign document limit
                ValidateBulkSignDocumentLimitPrivate();                        

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
        /// Pre-view document from document listing 
        /// </summary>
        [Test]
        public void PreviewDocument()
        {
            try
            {
                PreviewDocumentPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Download document from document listing 
        /// </summary>
        [Test]
        public void DownloadDocument()
        {
            try
            {
                DownloadDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Download document from document listing 
        /// </summary>
        [Test]
        public void DeleteDocument()
        {
            try
            {
                DeleteDocumentPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Send reminder from document listing 
        /// </summary>
        [Test]
        public void SendReminder()
        {
            try
            {
                SendReminderPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Rename Document from document listing 
        /// </summary>
        [Test]
        public void RenameDocument()
        {
            try
            {
                RenameDocumentPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add comment on document package from document listing
        /// </summary>
        [Test]
        public void AddCommentOnDocument()
        {
            try
            {
                AddCommentOnDocumentPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Print document package from document listing
        /// </summary>
        [Test]
        public void PrintDocument()
        {
            try
            {
                PrintDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Start new workflow from document listing
        /// </summary>
        [Test]
        public void StartNewWorkflow()
        {
            try
            {
                StartNewWorkflowPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow history from document listing
        /// </summary>
        [Test]
        public void WorkflowHistory()
        {
            try
            {
                WorkflowHistoryPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow evidence report from document listing
        /// </summary>
        [Test]
        public void WorkflowEvidenceReport()
        {
            try
            {

                WorkflowEvidenceReportPrivate();
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Document Move To folder
        /// </summary>
        [Test]
        public void MoveToFolder()
        {
            try
            {
                MoveToFolderPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Recall document from document listing 
        /// </summary>
        [Test]
        public void RecallDocument()
        {
            try
            {
                RecallDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate download document size limit 
        /// </summary>
        [Test]
        public void ValidateDownloadDocumentSizeLimit()
        {
            try
            {
                ValidateDownloadDocumentSizeLimitPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate bulk sign document limit 
        /// </summary>
        [Test]
        public void ValidateBulkSignDocumentLimit()
        {
            try
            {
                ValidateBulkSignDocumentLimitPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document opening permission
        /// </summary>
        [Test]
        public void ValidateDocumentOpeningPassword()
        {
            try
            {
                ValidateDocumentOpeningPasswordPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document opening permission with OTP
        /// </summary>
        [Test]
        public void ValidateDocumentOpeningOTP()
        {
            try
            {
                ValidateDocumentOpeningOTPPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate bulk sign alert in case of mobile signing
        /// </summary>
        [Test]
        public void ValidateBulkSignAlertInCaseOfMobileSigning()
        {
            try
            {
                ValidateBulkSignAlertInCaseOfMobileSigningPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate alert in case of print not allowed 
        /// </summary>
        [Test]
        public void ValidatePrintDocumentOptionInPending()
        {
            try
            {
                ValidatePrintDocumentOptionInPendingPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate alert in case of download not allowed 
        /// </summary>
        [Test]
        public void ValidateDownloadDocumentOptionInPending()
        {
            try
            {
                ValidateDownloadDocumentOptionInPendingPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document download with password
        /// </summary>
        [Test]
        public void ValidateDocumentPasswordOnDownloadDocument()
        {
            try
            {
                ValidateDocumentPasswordOnDownloadDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate OTP on document download
        /// </summary>
        [Test]
        public void ValidateDocumentOTPOnDownloadDocument()
        {
            try
            {
                ValidateDocumentOTPOnDownloadDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document password on print document from listing
        /// </summary>
        [Test]
        public void ValidateDocumentPasswordOnPrintDocument()
        {
            try
            {
                ValidateDocumentPasswordOnPrintDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        ///  Validate OTP on document print from listing
        /// </summary>
        [Test]
        public void ValidateDocumentOTPOnPrintDocument()
        {
            try
            {
                ValidateDocumentOTPOnPrintDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        ///  Validate document access duration on print/download document
        /// </summary>
        [Test]
        public void ValidateDocumentAccessOnPrintDownloadDocument()
        {
            try
            {
                ValidateDocumentAccessOnPrintDownloadDocumentPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }   

        /// <summary>
        ///  Validate document OTP for perview
        /// </summary>
        [Test]
        public void ValidateDocumentAccessViaDaysOnPrintDownloadDocument()
        {
            try
            {
                ValidateDocumentAccessViaDaysOnPrintDownloadDocumentPrivate();

                //Log test case
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
        /// Pre-view document from document listing 
        /// </summary>        
        void PreviewDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select all filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Draft_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Pre-view document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Preview_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Close Pre-view document
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                
                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Download document from document listing 
        /// </summary>        
        void DownloadDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Download document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Activity validation
                IWebElement DownloadDocumentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Downloaded_Activity, DownloadDocumentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Download document from document listing 
        /// </summary>        
        void DeleteDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select Draft filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Draft_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Delete document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Delete_Document_CSS_Selector)).Click();

                //Confirm delete                
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Document_Deleted_Success_Message, ToasterMessage.Text);
                Thread.Sleep(1000);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                ////Activity validation
                IWebElement DeleteDocumentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Deleted_Activity, DeleteDocumentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Send reminder from document listing 
        /// </summary>        
        void SendReminderPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select Inprogress filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Inprogress_IdSelector)).Click();
                Thread.Sleep(1000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on reminder button
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Send_Reminder_CSS_Selector)).Click();

                //Send Reminder                
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.IsTrue(ToasterMessage.Text.Contains(TestData.Send_Reminder_Success_Message));
                Thread.Sleep(1000);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Activity validation
                IWebElement ReminderActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Send_Reminder_Activity, ReminderActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Rename Document from document listing 
        /// </summary>        
        void RenameDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Select Draft filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Draft_IdSelector)).Click();
                Thread.Sleep(1000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on rename option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Rename_Document_XPath)).Click();

                //Add new name of package
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Rename_Document_Field_CssSelector)).SendKeys(TestData.Document_Rename_Tetx);

                //Click on save button                
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                Thread.Sleep(2000);

                //Activity validation
                IWebElement RenameDocumentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Rename_Activity, RenameDocumentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add comment on document package from document listing
        /// </summary>        
        void AddCommentOnDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on comment option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Comment_On_Document_XPath)).Click();

                //Add new commont on package
                FindElement(driver, By.XPath(Elements_Paths.Document_Comment_TextArea_Field_XPath)).SendKeys(TestData.Document_Comment_Tetx);

                //Click on save button                
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Close comment model                
                FindElement(driver, By.XPath(Elements_Paths.Document_Comment_Model_Close_XPath)).Click();

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                Thread.Sleep(2000);

                //Activity validation
                IWebElement AddCommentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Comment_Activity, AddCommentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Print document package from document listing
        /// </summary>        
        void PrintDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on print option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                Thread.Sleep(2000);

                var windows = driver.WindowHandles;
                driver.SwitchTo().Window(windows[1]);
                driver.Close();
                Thread.Sleep(2000);

                //Move to first window
                driver.SwitchTo().Window(windows[0]);

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                Thread.Sleep(2000);

                //Activity validation
                IWebElement PrintDocumentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Print_Activity, PrintDocumentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Start new workflow from document listing
        /// </summary>
        void StartNewWorkflowPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on start new work flow option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Start_New_WorkFlow_XPath)).Click();
                Thread.Sleep(2000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow history from document listing
        /// </summary>
        void WorkflowHistoryPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select Inprogress filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Inprogress_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on work flow history option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_WorkFlow_History_XPath)).Click();
                Thread.Sleep(1000);

                //Send text for search work flow history
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_WorkFlow_History_Search_CSSSelector)).SendKeys(TestData.WorkFlow_History_Search_Text);
                Thread.Sleep(2000);

                //Search work flow history option                
                FindElement(driver, By.CssSelector(Elements_Paths.WorkFlow_History_Search_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Clear search work flow history option                
                FindElement(driver, By.CssSelector(Elements_Paths.Clear_Search_CssSelector)).Click();
                Thread.Sleep(1000);

                //Close work flow history model
                FindElement(driver, By.XPath(Elements_Paths.Model_Close_XPath)).Click();
                Thread.Sleep(1000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow evidence report from document listing
        /// </summary>        
        void WorkflowEvidenceReportPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();

                //Select Inprogress filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Decined_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();


                try
                {
                    //Click on Workflow Evidence Report option                
                    FindElement(driver, By.XPath(Elements_Paths.Document_listing_Workflow_Evidence_Report_XPath)).Click();
                    Thread.Sleep(4000);
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Workflow evidence option is not enabled in serviceplan", ex);
                }

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Activity validation
                IWebElement EvidenceReportActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Downloaded_Activity, EvidenceReportActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Document Move To folder
        /// </summary>        
        void MoveToFolderPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on move to option             
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Move_To_XPath)).Click();

                //Click on Archive folder              
                FindElement(driver, By.XPath(Elements_Paths.Document_Move_To_Folder_XPath)).Click();

                //Click on save              
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Move_To_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.IsTrue(ToasterMessage.Text.Contains(TestData.Document_Move_To_Success_Message));

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Activity validation
                IWebElement MovetoFolderActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Move_To_Folder_Activity, MovetoFolderActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Recall document from document listing 
        /// </summary>        
        void RecallDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select Inprogress filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Inprogress_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on recall option
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Recall_Document_XPath)).Click();

                //Recall document                
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(1000);

                //Success message validation
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.IsTrue(ToasterMessage.Text.Contains(TestData.Document_Recall_Success_Message));

                //Go to user activity log
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Activity validation
                IWebElement RecallDocumentActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Document_Recall_Activity, RecallDocumentActivity.Text);
                Thread.Sleep(2000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate download document size limit
        /// </summary>
        void ValidateDownloadDocumentSizeLimitPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select All filter
                FindElement(driver, By.Id(Elements_Paths.Filter_All_IdSelector)).Click();
                Thread.Sleep(1000);

                //Select all documents           
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Document_listing_Select_All_Documents_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Download documents
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();

                //Download documents wait
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)));

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Document_Download_Limit_Exceeds_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate bulk sign document limit
        /// </summary>
        void ValidateBulkSignDocumentLimitPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select pending filters
                FindElement(driver, By.Id(Elements_Paths.Filter_Pending_IdSelector)).Click();
                Thread.Sleep(1000);

                //Select all documents           
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Document_listing_Select_All_Documents_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Bulk sign documents
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Bulk_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document opening permission with password
        /// </summary>
        void ValidateDocumentOpeningPasswordPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set password permission           
                var passwordCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", passwordCheckbox);

                //Add password
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).SendKeys(TestData.Document_Access_Password);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Open document
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Open_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Click on Open button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(500);

                //Add worng password
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).SendKeys(TestData.Document_Access_Wrong_Password);

                //Click on Open button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Clear field
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).Clear();

                //Add Correct password
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).SendKeys(TestData.Document_Access_Password);

                //Click on Open button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document opening permission with OTP
        /// </summary>
        void ValidateDocumentOpeningOTPPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);

                //Set OTP permission           
                var otpRadiobox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_OTP_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", otpRadiobox);

                //Set OTP Number
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_OTP_Field_By_Name)).SendKeys(TestData.Mobile_Number);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Open document
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Open_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Click on Open button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on Close model
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Start new workfolw and Upload document 
        /// </summary>
        void UploadDocument()
        {
            try
            {

                #region Upload document

                //Click New Workflow link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_New_Workflow_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on library icon
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Upload_CSSSelector)).Click();

                //Search for the document
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(TestData.Sample_Upload_Third_Party_Document_Name);

                //Select the search result
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Upload_Library_Search_Searched_Document)).Click();

                //Click done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                #endregion

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void AddRecipients()
        {
            try
            {
                if (IsElementExists(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath))) ;
                {
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)).Click();
                    Thread.Sleep(1000);
                }

                //Add recipient
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                Thread.Sleep(500);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.Email_Address);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);                

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.Email_Address);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add signing fields
        /// </summary>
        void AddSigningFields()
        {
            try
            {
                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                #region Add signing fields

                Actions builder = new Actions(driver);

                Thread.Sleep(2000);
                // Esign field
                IWebElement esignField = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder.ClickAndHold(esignField).MoveToElement(documentImage, 200, 400).Release(documentImage).Build().Perform();

                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();
                Thread.Sleep(1000);

                Actions builder2 = new Actions(driver);              

                // Esign field
                IWebElement esignField2 = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage2 = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image2_CSS_Selector));

                //  Dropping field at location
                builder2.ClickAndHold(esignField2).MoveToElement(documentImage2).Release(documentImage2).Build().Perform();
                Thread.Sleep(1000);

                #endregion              
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ValidateBulkSignAlertInCaseOfMobileSigningPrivate()
        {
            try
            {
                //Consent ID Login 
                new Login().ConsentIDLogin();
                Thread.Sleep(3000);

                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select pending filters
                FindElement(driver, By.Id(Elements_Paths.Filter_Pending_IdSelector)).Click();
                Thread.Sleep(1000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Bulk sign documents
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Bulk_CSS_Selector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Bulk_Sign_Next_Button_Css_Selector)).Click();
                Thread.Sleep(1000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Bulk_Sign_Using_Mobile_Signing_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod());

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate alert in case of print not allowed 
        /// </summary>
        void ValidatePrintDocumentOptionInPendingPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Permission_Allow_Print_Css_Selecter));
                if(permissionCheckbox.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);
                
                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on print option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Print_Document_Not_Allowed_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to print in this case", new Exception());
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Validate alert in case of download not allowed 
        /// </summary>
        void ValidateDownloadDocumentOptionInPendingPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Permission_Allow_Download_Css_Selecter));
                if(permissionCheckbox.Selected)
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();
                
                //Download document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Download_Document_Not_Allowed_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to download in this case", new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document download with password
        /// </summary>
        void ValidateDocumentPasswordOnDownloadDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set password permission           
                var passwordCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", passwordCheckbox);

                //Add password
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).SendKeys(TestData.Document_Access_Password);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Download document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Download_Document_Via_Password_Error_Message, message.Text);
                    message.Click();

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to download in this case", new Exception());                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate OTP on document download 
        /// </summary>
        void ValidateDocumentOTPOnDownloadDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);

                //Set OTP permission           
                var otpRadiobox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_OTP_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", otpRadiobox);

                //Set OTP Number
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_OTP_Field_By_Name)).SendKeys(TestData.Mobile_Number);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Download document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Download_Document_With_OTP_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to download in this case", new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document password on print document from listing
        /// </summary>
        void ValidateDocumentPasswordOnPrintDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set password permission           
                var passwordCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", passwordCheckbox);

                //Add password
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_Password_Field_By_Name)).SendKeys(TestData.Document_Access_Password);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on print option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Print_Document_With_Password_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to print in this case", new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate OTP on document print from listing
        /// </summary>
        void ValidateDocumentOTPOnPrintDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_Password_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);

                //Set OTP permission           
                var otpRadiobox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Permission_OTP_By_Id));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", otpRadiobox);

                //Set OTP Number
                FindElement(driver, By.Name(Elements_Paths.Document_Access_Permission_OTP_Field_By_Name)).SendKeys(TestData.Mobile_Number);

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on print option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Print_Document_With_OTP_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document Should not allowed to print in this case", new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document access duration on print/download document
        /// </summary>
        void ValidateDocumentAccessOnPrintDownloadDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on permissions
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Access_Permission_Css_Selecter)).Click();
                Thread.Sleep(1000);

                //Set permission           
                var permissionCheckbox = FindElement(driver, By.Id(Elements_Paths.Document_Access_Duration_Permission_Css_Selecter));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", permissionCheckbox);
                Thread.Sleep(1000);

                //Click on document access from date
                FindElement(driver, By.XPath(Elements_Paths.Document_Access_Permission_From_Date)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.XPath(Elements_Paths.Permission_Select_From_Date_XPath)).Click();                     

                //submit the form
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Select document
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                //Download document
                FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Document_Access_Duration_Message, message.Text);
                    message.Click();
                    Thread.Sleep(1000);

                }

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on print option                
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Document_Access_Duration_Message, message.Text);
                    message.Click();
                    Thread.Sleep(1000);
                }
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate document access duration via days on print/download document
        /// </summary>
        void ValidateDocumentAccessViaDaysOnPrintDownloadDocumentPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Add text in search field and perform search          
                driver.FindElement(By.CssSelector(Elements_Paths.Document_Listing_Search_CssSelector)).SendKeys(TestData.Expire_Document_Access);
                
                //Click on search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Submit_Search_CssSelector)).Click();
                Thread.Sleep(3000);

                if (IsElementExists(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)))
                {
                    //Select document
                    FindElement(driver, By.XPath(Elements_Paths.Document_listing_Select_First_Document_XPath)).Click();

                    //Download document
                    FindElement(driver, By.CssSelector(Elements_Paths.Document_listing_Download_Document_CSS_Selector)).Click();
                    Thread.Sleep(2000);

                    //Validate error message
                    if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    {
                        IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                        Assert.AreEqual(TestData.Document_Access_Duration_Message, message.Text);
                        message.Click();
                    }

                    //Click on more options 
                    FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                    //Click on print option                
                    FindElement(driver, By.XPath(Elements_Paths.Document_listing_Print_Document_XPath)).Click();
                    Thread.Sleep(2000);

                    //Validate error message
                    if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                    {
                        IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                        Assert.AreEqual(TestData.Document_Access_Duration_Message, message.Text);
                        message.Click();
                    }

                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), "Document not exist or deleted");                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
    }
}
