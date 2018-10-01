using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture][Parallelizable]
    public class DocumentViewer : General_Methods
    {        
        #region All test cases

        /// <summary>
        /// Run all Edit test cases
        /// </summary>
        [Test]
        public void RunAllActionsOnFields()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();
                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add recipients
                WorkflowAddRecipientPrivate();

                //Add d-sign field
                EditSignatureFieldPrivate();
                Thread.Sleep(1000);

                //add-inperson                
                EditInpersonFieldPrivate();
                Thread.Sleep(1000);

                //add initial                
                EditInitialFieldPrivate();
                Thread.Sleep(1000);

                //add name                
                EditNameFieldPrivate();
                Thread.Sleep(1000);

                //add email                
                EditEmailFieldPrivate();
                Thread.Sleep(1000);

                //add company                
                EditCompanyFieldPrivate();
                Thread.Sleep(1000);

                //add text                
                EditJobTitleFieldPrivate();
                Thread.Sleep(1000);

                //add date field                
                EditDateFieldPrivate();
                Thread.Sleep(1000);

                //add check box                
                EditCheckBoxFieldPrivate();
                Thread.Sleep(1000);

                //add radio button                
                EditRadioFieldPrivate();
                Thread.Sleep(1000);

                //add radio button
                EditTextFieldPrivate();
                Thread.Sleep(1000);

                new Viewer_MoreAction().Viewer_Save_Form_Field_Action_Common();

                Thread.Sleep(3000);
                DeleteSignatureFieldPrivate();
                DeleteInpersonFieldPrivate();
                DeleteInitialFieldPrivate();
                DeleteNameFieldPrivate();
                DeleteEmailFieldPrivate();

                //add text                
                AddTextPrivate();

                //Form field name with different font sizes and types
                FormFieldNameWithDifferentFontsPrivate();

                //Form field email with different font sizes 
                FormFieldEmailWithDifferentFontsPrivate();

                //Form field job with different font sizes 
                FormFieldJobWithDifferentFontsPrivate();

                //Form field company text with different font sizes 
                FormFieldCompanyTextWithDifferentFontsPrivate();

                //Form field date with different font sizes 
                FormFieldDateWithDifferentFontsPrivate();

                //Form field text with different font sizes 
                FormFieldTextboxWithDifferentFontsPrivate();

                //Assign unassigned field to collaborator
                AssignUassignedFieldToSignerPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        [Test]
        public void RunAllAddFieldsTestCases()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                //Add d-sign field
                AddDSignFieldPrivate();

                //Add e-sign field                
                AddESignFieldPrivate();

                //add-inperson                
                AddInpersonFieldPrivate();

                //add initial                
                AddInitialFieldPrivate();

                //add text                
                AddJobTextFieldPrivate();

                //add name                
                AddNameTextFieldPrivate();

                //add email
                AddEmailTextFieldPrivate();

                //add company
                AddCompanyTextFieldPrivate();

                //add date field
                AddDateFieldPrivate();

                //add date
                AddDateFieldPrivate();

                //add radio button
                AddRadioFieldPrivate();

                //add check box
                AddCheckboxFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Run all Edit test cases
        /// </summary>
        [Test]
        public void RunAllEditFieldsTestCases()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                //Add d-sign field
                EditSignatureFieldPrivate();

                //Add e-sign field                
                AddESignFieldPrivate();

                //add-inperson
                EditInpersonFieldPrivate();

                //add initial
                EditInitialFieldPrivate();

                //add name
                EditNameFieldPrivate();

                //add email
                EditEmailFieldPrivate();

                //add company
                EditCompanyFieldPrivate();

                //add text
                EditJobTitleFieldPrivate();

                //add date field
                EditDateFieldPrivate();

                //add check box
                EditCheckBoxFieldPrivate();

                //add radio button
                EditRadioFieldPrivate();

                //add on page comments
                AddTextPrivate();

                RunAllDeleteFieldsTestCases();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Run all Edit test cases
        /// </summary>
        [Test]
        public void RunAllDeleteFieldsTestCases()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                //Add d-sign field
                AddDSignFieldPrivate();

                //Delete d-sign field
                DeleteSignatureFieldPrivate();

                //add-inperson
                AddInpersonFieldPrivate();

                //Delete-inperson
                DeleteInpersonFieldPrivate();

                //add initial
                AddInitialFieldPrivate();

                //Delete initial
                DeleteInitialFieldPrivate();

                //add text
                AddJobTextFieldPrivate();

                //Delete text
                AddNameTextFieldPrivate();

                //add email
                AddEmailTextFieldPrivate();

                //add company
                AddCompanyTextFieldPrivate();

                //add date field
                AddDateFieldPrivate();

                //add radio button
                AddRadioFieldPrivate();

                //add check box
                AddCheckboxFieldPrivate();

                //Delete job
                DeleteJobTitleFieldPrivate();

                //Delete name
                DeleteNameFieldPrivate();

                //Delete email
                DeleteEmailFieldPrivate();

                //Delete company
                DeleteCompanyFieldPrivate();

                //Delete date field
                DeleteDateFieldPrivate();

                //Delete radio
                DeleteRadioFieldPrivate();

                //Delete checkbox
                DeleteCheckBoxFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }
        #endregion

        #region Public methods

        [Test]
        public void ChangeRecipientPending()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(5000);
                WorkflowAddRecipientPrivate();
                ChangeRecipientPendingPrivate();
                Thread.Sleep(5000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        #region Add fields region
        /// <summary>
        /// Add D-Sign field and Hand Signature
        /// </summary>
        [Test]
        public void AddDSignField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddDSignFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }


        /// <summary>
        /// Add E-Sign field and Hand Signature
        /// </summary>
        [Test]
        public void AddESignField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Add E-sign field
                AddESignFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add in-person field
        /// </summary>
        [Test]
        public void AddInpersonField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddInpersonFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add initial-field
        /// </summary>
        [Test]
        public void AddInitialField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                AddInitialFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add name field
        /// </summary>
        [Test]
        public void AddNameTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddNameTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add email field
        /// </summary>
        [Test]
        public void AddEmailTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                AddEmailTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add job field
        /// </summary>
        [Test]
        public void AddJobTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddJobTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add company field
        /// </summary>
        [Test]
        public void AddCompanyTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                AddCompanyTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add date field
        /// </summary>
        [Test]
        public void AddDateField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddDateFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add text field
        /// </summary>
        [Test]
        public void AddTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                AddTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add radio field
        /// </summary>
        [Test]
        public void AddRadioField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddRadioFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add check box field
        /// </summary>
        [Test]
        public void AddCheckboxField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                AddCheckboxFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Add text -on page comment
        /// </summary>
        [Test]
        public void AddText()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                AddTextPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit fields region
        [Test]
        public void EditSignatureField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                EditSignatureFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }


        /// <summary>
        /// Edit in-person field
        /// </summary>
        [Test]
        public void EditInpersonField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditInpersonFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Edit initial field
        /// </summary>
        [Test]
        public void EditInitialField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditInitialFieldPrivate();

                LogTestCase(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit name field
        /// </summary>
        [Test]
        public void EditNameField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditNameFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit email field
        /// </summary>
        [Test]
        public void EditEmailField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditEmailFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit job title field
        /// </summary>
        [Test]
        public void EditJobTitleField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditJobTitleFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit company field
        /// </summary>
        [Test]
        public void EditCompanyField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditCompanyFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit date field
        /// </summary>
        [Test]
        public void EditDateField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditEmailFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit text field
        /// </summary>
        [Test]
        public void EditTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit check box field
        /// </summary>
        [Test]
        public void EditCheckBoxField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditCheckBoxFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit Radio field
        /// </summary>
        [Test]
        public void EditRadioField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                EditRadioFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Delete fields region
        /// <summary>
        /// Delete signature field and Hand Signature
        /// </summary>
        [Test]
        public void DeleteSignatureField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddDSignFieldPrivate();

                DeleteSignatureFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }


        /// <summary>
        /// Delete in-person field
        /// </summary>
        [Test]
        public void DeleteInpersonField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddInpersonFieldPrivate();

                DeleteInpersonFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }


        /// <summary>
        /// Delete initial field
        /// </summary>
        [Test]
        public void DeleteInitialField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddInitialFieldPrivate();

                DeleteInitialFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete name field
        /// </summary>
        [Test]
        public void DeleteNameField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddNameTextFieldPrivate();

                DeleteNameFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete email field
        /// </summary>
        [Test]
        public void DeleteEmailField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddEmailTextFieldPrivate();

                DeleteEmailFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete job title field
        /// </summary>
        [Test]
        public void DeleteJobTitleField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddJobTextFieldPrivate();

                DeleteJobTitleFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete company field
        /// </summary>
        [Test]
        public void DeleteCompanyField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddCompanyTextFieldPrivate();

                DeleteCompanyFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete date field
        /// </summary>
        [Test]
        public void DeleteDateField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddCompanyTextFieldPrivate();

                DeleteCompanyFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete text field
        /// </summary>
        [Test]
        public void DeleteTextField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);
                WorkflowAddRecipientPrivate();

                AddTextFieldPrivate();

                DeleteTextFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete check box field
        /// </summary>
        [Test]
        public void DeleteCheckBoxField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddCheckboxFieldPrivate();

                DeleteCheckBoxFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete Radio field
        /// </summary>
        [Test]
        public void DeleteRadioField()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                WorkflowAddRecipientPrivate();

                AddRadioFieldPrivate();

                DeleteRadioFieldPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        /// <summary>
        /// Form field name with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldNameWithDifferentFonts()
        {
            try
            {
                FormFieldNameWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Form field email with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldEmailWithDifferentFonts()
        {
            try
            {
                FormFieldEmailWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Form field job with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldJobWithDifferentFonts()
        {
            try
            {
                FormFieldJobWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Form field compnay text with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldCompanyTextWithDifferentFonts()
        {
            try
            {
                FormFieldCompanyTextWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Form field Date with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldDateWithDifferentFonts()
        {
            try
            {
                FormFieldDateWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Form field text with different font sizes and types
        /// </summary>
        [Test]
        public void FormFieldTextboxWithDifferentFonts()
        {
            try
            {
                FormFieldTextboxWithDifferentFontsPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Assign unassigned field to collaborator
        /// </summary>
        [Test]
        public void AssignUassignedFieldToSigner()
        {
            try
            {
                AssignUassignedFieldToSignerPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Private methods

        #region Add private fields region
        /// <summary>
        /// Add D-Sign field and Hand Signature
        /// </summary>
        void AddDSignFieldPrivate()
        {
            try
            {
                //D-Sign hand signtaure field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 450, 150);

                //D-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 300, 420);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add E-Sign field and Hand Signature
        /// </summary>
        void AddESignFieldPrivate()
        {
            try
            {
                //E-Sign hand signtaure field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 450, 150);

                //E-Sign field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_ESign_Signature_Field_CSSSelector, 300, 420);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Add in-person field
        /// </summary>
        void AddInpersonFieldPrivate()
        {
            try
            {
                //Drop In-person field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 100, 150);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add initial-field
        /// </summary>
        void AddInitialFieldPrivate()
        {
            try
            {
                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Drop initial field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 300, 280);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add name field
        /// </summary>
        public void AddNameTextFieldPrivate()
        {
            try
            {
                //Click on first collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image3_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 100, 300);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add email field
        /// </summary>
        void AddEmailTextFieldPrivate()
        {
            try
            {
                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Drop email field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 420, 350);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add job field
        /// </summary>
        void AddJobTextFieldPrivate()
        {
            try
            {
                //Click on first collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                //Drop job field
                DropField(Elements_Paths.Viewer_Image3_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 450, 470);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add company field
        /// </summary>
        void AddCompanyTextFieldPrivate()
        {
            try
            {
                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Drop company field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 100, 350);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add date field
        /// </summary>
        void AddDateFieldPrivate()
        {
            try
            {
                //Click on first collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                //Drop data field
                DropField(Elements_Paths.Viewer_Image3_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 100, 160);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add text field
        /// </summary>
        void AddTextFieldPrivate()
        {
            try
            {
                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Drop text field
                DropField(Elements_Paths.Viewer_Image3_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 400, 520);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add radio field
        /// </summary>
        void AddRadioFieldPrivate()
        {
            try
            {
                //Click on first collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();

                //Drop radio field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Radio_Button_CSSSelector, 150, 490);

                //Drop radio field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Radio_Button_CSSSelector, 20, 305);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add check box field
        /// </summary>
        void AddCheckboxFieldPrivate()
        {
            try
            {
                //Click on second collaborator
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer2_CSS_Selector)).Click();

                //Drop radio field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_CheckBox_CSSSelector, 400, 490);

                //Drop radio field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_CheckBox_CSSSelector, 20, 340);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Add email field
        /// </summary>
        void AddTextPrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer1_CSS_Selector)).Click();
                Thread.Sleep(2000);
                var Drag_From = driver.FindElement(By.CssSelector(Elements_Paths.Workflow_On_Page_Comments_CSSSelector));
                //add field on 1st image
                var Drag_To = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Image1_CSS_Selector));
                Actions _action = new Actions(driver);

                //Click and hold the both documents and change the positions
                _action.ClickAndHold(Drag_From).MoveToElement(Drag_To, 100, 150).Build().Perform();
                Thread.Sleep(1000);

                //Release the field
                _action.Release().Perform();                
                Thread.Sleep(2000);

                var check = driver.FindElement(By.CssSelector(Elements_Paths.Viewer_On_Page_Comment_CSS_Selector));                

                Thread.Sleep(2000);
                try
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();" + "arguments[0].innerText = 'hello world';", check);                    
                    Thread.Sleep(2000);

                    FindElement(driver, By.CssSelector(Elements_Paths.Viewer_On_Page_Comment_Save_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    throw;
                }

                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit private fields region
        /// <summary>
        /// Edit signature field and Hand Signature
        /// </summary>
        void EditSignatureFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_DSign_Signature_Field_CSSSelector, 450, 150);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_CSS_Selector)));

                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                Thread.Sleep(1000);

                //Edit task
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Expand_CSS_Selector)).Click();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Left_Position_CSS_Selector)).Clear();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Left_Position_CSS_Selector)).SendKeys("520");

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Top_Position_CSS_Selector)).Clear();
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Top_Position_CSS_Selector)).SendKeys("30");

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Width_Position_CSS_Selector)).Clear();
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Width_Position_CSS_Selector)).SendKeys("100");

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Height_Position_CSS_Selector)).Clear();
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Dimension_Height_Position_CSS_Selector)).SendKeys("40");

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit in-person field
        /// </summary>
        void EditInpersonFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Inperson_Signature_Field_CSSSelector, 20, 150);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inperson_Field_CSS_Selector)));

                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_Replicate_Option_click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_Replicate_Option_Select_All_click_CSS_Selector)).Click();

                //Click on checkbox
                var checkbox = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_OTP_Check_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkbox);
                Thread.Sleep(1000);

                //Add mobile number
                driver.FindElement(By.Name(Elements_Paths.Viewer_Signer_ESign_OTP_Text_Box_By_Name)).Click();
                driver.FindElement(By.Name(Elements_Paths.Viewer_Signer_ESign_OTP_Text_Box_By_Name)).SendKeys(TestData.Mobile_Number);

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                var edit = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_Field_Edit_Cog_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", edit);
                Thread.Sleep(1000);

                var inpCheckbox = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Delete_Inperson_Field_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", inpCheckbox);

                //Click on delete
                driver.FindElement(By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit initial field private
        /// </summary>
        void EditInitialFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Initial_Signature_Field_CSSSelector, 550, 280);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Field_CSS_Selector)));

                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Replicate_Option_click_CSS_Selector)).Click();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Replicate_Option_Select_All_click_CSS_Selector)).Click();

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                var edit = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Field_Edit_Cog_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", edit);
                Thread.Sleep(1000);

                var inpCheckbox = FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Delete_Initial_Field_CSS_Selector));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", inpCheckbox);

                //Click on delete
                driver.FindElement(By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit name field
        /// </summary>
        void EditNameFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 100, 300);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Name_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Name_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Name Form Field");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).SendKeys("2000");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Name_Field_Input_CSS_Selector)).SendKeys("Hello world!");
                Thread.Sleep(2000);         
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit email field
        /// </summary>
        void EditEmailFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 450, 350);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Email_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Email_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();

                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Email Form Field");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).SendKeys("2000");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Email_Field_Input_CSS_Selector)).SendKeys(TestData.Email_Address);
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Edit job title field
        /// </summary>
        void EditJobTitleFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 450, 450);
            
                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Job_Title_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Job_Title_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Job Form Field");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).SendKeys("2000");
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Job_Title_Field_Input_CSS_Selector)).SendKeys("Hello world!");
                Thread.Sleep(2000);             
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit company field
        /// </summary>
        void EditCompanyFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 100, 250);
                
                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Company_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Company_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Company Form Field");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).SendKeys("2000");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Company_Field_Input_CSS_Selector)).SendKeys("Hello world!");
                Thread.Sleep(2000);              
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit date field
        /// </summary>
        void EditDateFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 100, 460);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Date_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Date_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Date_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Date_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Date Form Field");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);
             
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit text field
        /// </summary>
        void EditTextFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 20, 360);

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Text_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Text_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector)).SendKeys("Text Form Field");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector)).SendKeys("2000");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Text_Field_Input_CSS_Selector)).SendKeys("Hello world!");
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit check box field
        /// </summary>
        void EditCheckBoxFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_CheckBox_CSSSelector, 400, 530);
             
                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector)).Click();
                //Required
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Input_CSS_Selector)).Click();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Edit Radio field
        /// </summary>
        void EditRadioFieldPrivate()
        {
            try
            {
                //Drop field
                DropField(Elements_Paths.Viewer_Image2_CSS_Selector, Elements_Paths.Workflow_Radio_Button_CSSSelector, 150, 490);
             
                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Radio_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Radio_Field_Edit_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Radio_Select_CSS_Selector)).Click();
                //Required
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector)).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Delete fields region
        /// <summary>
        /// Delete signature field and Hand Signature
        /// </summary>
        void DeleteSignatureFieldPrivate()
        {
            try
            {
                Thread.Sleep(2000);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_CSS_Selector)));

                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                Thread.Sleep(500);
                //Edit task
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Signature_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete in-person field
        /// </summary>
        void DeleteInpersonFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inperson_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Inpeson_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete initial field
        /// </summary>
        void DeleteInitialFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Initial_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete name field
        /// </summary>
        void DeleteNameFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Name_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Name_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete email field
        /// </summary>
        void DeleteEmailFieldPrivate()
        {
            try
            {

                Thread.Sleep(2000);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Email_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Email_Field_Delete_Cog_CSS_Selector)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Delete job title field
        /// </summary>
        void DeleteJobTitleFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Job_Title_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Job_Title_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete company field
        /// </summary>
        void DeleteCompanyFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Company_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Company_Field_Delete_Cog_CSS_Selector)).Click();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete date field
        /// </summary>
        void DeleteDateFieldPrivate()
        {
            try
            {
                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Date_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Date_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete text field
        /// </summary>
        void DeleteTextFieldPrivate()
        {
            try
            {

                //Edit task
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Text_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Text_Field_Delete_Cog_CSS_Selector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete check box field
        /// </summary>
        void DeleteCheckBoxFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_CheckBox_Field_Delete_Cog_CSS_Selector)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Delete Radio field
        /// </summary>
        void DeleteRadioFieldPrivate()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Radio_Field_CSS_Selector)));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Thread.Sleep(500);
                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Radio_Field_Delete_Cog_CSS_Selector)).Click();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #endregion

        #region Form fields with different font sizes and styles

        void FormFieldNameWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Name_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);

                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Left_Panel_Toggle_CSS_Selector)).Click();
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

        void FormFieldEmailWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Email_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);            

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

        void FormFieldJobWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_JobTitle_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);

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

        void FormFieldCompanyTextWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Company_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);

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

        void FormFieldDateWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Date_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);

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

        void FormFieldTextboxWithDifferentFontsPrivate()
        {
            try
            {
                //Upload library document
                new NewWorkflowUploadDocument().LibraryDocument();

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 50, 150);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field1_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text1_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 70, 200);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field2_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text2_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 90, 250);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field3_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text3_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 110, 300);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field4_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text4_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 130, 350);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field5_Settings_CSS_Selector, Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text5_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 150, 400);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field6_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text6_Field_Input_CSS_Selector, TestData.Company_Name);

                //Drop name field
                DropField(Elements_Paths.Viewer_Image1_CSS_Selector, Elements_Paths.Workflow_Text_Field_CSSSelector, 170, 450);

                //Chage font size
                FormFieldsFontChange(Elements_Paths.Viewer_Form_Field7_Settings_CSS_Selector, Elements_Paths.Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector);

                //Add text in field
                AddTextinField(Elements_Paths.Viewer_Text7_Field_Input_CSS_Selector, TestData.Company_Name);                

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
        #endregion

        void AssignUassignedFieldToSignerPrivate()
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
                UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Unassigned_Field_Document, 4000);

                //Click on NEXT button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(3000);

                //Add Recipients
                WorkflowAddRecipientPrivate();

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
        /// Add recipients on viewer
        /// </summary>
        public void WorkflowAddRecipientPrivate()
        {
            try
            {
                //open recipients dialog
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Recipient_Dialog_CSS_Selector)).Click();

                FindElement(driver, By.CssSelector(".icon.icon-add-recipient")).Click();

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).Click();

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(TestData.Email_Address);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Enter);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient1_Click_XPath)).SendKeys(Keys.Tab);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(TestData.Email_Address);

                FindElement(driver, By.XPath(Elements_Paths.New_Workflow_Add_Recipient2_Click_XPath)).SendKeys(Keys.Enter);

                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Upload a document from file system
        /// </summary>
        void UploadFileSystemDocumentPrivate()
        {
            try
            {  
                //Upload document
                UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Sample_Upload_Document_Name, 4000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ShareDocumentPrivate()
        {
            try
            {
                //Click on share button
                FindElement(driver, By.CssSelector(Elements_Paths.New_Workflow_NextButton_CssSelector)).Click();
                Thread.Sleep(5000);

                //Click on model close button
                FindElement(driver, By.CssSelector(Elements_Paths.Model_Close_CSSSelector)).Click();
                Thread.Sleep(1000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void ChangeRecipientPendingPrivate()
        {
            try
            {
                //Add D-sign and E-sign fields
                Thread.Sleep(1000);

                //Add D-sign and E-sign fields
                Thread.Sleep(5000);
                AddDSignFieldPrivate();
                Thread.Sleep(2000);
                AddESignFieldPrivate();

                //Share document
                Thread.Sleep(2000);
                ShareDocumentPrivate();
                Thread.Sleep(5000);

                //Select All documents filter
                FindElement(driver, By.Id(Elements_Paths.Filter_Pending_IdSelector)).Click();
                Thread.Sleep(2000);

                //Open document again
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Open_Document_XPath)).Click();
                Thread.Sleep(5000);

                //Change recipient 1
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Recipient_Dialog_CSS_Selector)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_First_Signer_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_First_Signer_CSS_Selector)).SendKeys(TestData.New_Workflow_Recipient2_Name);
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_First_Signer_CSS_Selector)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_First_Signer_CSS_Selector)).SendKeys(Keys.Tab);
                Thread.Sleep(2000);

                //Change recipient 2
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_Second_Signer_CSS_Selector)).Clear();
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_Second_Signer_CSS_Selector)).SendKeys(TestData.New_Workflow_Recipient1_Name);
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_Second_Signer_CSS_Selector)).SendKeys(Keys.Enter);
                Thread.Sleep(1000);
                FindElement(driver, By.CssSelector(Elements_Paths.Viewer_Change_Recipient_Pending_Second_Signer_CSS_Selector)).SendKeys(Keys.Tab);
                FindElement(driver, By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                //Log test case

                Thread.Sleep(5000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void DropField(string imagePage, string field, int xOfset, int yOfset)
        {
            try
            {
                Actions builder = new Actions(driver);
                //Field Element
                IWebElement fieldElement = driver.FindElement(By.CssSelector(field));

                //Image of document
                IWebElement documentImage = driver.FindElement(By.CssSelector(imagePage));

                //Dropping field at location
                builder.ClickAndHold(fieldElement).MoveToElement(documentImage, xOfset, yOfset).Release().Build().Perform();
                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void FormFieldsFontChange(string fieldName, string fontSize)
        {
            try
            {
                var fieldSettings = FindElement(driver, By.CssSelector(fieldName));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", fieldSettings);
                Thread.Sleep(1000);

                driver.FindElement(By.CssSelector(Elements_Paths.Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector)).Click();

                var fontList = FindElement(driver, By.CssSelector(fontSize));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", fontList);

                driver.FindElement(By.CssSelector(Elements_Paths.General_Modal_Primary_Button_CSSSelector)).Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void AddTextinField(string fieldName, string textData)
        {
            try
            {
                //Click on text field
                driver.FindElement(By.CssSelector(fieldName)).Click();

                //Add text in field
                driver.FindElement(By.CssSelector(fieldName)).SendKeys(textData);

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
    }
}
