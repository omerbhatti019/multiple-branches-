using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture]
    public class Document_Share : General_Methods
    {        
        #region All Method

        /// <summary>
        /// All methods of document share
        /// </summary>
        [Test]
        public void AllShareDocument()
        {
            //Serial sahring of document
            SerialSharePrivate();

            //Parallel sahring of document
            ParallelSharePrivate();

            //Individual sahring of document
            IndividualSharePrivate();

            //Custom workflow sahring of document
            CustomWorkflowDocumentSharePrivate();

            //Bulk Share
            BulkSharePrivate();

            //Validate place holder check
            ValidatePlaceHolderRecipientPrivate();

            //Validate required signature filed for signer
            ValidateRequiredSignatureFieldForSignerPrivate();

            //Validate required sign filed for editor
            ValidateRequiredSignFieldForEditorPrivate();

            //Validate required sign filed for Meeting Host
            ValidateRequiredSignFieldForMeetingHostPrivate();

            //Validate invalid document for sharing (document provided by client)
            ValidateInvalidDocumentForSharingPrivate();

            LogTestCase(GetCurrentMethod());
        }

        #endregion

        #region Public Methods     

        /// <summary>
        /// Serial sahring of document
        /// </summary>
        [Test]
        public void DocumentSerialShare()
        {

            //Share document
            SerialSharePrivate();

            LogTestCase(GetCurrentMethod());
        }

        /// <summary>
        /// Parallel sahring of document
        /// </summary>
        [Test]
        public void DocumentParallelShare()
        {
            //Share document
            ParallelSharePrivate();

            LogTestCase(GetCurrentMethod());
        }

        /// <summary>
        /// Individual sahring of document
        /// </summary>
        [Test]
        public void DocumentIndividualShare()
        {
            //Share document
            IndividualSharePrivate();

            LogTestCase(GetCurrentMethod());
        }

        /// <summary>
        /// Custom workflow sahring of document
        /// </summary>
        [Test]
        public void CustomWorkflowDocumentShare()
        {
            try
            {
                CustomWorkflowDocumentSharePrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }

        /// <summary>
        /// Bulk sahring of document
        /// </summary>
        [Test]
        public void DocumentBulkShare()
        {
            try
            {
                BulkSharePrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }

        }

        /// <summary>
        /// Validate place holder check
        /// </summary>
        [Test]
        public void ValidatePlaceHolderRecipient()
        {
            try
            {
                ValidatePlaceHolderRecipientPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }

        /// <summary>
        /// Validate required signature filed for signer
        /// </summary>
        [Test]
        public void ValidateRequiredSignatureFieldForSigner()
        {
            try
            {
                ValidateRequiredSignatureFieldForSignerPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }

        /// <summary>
        /// Validate required sign filed for editor
        /// </summary>
        [Test]
        public void ValidateRequiredSignFieldForEditor()
        {
            try
            {
                ValidateRequiredSignFieldForEditorPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }

        /// <summary>
        /// Validate required sign filed for Meeting Host
        /// </summary>
        [Test]
        public void ValidateRequiredSignFieldForMeetingHost()
        {
            try
            {
                ValidateRequiredSignFieldForMeetingHostPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }

        /// <summary>
        /// Validate invalid document for sharing (document provided by client)
        /// </summary>
        [Test]
        public void ValidateInvalidDocumentForSharing()
        {
            try
            {
                ValidateInvalidDocumentForSharingPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message);
            }
        }  

        #endregion

        #region Private Methods
        /// <summary>
        /// Serial sahring of document
        /// </summary>       
        void SerialSharePrivate()
        {
            try
            {
                //Go to Dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add recipients
                AddRecipients();

                //Add signing fields
                AddSigningFields();

                //Share document
                ShareDocument();

                //Log test case
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Parallel sahring of document
        /// </summary>     
        void ParallelSharePrivate()
        {
            try
            {
                //Go to Dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add recipients
                AddRecipients();

                //open change workflow type cog
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Change_Workflow_Type_CSS_Selector)).Click();

                //set workflow type to parallel
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Change_Workflow_Type_Parallel_CSS_Selector)).Click();
                Thread.Sleep(1000);

                //set continue on decline option on
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Workflow_Type_Continue_On_Decline_XPath)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                //Add signing fields
                AddSigningFields();

                //Share document and log activity
                ShareDocument();

                //Log test case
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Individual sahring of document
        /// </summary>     
        void IndividualSharePrivate()
        {
            try
            {
                //Go to Dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Open change workflow type cog
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Change_Workflow_Type_CSS_Selector)).Click();

                //Set workflow type to Individual                
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Workflow_Type_Individual_XPath)).Click();
                Thread.Sleep(1000);

                //Click on save button                
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)))
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                    Thread.Sleep(1000);

                    //Add recipient
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                    Thread.Sleep(500);
                }

                //Click on first recipient
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient1_Click_XPath)).Click();
                Thread.Sleep(2000);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient1_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Tab key
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient2_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.Individual_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                Actions builder = new Actions(driver);

                //this is signature fields
                Thread.Sleep(3000);

                // Esign field
                IWebElement esignField = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder.ClickAndHold(esignField).MoveToElement(documentImage).Release(documentImage).Build().Perform();

                //Share document and log activity
                ShareDocument();


                //Log test case
                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Bulk sahring of document
        /// </summary>     
        void BulkSharePrivate()
        {
            try
            {
                //Go to listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                #region Add recipients

                if (IsElementExists(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)))
                {
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)).Click();
                    Thread.Sleep(1000);

                    //Add recipient
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                    Thread.Sleep(500);
                }

                //Click on first recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).Click();
                Thread.Sleep(1000);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.New_Workflow_Group_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Tab key
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient2_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                #endregion

                //Add signing field
                AddSigningFields();

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Add signing field
                AddSigningFields();

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Select Draft filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Draft_IdSelector)).Click();
                Thread.Sleep(2000);

                //Select first document
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Select_Document1_XPath)).Click();

                //Select second document
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Select_Document2_XPath)).Click();

                //Click on more options 
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_More_Options_XPath)).Click();

                //Click on bulk share option             
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Bulk_Share_XPath)).Click();

                //Click on template
                FindElement(driver, By.CssSelector(Elements_Paths.Bulk_Share_Apply_Template_CSSSelector)).Click();

                //Click on open drop down in template and select value
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.Workflow_Template_DropDown_CSSSelector)))
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Template_DropDown_CSSSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_DropDown_Value_CSSSelector)).Click();
                    Thread.Sleep(2000);
                }

                //Search for the document
                FindElement(driver, By.CssSelector(Elements_Paths.Template_Search_CSS_Selector)).SendKeys(TestData.Library_Search_Bulk_Share_Template);

                //Select the search result
                FindElement(driver, By.CssSelector(Elements_Paths.Library_Listing_Checkbox_CSS_Selector)).Click();

                //Apply template
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_Dialog_Box_CssSelector)).Click();
                Thread.Sleep(2000);

                //Click on share button             
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Close model             
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
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
        /// Start new workfolw and Upload document 
        /// </summary>
        void UploadDocument()
        {
            try
            {             
                //Click New Workflow link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_New_Workflow_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Click on library icon
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Upload_CSSSelector)).Click();

                //Search for the document
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(TestData.Document_Sample_PDF);

                //Select the search result
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

        /// <summary>
        /// Add Recipients
        /// </summary>
        void AddRecipients()
        {
            try
            {
                #region Add recipients

                if (IsElementExists(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)))
                {
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)).Click();
                    Thread.Sleep(1000);
                }

                //Add recipient
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on first recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).Click();
                Thread.Sleep(2000);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient1_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Tab key
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient2_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                #endregion              
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
                Thread.Sleep(4000);             

                Actions builder = new Actions(driver);

                //this is signature fields
                Thread.Sleep(1000);

                // Esign field
                IWebElement esignField = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder.ClickAndHold(esignField).MoveToElement(documentImage, 200, 200).Release().Build().Perform();

                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();
                Thread.Sleep(1000);

                Actions builder2 = new Actions(driver);

                //this is signature fields
                Thread.Sleep(1000);

                // Esign field
                IWebElement esignField2 = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage2 = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder2.ClickAndHold(esignField2).MoveToElement(documentImage2, 400, 200).Release().Build().Perform();
                Thread.Sleep(1000);                
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
                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(4000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate place holder check
        /// </summary>
        void ValidatePlaceHolderRecipientPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Upload document
                UploadDocument();

                #region Add Placeholder as Recipient

                if (IsElementExists(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)))
                {
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)).Click();
                    Thread.Sleep(1000);

                    //Add recipient
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                    Thread.Sleep(500);
                }

                //Delete Recipient
                FindElement(driver, By.CssSelector(Elements_Paths.Start_New_Workflow_Delete_Recipient_Css_Celector)).Click();

                //Add place holder
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Placeholder_Click_CSS_Selector)).Click();
                Thread.Sleep(500);

                //click on placeholder text
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Placeholder_CSS_Selector)).Click();
                Thread.Sleep(1000);

                //enter placeholder text
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Placeholder_CSS_Selector)).SendKeys(TestData.New_Workflow_Recipient2_Name);

                //press tab for blur
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Placeholder_CSS_Selector)).SendKeys(Keys.Tab);
                Thread.Sleep(1000);

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                #endregion

                #region Add signing fields

                Actions builder = new Actions(driver);

                //this is signature fields
                Thread.Sleep(1000);

                // Esign field
                IWebElement esignField = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder.ClickAndHold(esignField).MoveToElement(documentImage).Release(documentImage).Build().Perform();
                Thread.Sleep(1000);

                #endregion

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Plache_Holder_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod());

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate required signature filed for signer
        /// </summary>
        void ValidateRequiredSignatureFieldForSignerPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Upload document
                UploadDocument();

                AddRecipients();

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Signature_Field_Required_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Signature_Field_Required_Error_Message, new Exception());

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);              
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate required sign filed for editor
        /// </summary>
        void ValidateRequiredSignFieldForEditorPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Upload document
                UploadDocument();

                AddRecipients();

                //Change signer type
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_First_Recipient_Change_Type_Click_CSS_Selector)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Recipient_Change_Type_Editor_CSS_Selector)).Click();
                Thread.Sleep(1000);

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Signature_Field_Required_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Signature_Field_Required_Error_Message, new Exception());

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate required sign filed for Meeting Host
        /// </summary>
        void ValidateRequiredSignFieldForMeetingHostPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Upload document
                UploadDocument();

                AddRecipients();

                //Change signer type
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_First_Recipient_Change_Type_Click_CSS_Selector)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Recipient_Change_Type_Meeting_Host_CSS_Selector)).Click();
                Thread.Sleep(1000);

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Signature_Field_Required_Error_Message, message.Text);

                    LogResult(GetCurrentMethod(), message.Text);
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Signature_Field_Required_Error_Message, new Exception());

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);
               
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate invalid document for sharing (document provided by client)
        /// </summary>
        void ValidateInvalidDocumentForSharingPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click New Workflow link
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_New_Workflow_CSSSelector)).Click();
                Thread.Sleep(3000);
              
                //Upload document
                UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Invalid_PDF_For_Shairing_Or_Signing, 4000);

                AddRecipients();

                AddSigningFields();

                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Invalid_Document_For_Sharing_Error_Message, message.Text);

                    LogResult(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Invalid_Document_For_Sharing_Error_Message, new Exception());

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Custom workflow sahring of document
        /// </summary>     
        void CustomWorkflowDocumentSharePrivate()
        {
            try
            {
                //Go to Dashboard
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Change workflow type
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Custom_Workflow_Type_CSS_Selector)).Click();

                if (IsElementExists(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)))
                {
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Change_Recipient1_Delete_Click_XPath)).Click();
                    Thread.Sleep(1000);

                    //Add recipient
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                    Thread.Sleep(500);
                }

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.Email_Address);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Tab key
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

                //Click on second order
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Custom_Second_Recipient_Order_CSS_Selector)).Clear();

                //Add order number
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Custom_Second_Recipient_Order_CSS_Selector)).SendKeys("3");

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient2_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Add order number
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Custom_Third_Recipient_Order_CSS_Selector)).Clear();
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Add_Custom_Third_Recipient_Order_CSS_Selector)).SendKeys("1");

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient3_Click_XPath)).SendKeys(TestData.New_Workflow_Recipient1_Name);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient3_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                //Add signing fields
                AddSigningFields();

                //Click on third collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer3_CSS_Selector)).Click();
                Thread.Sleep(1000);

                Actions builder2 = new Actions(driver);

                //this is signature fields
                Thread.Sleep(3000);

                // Esign field
                IWebElement esignField2 = driver.FindElement(By.CssSelector(Elements_Paths.Templates_EsignField_CssSelector));

                //Image of document
                IWebElement documentImage2 = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder2.ClickAndHold(esignField2).MoveToElement(documentImage2, 250, 300).Release().Build().Perform();
                Thread.Sleep(1000);

                //Share document and log activity
                ShareDocument();

                //Log test case
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
