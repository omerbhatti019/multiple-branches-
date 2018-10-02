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
    class DraftModeFieldsFilling : General_Methods
    {
        Dashboard dashboard = new Dashboard();

        #region Public Methods

        /// <summary>
        /// All methods of fields filling 
        /// </summary>
        [Test]
        public void FillFieldsAllMethods()
        {
            try
            {
                //Fill initial fields with different types
                FillInitialFieldPrivate();

                //Fill In-Person fields with text type of signing
                FillInPersonFieldWithTextPrivate();

                //Fill In-Person fields with differen draw type of signing
                FillInPersonFieldWithDrawPrivate();

                //Fill In-Person fields with upload type of signing
                FillInPersonFieldWithUploadPrivate();

                //Fill Hand signature fields with different types of signing
                FillHandSignatureFieldPrivate();

                //Fill E-sign with text type sign
                FillESignFieldWithTextPrivate();

                //Fill E-sign with draw type sign
                FillESignFieldWithDrawPrivate();

                //Fill E-sign with Upload type sign
                FillESignFieldWithUploadPrivate();

                //Fill D-sign with text type sign
                FillDSignFieldWithTextPrivate();

                //Fill D-sign with draw type sign
                FillDSignFieldWithDrawPrivate();

                //Fill D-sign with Upload type sign
                FillDSignFieldWithUploadPrivate();

                //D-sign with different signature appearances 
                FillDSignWithDifferentAppearansesPrivate();

                //Validate faulty settings for signing
                ValidateFaultySettingsForSignigPrivate();

                //Assign unassigned field and sign 
                ValidateSignWithUassignedFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill initial fields with different types
        /// </summary>
        [Test]
        public void FillInitialField()
        {
            try
            {
                FillInitialFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill In-Person fields with text type of signing
        /// </summary>
        [Test]
        public void FillInPersonFieldWithText()
        {
            try
            {
                FillInPersonFieldWithTextPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill In-Person fields with draw type of signing
        /// </summary>
        [Test]
        public void FillInPersonFieldWithDraw()
        {
            try
            {
                FillInPersonFieldWithDrawPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill In-Person fields with upload types of signing
        /// </summary>
        [Test]
        public void FillInPersonFieldWithUpload()
        {
            try
            {
                FillInPersonFieldWithUploadPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill Hand signature fields with different types of signing
        /// </summary>
        [Test]
        public void FillHandSignatureField()
        {
            try
            {
                FillHandSignatureFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill E-sign with text type sign
        /// </summary>
        [Test]
        public void FillESignFieldWithText()
        {
            try
            {
                FillESignFieldWithTextPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill E-sign with draw type sign
        /// </summary>
        [Test]
        public void FillESignFieldWithDraw()
        {
            try
            {
                FillESignFieldWithDrawPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill E-sign with upload type sign
        /// </summary>
        [Test]
        public void FillESignFieldWithUpload()
        {
            try
            {
                FillESignFieldWithUploadPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill D-sign with text type sign
        /// </summary>
        [Test]
        public void FillDSignFieldWithText()
        {
            try
            {
                FillDSignFieldWithTextPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill D-sign with draw type sign
        /// </summary>
        [Test]
        public void FillDSignFieldWithDraw()
        {
            try
            {
                FillDSignFieldWithDrawPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Fill D-sign with upload type sign
        /// </summary>
        [Test]
        public void FillDSignFieldWithUpload()
        {
            try
            {
                FillDSignFieldWithUploadPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// D-sign with different signature appearances
        /// </summary>
        [Test]
        public void FillDSignWithDifferentAppearanses()
        {
            try
            {
                FillDSignWithDifferentAppearansesPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate faulty settings for signing
        /// </summary>
        [Test]
        public void ValidateFaultySettingsForSignig()
        {
            try
            {
                ValidateFaultySettingsForSignigPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Assign unassigned field and sign 
        /// </summary>
        [Test]
        public void ValidateSignWithUassignedField()
        {
            try
            {
                ValidateSignWithUassignedFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion


        #region Private Methods

        void FillInitialFieldPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop Initial field
                DropField(Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 100, 150);

                //Drop Initial field
                DropField(Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 200, 200);

                //Drop Initial field
                DropField(Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 300, 250);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();

                //Text Option selected
                TextSign();

                //Click on done button to sign initial
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Fill field two
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();

                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(80, 40).Release().Build().Perform();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Fill field three
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();

                //Upload Option selected
                ImageSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

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

        void FillInPersonFieldWithTextPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 200, 350);
               
                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();

                //Text Option selected
                TextSign();

                //Click on done button to sign inperson
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillInPersonFieldWithDrawPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 500, 300);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();
                
                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();

                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(200, 20).Release().Build().Perform();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillInPersonFieldWithUploadPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 400, 150);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();

                //Upload Option selected
                ImageSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(5000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillHandSignatureFieldPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(4000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 200);
                Thread.Sleep(1000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 300);
                Thread.Sleep(1000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 400);
                Thread.Sleep(1000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 500);
                Thread.Sleep(1000);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_HandSignature_CSSSelector)).Click();

                //Text Option selected
                TextSign();

                //Click on done button to sign initial
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Fill field two
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_HandSignature_CSSSelector)).Click();

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();

                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(150, 50).Release().Build().Perform();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

                //Fill field three
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_HandSignature_CSSSelector)).Click();

                //Upload Option selected
                ImageSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(4000);

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

        void FillESignFieldWithTextPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 200, 350);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Text Option selected
                TextSign();

                //Click on done button 
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillESignFieldWithDrawPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 300, 450);

                //Fill field 
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();

                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(200, 20).Release().Build().Perform();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillESignFieldWithUploadPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 300, 450);

                //Fill field 
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Upload Option selected
                ImageSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillDSignFieldWithTextPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 350);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Text Option selected
                TextSign();

                //Click on done button 
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillDSignFieldWithDrawPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 450);

                //Fill field 
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Draw signature
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Draw_CSSSelector)).Click();

                var draw = FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Draw_Sign_CSSSelector));
                Actions builder = new Actions(driver);
                builder.ClickAndHold(draw).MoveByOffset(200, 20).Release().Build().Perform();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillDSignFieldWithUploadPrivate()
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

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 450);

                //Fill field 
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Upload Option selected
                ImageSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillDSignWithDifferentAppearansesPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //D-Sign with Details and logo appearance
                FillDSignWithSignatureAppearanse(Elements_Paths.Personal_Signatures_Select_Appearace1_CSS_Selector);

                //D-Sign with Details appearance
                FillDSignWithSignatureAppearanse(Elements_Paths.Personal_Signatures_Select_Appearace2_CSS_Selector);

                //D-Sign with signature only
                FillDSignWithSignatureAppearanse(Elements_Paths.Personal_Signatures_Select_Appearace_CSS_Selector);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FillDSignWithSignatureAppearanse(string appearanceType)
        {
            try
            {
                ChangeSignatureAppearance(appearanceType);

                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Drop field
                DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 450);

                //Fill field 
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                //Text sign
                TextSign();

                //Click on done button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(6000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ValidateFaultySettingsForSignigPrivate()
        {
            try
            {
                //Set default signing methods
                SetDefaultSigningMethods();

                //Update role settings
                UpdateSignatureAppearancesInRole();

                //Reload page
                driver.Navigate().Refresh();
                Thread.Sleep(3000);

                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument();

                //Add Recipients
                AddRecipients();

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                #region Validate E-Sign             

                try
                {
                    //Drop field
                    DropField(Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 200, 350);

                    //Fill field 
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Faulty_Signing_Method_Error_Message, message.Text);
                    Thread.Sleep(1000);

                    //Close error message
                    message.Click();

                    //Delete E-Sign
                    var esing = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Delete_Cog_CSS_Selector));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", esing);
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Faulty settings for E-sign test case failed.", ex);
                }

                #endregion

                #region Validate D-Sign             

                try
                {
                    //Drop field
                    DropField(Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 200, 350);

                    //Fill field 
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_DSign_CSSSelector)).Click();

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Faulty_Signing_Method_Error_Message, message.Text);
                    Thread.Sleep(1000);

                    //Close error message
                    message.Click();

                    //Delete E-Sign
                    var esing = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Delete_Cog_CSS_Selector));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", esing);
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Faulty settings for D-sign test case failed.", ex);
                }

                #endregion

                #region Validate Initial             

                try
                {
                    //Drop field
                    DropField(Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 100, 150);

                    //Fill field 
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_Initial_CSSSelector)).Click();

                    IWebElement message = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Faulty_Signing_Method_Error_Message, message.Text);
                    Thread.Sleep(1000);

                    //Close error message
                    message.Click();                   
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Faulty settings for Initial test case failed.", ex);
                }

                #endregion

                #region Validate In-person             

                try
                {
                    //Drop field
                    DropField(Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 200, 150);

                    //Fill field one
                    FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Only_Me_InPerosn_CSSSelector)).Click();

                    //Text Option selected
                    TextSign();

                    //Click on done button to sign initial
                    FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                    Thread.Sleep(5000);

                    //Click on finish button
                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    LogTestCase(GetCurrentMethod(), "Faulty settings for In-person test case failed.", ex);
                }

                #endregion

                //Update role settings
                UpdateSignatureAppearancesInRole();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ValidateSignWithUassignedFieldPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(1000);

                //Upload document
                UploadDocument(TestData.Unassigned_Field__Library_Document);

                //Add Recipients
                AddRecipients();

                //Click on next button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on field settings 
                var settings = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Form_Unassigned_Field_Settings_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", settings);
                Thread.Sleep(1000);

                //Click on dropdown
                FindElement(driver, By.CssSelector(Elements_Paths.Signing_Field_Assign_DropDown_CssSelector)).Click();

                //Select colloaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Select_Signer_CSS_Selector)).Click();

                //Click on save button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                //Fill field one
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Unassigned_Field_Fill_CSS_Selector)).Click();

                //Text Option selected
                TextSign();

                if (IsElementExists(driver, By.Name(Elements_Paths.Password_Field_On_Sign_CSSSelector)))
                {
                    FindElement(driver, By.Name(Elements_Paths.Password_Field_On_Sign_CSSSelector)).Click();

                    FindElement(driver, By.Name(Elements_Paths.Password_Field_On_Sign_CSSSelector)).SendKeys(TestData.Password);
                }

                //Click on done button 
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Success_Button_CSSSelector)).Click();
                Thread.Sleep(8000);

                //Click on finish button
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Finish_Button_CSSSelector)).Click();
                Thread.Sleep(2000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        void UploadDocument(string document = TestData.Document_Sample_PDF)
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
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_Upload_Library_Search_CSS_Selector)).SendKeys(document);

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

        void AddRecipients()
        {
            try
            {
                //Add recipient
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Add_Recipient_Icon_CSSSelector)).Click();
                Thread.Sleep(500);

                //Add text for recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.Email_Address);
                Thread.Sleep(1000);

                //Enter key for add recipient
                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void DropField(string field, int xOfset, int yOfset)
        {
            try
            {
                Actions builder = new Actions(driver);
                //Field Element
                IWebElement fieldElement = driver.FindElement(By.CssSelector(field));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));

                //  Dropping field at location
                builder.ClickAndHold(fieldElement).MoveToElement(documentImage, xOfset, yOfset).Release().Build().Perform();
                Thread.Sleep(2000);

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

        void ImageSign()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Workflow_Option_Upload_CSSSelector)).Click();

                //Upload Image
                UploadDocument(Elements_Paths.Upload_Image_On_Sign_CSSSelector, TestData.Sample_Upload_Image_Name, 2000);
                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ChangeSignatureAppearance(string appearanceType)
        {
            try
            {
                //Navigate to my settings
                dashboard.NavigationToMySettings();

                //Click on Signatures tab
                FindElement(driver, By.Id(Elements_Paths.Personal_Signatures_ID)).Click();

                // Signature Appearance Design
                //Clicks on dropdown
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_DropDown_ClassName)).Click();

                FindElement(driver, By.CssSelector(appearanceType)).Click();
                // clicks on save button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Submit_Button_CSS_Selector)).Click();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void SetDefaultSigningMethods()
        {
            try
            {
                //Navigate to my settings
                dashboard.NavigationToMySettings();

                //Click on Signatures tab
                FindElement(driver, By.Id(Elements_Paths.Personal_Signatures_ID)).Click();

                // Text-based Signatures for web
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_Web_TextCheckbox_CSS_Selector)).Click();
                // Clear value from text-based signatures
                FindElement(driver, By.XPath(Elements_Paths.Personal_Signatures_SignatureAppearacne_Web_TextInput_XPath)).Clear();
                // Enter value in text-based signatures
                FindElement(driver, By.XPath(Elements_Paths.Personal_Signatures_SignatureAppearacne_Web_TextInput_XPath)).SendKeys(TestData.Contact_Name);

                // Initials Method
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_Initials_DrawCheckbox_CSS_Selector)).Click();
                // Text-based Signatures                
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_Initials_TextCheckbox_CSS_Selector)).Click();
                // Clear value from text-based signatures                
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_Initials_TextInput_CSS_Selector)).Clear();
                // Enter value in text-based signatures
                FindElement(driver, By.CssSelector(Elements_Paths.Personal_Signatures_SignatureAppearacne_Initials_TextInput_CSS_Selector)).SendKeys(TestData.Contact_Name);

                // clicks on save button
                FindElement(driver, By.CssSelector(Elements_Paths.General_Submit_Button_CSS_Selector)).Click();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UpdateSignatureAppearancesInRole()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Click on Enterprise Roles              
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Roles_ID)).Click();

                //Search for Enterprise Role to be edited
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Admin_Role_Name);

                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                Thread.Sleep(3000);

                //Click on tab
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Roles_SignatureAppearance_Tab_CSSSelector)).Click();

                //Web text based signature
                var webText = FindElement(driver, By.Id(Elements_Paths.Enterprise_Roles_Web_Text_Signature_CSSSelector));                
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", webText);

                //Initial text based signature
                var initalText = FindElement(driver, By.Id(Elements_Paths.Enterprise_Roles_Initial_Text_Signature_CSSSelector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", initalText);

                //Click on Save button to save changes
                FindElement(driver, By.CssSelector(Elements_Paths.Enterprise_Roles_Save_Button_CSSSelector)).Click();
                Thread.Sleep(2000);               

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
