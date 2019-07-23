//This changes done by omer for jenkins 
//This changes done by omer for jenkins 
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    /// <summary>
    /// Apply template
    /// </summary>
    public class Apply_Template : General_Methods
    {
        #region Test All template methods

        ///<summary>
        /// Test All template methods
        /// </summary>
        [Test]
        public void ApplyTemplateAll()
        {
            try
            {
                //Apply Template on signle document
                ApplyTemplateOnSingleDocumentPrivate();

                //Apply Template on mutiple document
                ApplyTemplateOnMultipleDocumentPrivate();

                //Apply Template sequential workflow
                ApplyTemplateSequentialWorkflowPrivate();

                //Apply Template parallel workflow
                ApplyTemplateParallelWorkflowPrivate();

                //Apply Template individual workflow
                ApplyTemplateIndivdiualWorkflowPrivate();

                //Apply Template workflow only me
                ApplyTemplateWorkflowOnlyMePrivate();

                //Apply Template of form fields
                ApplyTemplateFormFieldsPrivate();

                //Apply Template with same number of pages
                ValidateApplyTemplateWithSamePagesPrivate();

                //Validate apply Template with pdf form fields
                ValidateApplyTemplateWithPdfFormFieldsPrivate();

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
        /// Apply Template on signle document
        /// </summary>
        [Test]
        public void ApplyTemplateOnSingleDocument()
        {
            try
            {
                ApplyTemplateOnSingleDocumentPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template on mutiple document
        /// </summary>
        [Test]
        public void ApplyTemplateOnMultipleDocument()
        {
            try
            {
                ApplyTemplateOnMultipleDocumentPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template sequential workflow
        /// </summary>         
        [Test]
        public void ApplyTemplateSequentialWorkflow()
        {
            try
            {
                ApplyTemplateSequentialWorkflowPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template parallel workflow
        /// </summary>
        [Test]
        public void ApplyTemplateParallelWorkflow()
        {
            try
            {
                ApplyTemplateParallelWorkflowPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template individual workflow
        /// </summary>             
        [Test]
        public void ApplyTemplateIndivdiualWorkflow()
        {
            try
            {
                ApplyTemplateIndivdiualWorkflowPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template workflow only me
        /// </summary>        
        [Test]
        public void ApplyTemplateWorkflowOnlyMe()
        {
            try
            {
                ApplyTemplateWorkflowOnlyMePrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template of form fields
        /// </summary>               
        [Test]
        public void ApplyTemplateFormFields()
        {
            try
            {
                ApplyTemplateFormFieldsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template with same number of pages
        /// </summary>              
        [Test]
        public void ValidateApplyTemplateWithSamePages()
        {
            try
            {
                ValidateApplyTemplateWithSamePagesPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate apply Template with pdf form fields
        /// </summary>        
        [Test]
        public void ValidateApplyTemplateWithPdfFormFields()
        {
            try
            {
                ValidateApplyTemplateWithPdfFormFieldsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Private Methods

        void ApplyTemplateOnSingleDocumentPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload Document
                UploadDocument(TestData.Library_Search_Template_Document);

                //Apply template
                SelectTemplate(TestData.Library_Search_Sequential_Workflow_Template);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Share Document
                ShareDocument();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template on mutiple document private method
        /// </summary>
        void ApplyTemplateOnMultipleDocumentPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Library_Search_Template_Document, true);

                //Apply template
                SelectTemplate(TestData.Library_Search_Sequential_Workflow_Template, true);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Share Document
                ShareDocument();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template sequential workflow private Method
        /// </summary>        
        void ApplyTemplateSequentialWorkflowPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Library_Search_Sequential_Workflow_Template);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Share Document
                ShareDocument();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template parallel workflow private method
        /// </summary>        
        void ApplyTemplateParallelWorkflowPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Library_Search_Parallel_Workflow_Template);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Share Document
                ShareDocument();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template individual workflow private method
        /// </summary>        
        void ApplyTemplateIndivdiualWorkflowPrivate()
        {
            try
            {
                //Go to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document 
                UploadDocument(TestData.Library_Search_Indivdiual_Workflow_Template);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Share Document
                ShareDocument();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template workflow only me private method
        /// </summary>        
        void ApplyTemplateWorkflowOnlyMePrivate()
        {
            try
            {
                //Go to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Click on Workflow drop down
                var dropdown = FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Dropdown_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", dropdown);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dropdown);

                //Click Workflow only me link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Workflow_Only_ME_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Click on library icon
                var library = FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Document_ClassName));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", library);

                //Click on open drop down in library and select value
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_CSSSelector)))
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_CSSSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_Value_CSSSelector)).Click();
                }

                //Click on search field and perform search for template
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Search_CSSSelector)).Click();
                driver.FindElement(By.CssSelector(Elements_Paths.Workflow_Library_Search_CSSSelector)).SendKeys(TestData.Library_Search_Workflow_Only_Me_Template);

                //Select document having template
                var checkbox = FindElement(driver, By.Id(Elements_Paths.Workflow_Library_ALL_CheckBox_ID));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);

                //Click on done button so apply template
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Done_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Fill form fields
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Field_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Field_Name)).SendKeys(TestData.Workflow_Only_Me_Field_Name);
                Thread.Sleep(1000);

                //Fill initial Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Text_CSSSelector)).Click();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).Click();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).SendKeys(TestData.Workflow_Only_Me_Initial_Signer_Name);

                //Click on done button to fill initial
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Fill In-Person Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on done button to fill in-person
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Fill Hand Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_HandSignature_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();
                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(200, 20).Release().Build().Perform();

                //Click on done button to fill hand signature
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();
                var drawSign = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder1 = new Actions(driver);
                builder1.ClickAndHold(drawSign).MoveByOffset(300, 30).Release().Build().Perform();

                //Click on done button to sign signature field
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click to finish workflow only me
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Apply Template of form fields private method
        /// </summary>        
        void ApplyTemplateFormFieldsPrivate()
        {
            try
            {
                //Go to dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Library_Search_Form_fields_Template);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ValidateApplyTemplateWithSamePagesPrivate()
        {
            try
            {
                //Go to dashboard              
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document 
                UploadDocument(TestData.Document_Sample_PDF);

                //Apply template
                SelectTemplate(TestData.Library_Search_Multiple_Pages_Template);

                IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Template_Same_Pages_Required_Error_Message, message.Text);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ValidateApplyTemplateWithPdfFormFieldsPrivate()
        {
            try
            {
                //Go to dashboard              
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document 
                UploadDocument(TestData.Document_Sample_PDF);

                //Apply template
                SelectTemplate(TestData.Library_Search_Form_fields_Template);

                IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Template_Form_Fields_Required_Error_Message, message.Text);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UploadDocument(string document, bool isAllDocs = false)
        {
            try
            {
                //Click New Workflow link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_New_Workflow_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on library icon
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Upload_CSSSelector)).Click();

                //Click on open drop down in library and select value 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_CSSSelector)))
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_CSSSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_Value_CSSSelector)).Click();
                }

                //Search for the document
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(document);

                //Select the search result
                if (isAllDocs)
                {
                    //Select Document 
                    var checkbox = FindElement(driver, By.Id(Elements_Paths.Workflow_Library_ALL_CheckBox_ID));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);
                }
                else
                    FindElement(driver, By.CssSelector(Elements_Paths.Library_Listing_Checkbox_CSS_Selector)).Click();

                //Click done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void SelectTemplate(string template, bool isAll = false)
        {
            try
            {
                //Click to select template form start new workflow
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Template_Selection_CSSSelector)).Click();

                //Click on open drop down in template and select value
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Workflow_Template_DropDown_CSSSelector)))
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Template_DropDown_CSSSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_Value_CSSSelector)).Click();
                    Thread.Sleep(2000);
                }

                //Click on search field and perform search for template                
                driver.FindElement(By.CssSelector(Elements_Paths.Workflow_Library_Search_CSSSelector)).SendKeys(template);

                //Select Template
                var radio = FindElement(driver, By.Name(Elements_Paths.Workflow_Template_Select_Radio_Name));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", radio);
                Thread.Sleep(1000);

                //Click on Apply button
                if (isAll)
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Default_Button_CSSSelector)).Click();
                else
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                Thread.Sleep(6000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ShareDocument()
        {
            try
            {
                //Click on Share button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
    }
}
