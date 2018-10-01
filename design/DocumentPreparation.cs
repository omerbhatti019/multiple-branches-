using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture][Parallelizable]
    /// <summary>
    /// Document Viewer
    /// </summary>
    public class DocumentPreparation : General_Methods
    {
        #region All test methods for SNF screen
        /// <summary>
        /// Run all document preparation methods
        /// </summary>
        [Test]
        public void RunAllDocumentPreparationTestMethods()
        {
            try
            {
                new NewWorkflowUploadDocument().RunAllNewWorkflowUploadDocumentTestMethods();
                new NewWorkflowRecipientActions().RunAllNewWorkflowRecipientsActionTestMethods();
                new NewWorkflowDocumentActions().RunAllNewWorkflowDocumentActionTestMethods();
                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();

                //Close document
                Thread.Sleep(3000);
                new Viewer_MoreAction().Viewer_Close_Package_Common();
                Thread.Sleep(5000);
                ////Click on NEXT button
                //FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                //Thread.Sleep(5000);
                //new DocumentViewer().RunAllActionsOnFields();
                //Thread.Sleep(2000);
                //new Viewer_MoreAction().Viewer_Close_Package_Common();
                //Thread.Sleep(2000);
                //new Viewer_MoreAction().Viewer_All_More_Actions();
                //Thread.Sleep(5000);
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