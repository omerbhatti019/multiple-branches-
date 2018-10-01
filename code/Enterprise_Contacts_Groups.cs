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
    /// Enterprise Contacts and Groups
    /// </summary>
    class Enterprise_Contacts_Groups : General_Methods
    {
        Dashboard dashboard = new Dashboard();
        Enterprise_Roles enterpriseRoles = new Enterprise_Roles();

        #region
        [Test]
        public void AllEnterpriseContactsGroups()
        {
            try
            {
                //Add contact
                dashboard.NavigationToEnterpriseSettings();

                if (IsElementExists(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)))
                {
                    AddEnterpriseContactPrivate();

                    //Add bulk contact
                    dashboard.NavigationToEnterpriseSettings();
                    AddEnterpriseContactsBulkPrivate();

                    //Update contact
                    dashboard.NavigationToEnterpriseSettings();
                    EditEnterpriseContactPrivate();

                    //Delete contact
                    dashboard.NavigationToEnterpriseSettings();
                    DeleteEnterpriseContactPrivate();

                    //Validate duplicate contact
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateDuplicateContactPrivate();

                    //Validate Add Contact with Mandatory field 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddEnterpriseContactMandatoryFieldsPrivate();

                    //Validate Update Contact with Mandatory field 
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateEnterpriseContactMandatoryFieldsPrivate();

                    //Add group
                    dashboard.NavigationToEnterpriseSettings();
                    AddEnterpriseGroupPrivate();

                    //Update group
                    dashboard.NavigationToEnterpriseSettings();
                    EditEnterpriseGroupPrivate();

                    //Delete group
                    dashboard.NavigationToEnterpriseSettings();
                    DeleteEnterpriseGroupPrivate();

                    //Validation add duplicate Group           
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddDuplicateGroupPrivate();

                    //Validation update duplicate Group                
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateDuplicateGroupPrivate();

                    //View group members details               
                    dashboard.NavigationToEnterpriseSettings();
                    ViewGroupMembersPrivate();

                    //Validate add group without members
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddGroupWithoutMembersPrivate();

                    //Validate update group without members
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateGroupWithoutMembersPrivate();

                    //Update settings in role
                    enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                    //Validation Add Group when option not allowed in role
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddGroupPrivate();

                    //Validation Update Group when option not allowed in role
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateGroupPrivate();

                    //Validation Delete Group when option not allowed in role
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateDeleteGroupPrivate();

                    //Validate security checks for add contact
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddContactPrivate();

                    //Validate security checks for update contact
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateUpdateContactPrivate();

                    //Validate security checks for delete contact
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateDeleteContactPrivate();

                    //Validate security checks for add bulk contact
                    dashboard.NavigationToEnterpriseSettings();
                    ValidateAddBulkContactPrivate();

                    //log test method
                    LogTestCase(GetCurrentMethod());
                }
                else
                    LogTestCase(GetCurrentMethod(), TestData.Enterprise_Contacts_and_Groups_Option + TestData.Option_Is_Not_Allowed_In_Role, new Exception());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Test Methods for Enterprise Contacts.

        #region Add Enterprise Contact
        /// <summary>
        /// Add Enterprise Contact.
        /// </summary>
        [Test]
        public void AddEnterpriseContact()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddEnterpriseContactPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Add Enterprise Contacts in Bulk
        ///<summary>
        ///Add Enterprise Contacts in Bulk
        /// </summary>
        [Test]
        public void AddEnterpriseContactsBulk()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddEnterpriseContactsBulkPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Edit Enterprise Contact
        /// <summary>
        /// Edit Enterprise Contact.
        /// </summary>
        [Test]
        public void EditEnterpriseContact()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditEnterpriseContactPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Delete Enterprise Contact
        /// <summary>
        /// Delete Enterprise Contact.
        /// </summary>
        [Test]
        public void DeleteEnterpriseContact()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteEnterpriseContactPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Public Nagtive Test cases of contacts       
        ///<summary>
        ///Validate Duplicate Contacts.
        /// </summary>   
        [Test]
        public void ValidateDuplicateContact()
        {

            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateDuplicateContactPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        ///Validate Add Contact with Mandatory field .
        /// </summary>   
        [Test]
        public void ValidateAddEnterpriseContactMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateAddEnterpriseContactMandatoryFieldsPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        ///Validate Update Contact with Mandatory field .
        /// </summary>   
        [Test]
        public void ValidateUpdateEnterpriseContactMandatoryFields()
        {

            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateEnterpriseContactMandatoryFieldsPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        /// Validate security checks while add contact when option no more allowed in role
        /// </summary>        
        [Test]
        public void ValidateAddContact()
        {

            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                //Validate add contact
                ValidateAddContactPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while Update contact when option no more allowed in role
        /// </summary>
        [Test]
        void ValidateUpdateContact()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                //Validate update contact
                ValidateUpdateContactPrivate();

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        /// Validate security checks while delete contact when option no more allowed in role
        /// </summary>        
        [Test]
        public void ValidateDeleteContact()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                ValidateDeleteContactPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        /// Validate security checks while add bulk contact when option no more allowed in role
        /// </summary>
        [Test]
        public void ValidateAddBulkContact()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                ValidateAddBulkContactPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #endregion

        #region Test Methods for Enterprise Groups.


        /// <summary>
        /// Add Enterprise Group.
        /// </summary>
        #region
        [Test]
        public void AddEnterpriseGroup()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                AddEnterpriseGroupPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        /// <summary>
        /// Edit Enterprise Group.
        /// </summary>
        #region
        [Test]
        public void EditEnterpriseGroup()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                EditEnterpriseGroupPrivate();
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        /// <summary>
        /// Delete Enterprise Group.
        /// </summary>
        #region
        [Test]
        public void DeleteEnterpriseGroup()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                DeleteEnterpriseGroupPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Nagetive Group test cases

        /// <summary>
        /// Validation add duplicate Group.
        /// </summary>
        [Test]
        public void AddDuplicateGroup()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ValidateAddDuplicateGroupPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validation update duplicate Group
        /// </summary>
        [Test]
        public void UpdateDuplicateGroup()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();
                ValidateUpdateDuplicateGroupPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// View group members details
        /// </summary>
        [Test]
        void ViewGroupMembers()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ViewGroupMembersPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate add group without members
        /// </summary>
        [Test]
        public void ValidateAddGroupWithoutMembers()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ValidateAddGroupWithoutMembersPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validate update group without members
        /// </summary>
        [Test]
        public void ValidateUpdateGroupWithoutMembers()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ValidateUpdateGroupWithoutMembersPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validate add group without Mandatory fields
        /// </summary>
        [Test]
        public void ValidateAddEnterpriseGroupMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ValidateAddEnterpriseGroupMandatoryFieldsPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validate update group without Mandatory fields
        /// </summary>
        [Test]
        public void ValidateUpdateEnterpriseGroupMandatoryFields()
        {
            try
            {
                dashboard.NavigationToEnterpriseSettings();

                ValidateUpdateEnterpriseGroupMandatoryFieldsPrivate();

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validation Add Group when option not allowed in role
        /// </summary>
        [Test]
        public void ValidateAddGroup()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                ValidateAddGroupPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validation Update Group when option not allowed in role
        /// </summary>
        [Test]
        public void ValidateUpdateGroup()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                ValidateUpdateGroupPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validation Delete Group when option not allowed in role
        /// </summary>
        [Test]
        public void ValidateDeleteGroup()
        {
            try
            {
                //Navigate to enterprise settings
                dashboard.NavigationToEnterpriseSettings();

                //Update settings in role
                enterpriseRoles.UpdateEnterpriseRole(Elements_Paths.Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector, Elements_Paths.Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID);

                ValidateDeleteGroupPrivate();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        #endregion

        #endregion Test Methods for Enterprise Groups.


        #region Private Methods for Enterprise Contacts

        #region Private Method to Add Enterprise Contact.      
        /// <summary>
        /// Private Method to Add Enterprise Contact.
        /// </summary>
        void AddEnterpriseContactPrivate()
        {
            try
            {
                //Add contact
                AddContact();

                //Success message validation
                Thread.Sleep(1000);
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Contact_Added_Success_Message + TestData.Contact_Name, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Add Contact activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Contact_Added_Activity_Log_Text, AddContactActivity.Text);
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Add Enterprise Contact in Bulk.
        /// <summary>
        /// Private Method to Add Enterprise Contact in Bulk.
        /// </summary>
        void AddEnterpriseContactsBulkPrivate()
        {
            try
            {

                //Add bulk contacts 
                AddBulkContact();

                //Click User Dropdown
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                //Click Activity
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                ////Add Contact activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Bulk_Contacts_Added_Activity_Log_Text, AddContactActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Edit Enterprise Contact      
        /// <summary>
        /// Private Method to Edit Enterprise Contact.
        /// </summary>
        void EditEnterpriseContactPrivate()
        {
            try
            {
                //Update contact
                UpdateContact();

                //Success message validation
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Contact_Updated_Success_Message + TestData.Updated_Contact_Name, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit Contact activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Contact_Updated_Activity_Log_Text, AddContactActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Private Method to Delete Enterprise Contact      
        /// <summary>
        /// Private Method to Delete Enterprise Contact.
        /// </summary>
        void DeleteEnterpriseContactPrivate()
        {
            try
            {
                //Delete Contact
                DeleteContact();

                //Success message validation
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Contact_Deleted_Success_Message + TestData.Updated_Contact_Name, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Delete Contact activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Contact_Deleted_Activity_Log_text, AddContactActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #endregion         

        #region Contacts CURD methods

        void AddContact()
        {
            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();

                //Click on Add Contact button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Add email address and name
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_ContactName_TextField_CssSelector)).SendKeys(TestData.Contact_Name);
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_ContactEmail_TextField_CssSelector)).SendKeys(TestData.Contact_Email_Address);

                //Save contact
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void AddBulkContact()
        {
            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();

                //Click on Add Contact button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Click import contacts tab
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Bulk_Contacts_CSSSelector)).Click();

                UploadDocument(Elements_Paths.Upload_Icon_By_CssSelector, TestData.Sample_CSV_Upload_Document_Name, 1000);
                                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        void UpdateContact()
        {
            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();
                //Contact Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Contact_Email_Address);

                try
                {
                    //Edit Contact
                    FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                }
                catch (Exception)
                {
                    AddContact();
                    Thread.Sleep(1000);
                    //Edit Contact
                    FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                }

                //Clear contact name
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_ContactName_TextField_CssSelector)).Clear();
                //Enter new name
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_ContactName_TextField_CssSelector)).SendKeys(TestData.Updated_Contact_Name);
                //Click save
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void DeleteContact()
        {
            //Click Contacts
            FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();
            //Search Contacts
            FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Contact_Name);

            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                ////Select Checkbox
                //FindElement(driver, By.ClassName(Elements_Paths.General_Checkbox_ClassName)).Click();
                //Click delete button
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
            }
            catch (Exception)
            {
                AddContact();
                Thread.Sleep(1000);

                //Select Checkbox
                FindElement(driver, By.ClassName(Elements_Paths.General_Checkbox_ClassName)).Click();
                //Click delete button
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
            }

            //Click Yes button
            FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
            //Clear Search
            FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();
        }

        #endregion

        #region Negative Cases Contacts       

        /// <summary>
        /// Private Method to check Duplicate Contacts.
        /// </summary>        
        void ValidateDuplicateContactPrivate()
        {

            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Contact_Name);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add contact
                    AddContact();
                }

                //Add again same contact 
                AddContact();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Duplicate_Contact_Message, ToasterMessage.Text);

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }

        }

        /// <summary>
        /// Validate security checks while add contact when option no more allowed in role
        /// </summary>
        void ValidateAddContactPrivate()
        {
            try
            {
                //Add contact
                AddContact();

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));

                if (ToasterMessage.Text == TestData.Duplicate_Contact_Message)
                    LogResult(GetCurrentMethod());
                else
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
        /// Validate security checks while Update contact when option no more allowed in role
        /// </summary>
        void ValidateUpdateContactPrivate()
        {
            try
            {
                //Update contact
                UpdateContact();

                //Validate error message 
                if (IsElementExists(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Css_Selector)))
                {
                    ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                    Assert.AreEqual(TestData.Role_Invalid_Operation_Error_Message, ToasterMessage.Text);

                }

                //Log the test case
                LogResult(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while add bulk contact when option no more allowed in role
        /// </summary>
        void ValidateAddBulkContactPrivate()
        {
            try
            {
                //Add bulk contact
                AddBulkContact();

                //Log the test case
                LogResult(GetCurrentMethod());

            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate security checks while Delete contact when option no more allowed in role
        /// </summary>
        void ValidateDeleteContactPrivate()
        {
            try
            {
                //Delete contact
                DeleteContact();

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
        /// Validate Add Enterprise Contact Mandatory field 
        /// </summary>
        void ValidateAddEnterpriseContactMandatoryFieldsPrivate()
        {
            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();

                //Click on Add Contact button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Save contact
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);

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

        /// <summary>
        /// Validate Update Enterprise Contact Mandatory field 
        /// </summary>
        void ValidateUpdateEnterpriseContactMandatoryFieldsPrivate()
        {
            try
            {
                //Click Contacts
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Contacts_ID)).Click();

                //Search Contacts
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Contact_Name);

                //Check if contact already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add contact
                    AddContact();
                    Thread.Sleep(1000);

                    FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)).Click();
                }

                //Edit Contact
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                //Clear contact name
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_ContactName_TextField_CssSelector)).Clear();

                //Save contact
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);

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

        #endregion

        #region Private Methods for Enterprise Groups

        ///<summary>
        ///Private method for Add Enterprise Group
        /// </summary>
        void AddEnterpriseGroupPrivate()
        {
            try
            {

                //Add Group
                AddGroup(TestData.New_Group_Name);

                //Success message validation
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.New_Group_Name + TestData.Group_Added_Success_Message, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();
                Thread.Sleep(1000);

                //Add Group activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Group_Added_Activity_Text, AddContactActivity.Text);
                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        ///Private method for Edit Enterprise Group
        /// </summary>
        void EditEnterpriseGroupPrivate()
        {
            try
            {
                //Update Group
                UpdateGroup(TestData.Update_Group_Name);

                //Clear the search box
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Success message validation
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Update_Group_Name + TestData.Group_Updated_Success_Message, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Edit Group activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Group_Updated_Activity_Text, AddContactActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        ///<summary>
        ///Private method for Delete Enterprise Group
        /// </summary>
        void DeleteEnterpriseGroupPrivate()
        {
            try
            {

                //Delete Group
                DeleteGroup(TestData.Update_Group_Name);

                //Success message validation
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector));
                Assert.AreEqual(TestData.Update_Group_Name + TestData.Group_Deleted_Success_Message, ToasterMessage.Text);

                //User activity log verfication
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Menu_Option_ID)).Click();
                FindElement(driver, By.Id(Elements_Paths.Dashboard_Activity_ID)).Click();

                //Delete Group activity validation
                IWebElement AddContactActivity = FindElement(driver, By.CssSelector(Elements_Paths.Activity_Logs_Verify_CSS_Selector));
                Assert.AreEqual(TestData.Group_Deleted_Activity_Text, AddContactActivity.Text);

                //log test method
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion Private Methods for Enterprise Groups

        #region Groups CURD methods


        void AddGroup(string groupName)
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Click on Add group button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Enter group name
                FindElement(driver, By.CssSelector(Elements_Paths.GroupName_TextField_CssSelector)).SendKeys(groupName);
                //Enter group description
                FindElement(driver, By.XPath(Elements_Paths.GroupDescription_TextField_XPath)).SendKeys(TestData.New_Group_Description);
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Group_Member_TextField_CssSelector)).SendKeys(TestData.New_Group_Member1);
                FindElement(driver, By.XPath(Elements_Paths.Add_Group_Memeber_Button_XPath)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Group_Member_TextField_CssSelector)).SendKeys(TestData.New_Group_Member2);
                FindElement(driver, By.XPath(Elements_Paths.Add_Group_Memeber_Button_XPath)).Click();

                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void UpdateGroup(string groupName)
        {
            try
            {

                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();
                //Group Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.New_Group_Name);

                //Edit Group
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();
                IWebElement Group_Name_TextField = FindElement(driver, By.CssSelector(Elements_Paths.GroupName_TextField_CssSelector));
                Group_Name_TextField.Clear();
                Group_Name_TextField.SendKeys(groupName);
                IWebElement Group_Description_TextField = FindElement(driver, By.XPath(Elements_Paths.GroupDescription_TextField_XPath));
                Group_Description_TextField.Clear();
                Group_Description_TextField.SendKeys(TestData.Update_Group_Description);

                IWebElement RemoveGroupMember = FindElement(driver, By.CssSelector(Elements_Paths.Remove_Group_Member_Button_CssSelector));
                RemoveGroupMember.Click();

                FindElement(driver, By.CssSelector(Elements_Paths.Add_Group_Member_TextField_CssSelector)).SendKeys(TestData.Update_Group_Member);
                FindElement(driver, By.XPath(Elements_Paths.Add_Group_Memeber_Button_XPath)).Click();
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        void DeleteGroup(string groupName)
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();
                //Search Group
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(groupName);

                try
                {
                    //Select Checkbox
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                    AddGroup(groupName);

                    FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(groupName);

                    //Select Checkbox
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }

                //Click delete button
                FindElement(driver, By.CssSelector(Elements_Paths.Delete_Icon_CssSelector)).Click();
                //Delete confirmation dialog box
                IWebElement DeleteContactConfirmation = FindElement(driver, By.ClassName(Elements_Paths.Delete_Confirmation_Text_ClassName));
                Assert.AreEqual(TestData.Delete_Group_Confirmation_Text + groupName + "?", DeleteContactConfirmation.Text);
                //Click Yes button
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Negative Cases Groups

        /// <summary>
        /// Validate add duplicate group
        /// </summary>
        void ValidateAddDuplicateGroupPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Search Groups
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Group_Name);

                //Check if group already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add Group
                    AddGroup(TestData.Group_Name);
                }

                //Add again same group
                AddGroup(TestData.Group_Name);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Duplicate_Group_Message, ToasterMessage.Text);

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate update duplicate group
        /// </summary>
        void ValidateUpdateDuplicateGroupPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Search Groups
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.New_Group_Name);

                //Check if group already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add Group
                    AddGroup(TestData.New_Group_Name);
                }

                //Clear search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Update group
                UpdateGroup(TestData.Group_Name);

                //Validate error message 
                ToasterMessage = FindElement(driver, By.CssSelector(Elements_Paths.General_Error_Toaster_Message_Text_Css_Selector));
                Assert.AreEqual(TestData.Duplicate_Group_Message, ToasterMessage.Text);

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// View group members details
        /// </summary>
        void ViewGroupMembersPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Group Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Group_Name);

                //View group members details
                FindElement(driver, By.CssSelector(Elements_Paths.View_Group_Members_CSS_Selector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate add group without members
        /// </summary>
        void ValidateAddGroupWithoutMembersPrivate()
        {
            try
            {

                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Click on Add group button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Enter group name
                FindElement(driver, By.CssSelector(Elements_Paths.GroupName_TextField_CssSelector)).SendKeys(TestData.New_Group_Name);

                //Enter group description
                FindElement(driver, By.XPath(Elements_Paths.GroupDescription_TextField_XPath)).SendKeys(TestData.New_Group_Description);

                //Click on savce
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Validate update group without members
        /// </summary>
        void ValidateUpdateGroupWithoutMembersPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Group Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.Group_Name);

                //Click Edit Group
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                //Remove first group member
                IWebElement RemoveGroupMember = FindElement(driver, By.CssSelector(Elements_Paths.Remove_Group_Member_Button_CssSelector));
                RemoveGroupMember.Click();

                //Remove first group member
                IWebElement RemoveSecondGroupMember = FindElement(driver, By.CssSelector(Elements_Paths.Remove_Group_Member_Button_CssSelector));
                RemoveSecondGroupMember.Click();

                //Click on save 
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();

                //Clear Search
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).Clear();

                //Log the test case
                LogResult(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        /// <summary>
        /// Validate security checks while add group when option no more allowed in role
        /// </summary>
        void ValidateAddGroupPrivate()
        {
            try
            {
                //Add group
                AddGroup(TestData.Validate_Group_Name);

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
        /// Validate security checks while update group when option no more allowed in role
        /// </summary>
        void ValidateUpdateGroupPrivate()
        {
            try
            {
                //Update group
                UpdateGroup(TestData.Validate_Group_Name);

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
        /// Validate security checks while delete group when option no more allowed in role
        /// </summary>
        void ValidateDeleteGroupPrivate()
        {
            try
            {
                //Update group
                DeleteGroup(TestData.Group_Name);

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
        /// Validate Add Enterprise Group Mandatory field 
        /// </summary>
        void ValidateAddEnterpriseGroupMandatoryFieldsPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Click on Add group button            
                FindElement(driver, By.CssSelector(Elements_Paths.Add_Icon_CssSelector)).Click();

                //Save
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);

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

        /// <summary>
        /// Validate Update Group Mandatory field 
        /// </summary>
        void ValidateUpdateEnterpriseGroupMandatoryFieldsPrivate()
        {
            try
            {
                //Click Groups
                FindElement(driver, By.Id(Elements_Paths.Enterprise_Groups_ID)).Click();

                //Search Groups
                FindElement(driver, By.CssSelector(Elements_Paths.Search_CssSelector)).SendKeys(TestData.New_Group_Name);

                //Check if group already not exist 
                try
                {
                    FindElement(driver, By.CssSelector(Elements_Paths.Checkbox_CSS_Selector)).Click();
                }
                catch (Exception)
                {
                    //Add Group
                    AddGroup(TestData.New_Group_Name);
                    Thread.Sleep(1000);

                    FindElement(driver, By.CssSelector(Elements_Paths.Toaster_Success_Message_CSSSelector)).Click();
                }

                //Edit Group
                FindElement(driver, By.CssSelector(Elements_Paths.Edit_Icon_CssSelector)).Click();

                //Clear name
                FindElement(driver, By.CssSelector(Elements_Paths.GroupName_TextField_CssSelector)).Clear();

                //Save
                FindElement(driver, By.CssSelector(Elements_Paths.Submit_DialogBox_CssSelector)).Click();
                Thread.Sleep(1000);

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


        #endregion
    }
}
