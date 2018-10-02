using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace IntegrationTest
{
    [TestFixture][Parallelizable]
    public class Draft_Mode_Workflow : General_Methods
    {        
        #region All Method

        /// <summary>
        /// All methods of draft mode
        /// </summary>
        [Test]
        public void All_Draft_Worflows()
        {
            try
            {
                //Validate hand signature required before main task sign in draft mode
                ValidateHandSignaturInDraftWokflowPrivate();

                //Validate Inperson sign required before main task sign in draft mode
                ValidateInPersonInDraftWokflowPrivate();

                //Validate Initial sign required before main task sign in draft mode
                ValidateInitialInDraftWokflowPrivate();

                //Validate signer turn in draft mode  
                ValidateSignerTurnInDraftWokflowPrivate();

                //Validate certify with no changes actions
                ValidateCertifyWithNoChangesPrivate();

                //Validate only E-Sign allowed to add
                ValidateESignOnlyAllowedToAddPrivate();

                //Validate only D-Sign allowed to add
                ValidateDSignOnlyAllowedToAddPrivate();

                ESigner_Draft_Wokflowprivate();

                DSigner_Draft_WokflowPrivate();

                Reviewer_Draft_WokflowPrivate();

                Editor_Draft_WokflowPrivate();

                MeetingHost_Draft_WokflowPrivate();

                SentACOPY_Draft_WokflowPrivate();

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
        /// Workflow only me as Esigner in draft mode
        /// </summary>
        [Test]
        public void ESigner_Draft_Wokflow()
        {
            try
            {
                ESigner_Draft_Wokflowprivate(); 

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow only me as Digital signer in draft mode
        /// </summary>
        [Test]
        public void DSigner_Draft_Wokflow()
        {
            try
            {
                DSigner_Draft_WokflowPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Workflow only me as Reviewer in draft mode
        /// </summary>
        [Test]
        public void Reviewer_Draft_Wokflow()
        {
            try
            {
                Reviewer_Draft_WokflowPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Workflow only me as Editor in draft mode
        /// </summary>
        [Test]
        public void Editor_Draft_Wokflow()
        {
            try
            {
                Editor_Draft_WokflowPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow only me as Meeting Host in draft mode
        /// </summary>
        [Test]
        public void MeetingHost_Draft_Wokflow()
        {

            try
            {
                MeetingHost_Draft_WokflowPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow only me as Send A Copy in draft mode
        /// </summary>
        [Test]
        public void SentACOPY_Draft_Wokflow()
        {

            try
            {
                SentACOPY_Draft_WokflowPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Workflow only me as Digital signe with ConsentID in draft mode
        /// </summary>
        [Test]
        public void DSigne_With_ConsentID_Draft_Wokflow()
        {
            try
            {
                DSignWithConsentIDPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        ///Validate hand signature required before main task sign in draft mode 
        /// </summary>
        [Test]
        public void ValidateHandSignaturInDraftWokflow()
        {
            try
            {
                ValidateHandSignaturInDraftWokflowPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        ///Validate Inperson sign required before main task sign in draft mode 
        /// </summary>
        [Test]
        public void ValidateInPersonInDraftWokflow()
        {
            try
            {
                ValidateInPersonInDraftWokflowPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        ///Validate Initial sign required before main task sign in draft mode 
        /// </summary>
        [Test]
        public void ValidateInitialInDraftWokflow()
        {
            try
            {
                ValidateInitialInDraftWokflowPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Validate signer turn in draft mode  
        /// </summary>
        [Test]
        public void ValidateSignerTurnInDraftWokflow()
        {
            try
            {
                ValidateSignerTurnInDraftWokflowPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Validate certify with no changes actions
        /// </summary>
        [Test]
        public void VlaidateCertifyWithNoChanges()
        {
            try
            {
                ValidateCertifyWithNoChangesPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Validate only E-Sign allowed to add 
        /// </summary>
        [Test]
        public void ValidateESignOnlyAllowedToAdd()
        {
            try
            {
                ValidateESignOnlyAllowedToAddPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Validate only D-Sign allowed to add 
        /// </summary>
        [Test]
        public void ValidateDSignOnlyAllowedToAdd()
        {
            try
            {
                ValidateDSignOnlyAllowedToAddPrivate();

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
        /// Workflow only me as E signer in draft mode private method
        /// </summary>
        void ESigner_Draft_Wokflowprivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();
               
                //Upload Document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add Signer
                AddSigner(TestData.Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 200, 300);
                
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Text Option selected
                TextSign();
                
                //Click on done button to sign signature field
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);
            
                //Click to finish workflow in draft mode
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add text in search field and perform search          
                driver.FindElement(By.CssSelector(Elements_Paths.Document_Listing_Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);

                //Click on search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Submit_Search_CssSelector)).Click();
                Thread.Sleep(3000);

                //Select Document
                var checkbox1 = FindElement(driver, By.CssSelector(Elements_Paths.Select_First_Document_CssSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox1);

                //Click on more action icon
                FindElement(driver, By.CssSelector(Elements_Paths.More_Action_CssSelector)).Click();

                //Download Evidence report
                FindElement(driver, By.CssSelector(Elements_Paths.More_Action_EvidenceReport_CssSelector)).Click();
                Thread.Sleep(5000);

                //Verify Activity logs
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Downloaded activity verified
                IWebElement Download = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Download_Evidence_Report_Activity_Text, Download.Text);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Workflow only me as Digital signer in draft mode private method
        /// </summary>
        void DSigner_Draft_WokflowPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload Document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add Signer
                AddSigner(TestData.Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 300);
                
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Text Option selected
                TextSign();

                try
                {
                    //Provide the password
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Sign_Password_CssSelector)).SendKeys(TestData.Password);
                }
                catch (Exception)
                {
                }

                //Click on done button to sign signature field
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click to finish workflow in draft mode
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
             
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }        

        /// <summary>
        /// Workflow only me as Reviewer in draft mode private method
        /// </summary>
        void Reviewer_Draft_WokflowPrivate()
        {
            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add Signer 
                AddSigner(TestData.Email_Address);

                //Change Role to Reviewer
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_Reviewer_CssSelector)).Click();

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 200, 300);              

                //Click to Review in draft mode
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();

                //Provide Approve Reason
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Remarks_TextArea_CssSelector)).SendKeys(TestData.Workflow_Reviewer_Remarks);

                //Approved the document     
                FindElement(driver, By.CssSelector(Elements_Paths.General_Success_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add text in search field and perform search          
                driver.FindElement(By.CssSelector(Elements_Paths.Document_Listing_Search_CssSelector)).SendKeys(TestData.Document_Sample_PDF);

                //Click on search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Submit_Search_CssSelector)).Click();
                Thread.Sleep(3000);

                //Select Document
                var checkbox1 = FindElement(driver, By.CssSelector(Elements_Paths.Select_First_Document_CssSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox1);

                //Click on more action icon
                FindElement(driver, By.CssSelector(Elements_Paths.More_Action_CssSelector)).Click();

                //Download Evidence report
                FindElement(driver, By.CssSelector(Elements_Paths.More_Action_EvidenceReport_CssSelector)).Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(Elements_Paths.Dashboard_Menu_Option_ID)));

                //Verify Activity logs
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Downloaded activity verified
                IWebElement Download = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Download_Evidence_Report_Activity_Text, Download.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Workflow only me as Editor in draft mode private method
        /// </summary>
        void Editor_Draft_WokflowPrivate()
        {

            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add signer
                AddSigner(TestData.Email_Address);

                //Change Role to Editot
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_Editor_CssSelector)).Click();

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 250, 400);
                
                //Click to Fill initial           
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Text Option selected
                TextSign();

                //Verify that crop alert is present
                if (IsAlertExist == true)
                {  //clicks on Done button
                    FindElement(driver, By.XPath(Elements_Paths.General_ImageCropDoneButton_XPath)).Click();
                }
                else //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Click Submit
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);
             
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow only me as Meeting Host in draft mode private method
        /// </summary>
        void MeetingHost_Draft_WokflowPrivate()
        {

            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document 
                UploadDocument(TestData.Document_Sample_PDF);

                //Add signer
                AddSigner(TestData.Email_Address);

                //Change Role to Meeting Host
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_MeetingHost_CssSelector)).Click();

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Viewer_SignatureField_InPerson_CSSSelector, 300, 400);
                
                //Click to Fill In-Person          
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Click on done button to sign In-Person
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Click finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Workflow only me as Send A Copy in draft mode private method
        /// </summary>        
        void SentACOPY_Draft_WokflowPrivate()
        {

            try
            {
                //Go to dashboard                
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add signer
                AddSigner(TestData.Email_Address);

                //Change Role to Send A Copy
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_SendAcopy_CssSelector)).Click();

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Click finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);
                
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        void DSignWithConsentIDPrivate()
        {
            try
            {
                //Consent ID Login 
                new Login().ConsentIDLogin();

                //Go to dashboard         
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document 
                UploadDocument(TestData.Document_Sample_PDF);

                //Select logged in user
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Recipient_Search_CSSSelector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Logged_In_Recipient_Select_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 400);
                
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Text Option selected
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Text_CSSSelector)).Click();

                //Click on done button to sign signature field
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(8000);

                //Verify that authentication alert is present and closed
                waitForConsentModalToclose();

                //Click to finish workflow in draft mode
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate hand signature required before main task sign in draft mode 
        /// </summary>
        void ValidateHandSignaturInDraftWokflowPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Sample_Upload_Third_Party_Document_Name);
                
                //Add recipient
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Add signer
                AddSigner(TestData.Email_Address);
                
                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add hand signature field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 400);

                //Add D-Sign field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 400);                
                
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);                  

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                if (TestData.Fill_Hand_Signature_Field_Required_Error_Message == ToasterMessage.Text)
                    LogResult(GetCurrentMethod());
                else
                    LogTestCase(GetCurrentMethod());

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
        
        /// <summary>
        /// Validate InPerson sign required before main task sign in draft mode 
        /// </summary>
        void ValidateInPersonInDraftWokflowPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Sample_Upload_Third_Party_Document_Name);
                
                //Add recipient
                AddSigner(TestData.Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 400);

                //Add D-Sign field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Viewer_SignatureField_InPerson_CSSSelector, 200, 400);

                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                if (TestData.Fill_InPerson_Field_Required_Error_Message == ToasterMessage.Text)
                    LogResult(GetCurrentMethod());
                else
                    LogTestCase(GetCurrentMethod());

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
        
        /// <summary>
        /// Validate Initial sign required before main task sign in draft mode 
        /// </summary>
        void ValidateInitialInDraftWokflowPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Sample_Upload_Third_Party_Document_Name);

                //Add recipient
                AddSigner(TestData.Email_Address);
                
                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Viewer_SignatureField_Digital_CSSSelector, 300, 300);

                //Add Initial field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 200, 400);
                
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);
                
                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                if (TestData.Fill_Initial_Field_Required_Error_Message == ToasterMessage.Text)
                    LogResult(GetCurrentMethod());
                else
                    LogTestCase(GetCurrentMethod());

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
        
        /// <summary>
        /// Validate signer turn in draft mode 
        /// </summary>
        void ValidateSignerTurnInDraftWokflowPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Sample_Upload_Third_Party_Document_Name);
                
                //Add recipient
                AddSigner(TestData.Contact_Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Add D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 400);                             
         
                //Fill Signature Field
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();
                Thread.Sleep(2000);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                if (TestData.Signing_Field_Not_Assigned_Error_Message == ToasterMessage.Text)
                    LogResult(GetCurrentMethod());
                else
                    LogTestCase(GetCurrentMethod());

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
        
        void ValidateCertifyWithNoChangesPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Sample_Upload_Certify_Document_Name);

                #region Validate Merging

                try
                {
                    //Upload document
                    //Click on library icon
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Library_Upload_CSSSelector)).Click();

                    //Search for the document
                    FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(TestData.Document_Sample_PDF);

                    //Select the search result
                    FindElement(driver, By.CssSelector(Elements_Paths.Library_Listing_Checkbox_CSS_Selector)).Click();

                    //Click done button
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);                   

                    //Merging the document
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Attachment_Css_Selector)).Click();

                    //Click yes button
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Error_Message, message.Text);
                    Thread.Sleep(1000);

                    message.Click();
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Document merging test caes fail.", ex);
                }

                #endregion
                
                //Add recipient
                AddSigner(TestData.Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //#region Validate Add Text

                //Actions builder = new Actions(driver);

                ////Add text field     
                //IWebElement esignField = driver.FindElement(By.CssSelector(Elements_Paths.Workflow_On_Page_Comments_CSSSelector));

                ////Image of document
                //IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                ////Dropping field at location
                //builder.ClickAndHold(esignField).MoveToElement(documentImage, 200, 300).Release().Build().Perform();
                //Thread.Sleep(1000);

                //var check = driver.FindElement(By.CssSelector("iframe[id^='beforeComment_']"));

                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();" + "arguments[0].text = 'Test text added';", check);

                //Thread.Sleep(2000);
                //FindElement(driver, By.CssSelector("#page-comments .icon.icon-save")).Click();

                //#endregion

                #region Validate attachment 

                try
                {
                    //Click on Attachment
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Attachment_Css_Selector)).Click();                    

                    //Click on add attachment
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Add_Attachment_Css_Selector)).Click();
                    Thread.Sleep(2000);                   

                    //Upload document
                    UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Sample_Upload_Document_Name, 3000);

                    IWebElement errorMessage = FindElement(driver, By.CssSelector(Elements_Paths.Upload_Document_Fail_Text_CSS_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Error_Message, errorMessage.Text);

                    FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Attachment test case fail", ex);
                }

                #endregion

                #region Validate E-Sign

                try
                {
                    //Drop Initial field
                    DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 100, 150);

                    //Fill field
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                    //Text Option selected
                    TextSign();

                    //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Error_Message, message.Text);
                    message.Click();

                    //Delete E-Sign
                    var esing = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Delete_Cog_CSS_Selector));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", esing);                    
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "E-sign signing test case fail.", ex);
                }

                #endregion

                #region Validate D-Sign

                try
                {
                    //Drop field
                    DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 100, 150);

                    //Fill field
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                    //Text Option selected
                    TextSign();

                    //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Error_Message, message.Text);

                    Thread.Sleep(1000);
                    message.Click();       
               
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "D-Sign signing case fail.", ex);
                }

                #endregion

                #region Validate Initial

                try
                {
                    //open recipients dialog
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Recipient_Dialog_CSS_Selector)).Click();

                    //Change Role to Reviewer
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_Reviewer_CssSelector)).Click();

                    //Click yes button
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                    Thread.Sleep(1000);

                    //Drop Initial field
                    DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 100, 150);

                    //Fill field
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();

                    //Text Option selected
                    TextSign();

                    //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Inperson_Error_Message, message.Text);

                    Thread.Sleep(1000);
                    message.Click();

                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Initial signing test case fail", ex);
                }

                #endregion

                #region Validate Inperson

                try
                {
                    //open recipients dialog
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Recipient_Dialog_CSS_Selector)).Click();

                    //Change Role to Meeting Host
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Single_Signer_CssSelector)).Click();
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Role_MeetingHost_CssSelector)).Click();

                    //Click yes button
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                    Thread.Sleep(1000);

                    //Drop Initial field
                    DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 100, 150);

                    //Fill field
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();

                    //Text Option selected
                    TextSign();

                    //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Inperson_Error_Message, message.Text);

                    Thread.Sleep(1000);
                    message.Click();

                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "In-Person signing test case fail ", ex);
                }

                #endregion

                #region Validate document Sharing

                try
                {
                    //open recipients dialog
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Recipient_Dialog_CSS_Selector)).Click();

                    //Add recipient
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();

                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.Email_Address);
                   
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);
                   
                    FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Tab);
                  
                    //Click done button
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                    Thread.Sleep(1000);

                    //Click on second collaborator
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();
                    Thread.Sleep(1000);

                    //Drop field
                    DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 100, 400);

                    //Click on share button
                    FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                    Thread.Sleep(1000);

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Certified_With_No_Changes_Document_Error_Message, message.Text);

                    Thread.Sleep(1000);
                    message.Click();

                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Document sharing test case fail.", ex);
                }

                #endregion

                LogTestCase(GetCurrentMethod());

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ValidateESignOnlyAllowedToAddPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Document_Sample_PDF);
                
                //Add recipient
                AddSigner(TestData.Email_Address);
                
                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);

                //Drop E-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 100, 150);

                //Drop D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 250, 150);

                IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Add_Only_E_Sign_Field_Error_Message, message.Text);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                LogResult(GetCurrentMethod());
            }
            catch (Exception)
            {

                throw;
            }
        }

        void ValidateDSignOnlyAllowedToAddPrivate()
        {
            try
            {
                //Go to dashboard            
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_CssSelector)).Click();

                //Upload document
                UploadDocument(TestData.Document_Sample_PDF);

                //Add recipient
                AddSigner(TestData.Email_Address);

                //Click on Next button
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_NEXT_Button_CSSSelector)).Click();
                Thread.Sleep(3000);
                
                //Drop E-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 100, 150);

                //Drop D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 250, 150);

                IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Add_Only_D_Sign_Field_Error_Message, message.Text);                              

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                //Click on back button
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(1000);

                LogResult(GetCurrentMethod());
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Start new workfolw and Upload document 
        /// </summary>
        void UploadDocument(string documentName)
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
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(documentName);

                //Select the search result
                FindElement(driver, By.CssSelector(Elements_Paths.Library_Listing_Checkbox_CSS_Selector)).Click();

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

        void DropField(string image, string field, int xOfset, int yOfset)
        {
            try
            {
                Actions builder = new Actions(driver);
                //Field Element
                IWebElement fieldElement = driver.FindElement(By.CssSelector(field));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(image));

                //  Dropping field at location
                builder.ClickAndHold(fieldElement).MoveToElement(documentImage, xOfset, yOfset).Release().Build().Perform();
                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void TextSign()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Text_CSSSelector)).Click();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).Click();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).Clear();
                FindElement(driver, By.Name(Elements_Paths.Workflow_Only_Me_Initial_Signer_Name)).SendKeys(TestData.Workflow_Only_Me_Initial_Signer_Name);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void AddSigner(string email)
        {
            try
            {
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).Click();

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(email);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion
    }
}
