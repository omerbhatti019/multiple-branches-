namespace IntegrationTest
{
    public class Elements_Paths : General_Methods
    {
        #region Elements paths for Register
        public const string Register_SignUp_ClassName = "sign-up";
        public const string Register_UserName_ID = "userName";
        public const string Register_EmailAddress_ID = "email1";
        public const string Register_Mobile_ID = "mobile";
        public const string Register_Job_ID = "job";
        public const string Register_Company_ID = "company";
        public const string Register_CheckBox_Term_ID = "check";
        public const string Register_Primary_Button_CSSSelector = ".btn-primary";
        public const string Register_ServicePanType_Radio_ID = "Radio1";
        public const string Register_PaymentType_Option_ID = "paymentDropdown";
        public const string Register_PaymentType_CSSSelector = ".dropdown-menu li:nth-child(1)";
        public const string Register_PaymentType_PayAsYouGo_CSSSelector = ".dropdown-menu li:nth-child(2)";
        public const string Register_Enterprise_ServicePlan_ID = "30";
        public const string Register_Individual_ServicePlan_ID = "37";
        public const string Register_Enterprise_ServicePlan_Billing_ID = "99";
        public const string Register_CreateAccount_Button_CSSSelector = ".remove-margin-bottom .btn-success";
        public const string Register_Resend_Email_ID = "resend-email";
        public const string Close_Model_CSSSelector = ".modal-close";

        #endregion

        #region Elements paths for login
        ///<summary>
        /// Elements paths for SigningHubID
        /// </summary>
        public const string Login_Email_ID = "email";
        public const string General_Success_Button_CSSSelector = ".btn-success";
        public const string Login_Password_ID = "passwordInput";
        public const string Login_Forgot_Password_ID = "forgot-password";
        public const string Login_Forgot_Password_Email_ID = "forgot-password";
        public const string General_Modal_Primary_Button_CSSSelector = ".modal-footer .btn-primary";
        public const string General_Modal_Default_Button_CSSSelector = ".modal-footer .btn-default";
        public const string Login_Remember_Me_ID = "remember-me";



        ///<summary>  
        ///Element path for alerts/toaster messages
        /// </summary>

        public const string Toaster_Success_Message_CSSSelector = ".toast-message";

        ///<summary>
        ///Element path for more login option
        /// </summary>
        public const string Login_More_Options_CSSSelector = ".text-center .pointer";
        public const string Login_More_Options_Google_ID = "Google";
        public const string Login_More_Options_LinkedIn_ID = "LinkedIn";
        public const string Login_More_Options_ConsentID_ID = "ConsentID";
        public const string Login_More_Options_Freja_Mobilec_ID = "Freja Mobile Authentication";
        public const string Login_More_Options_Freja_eID_ID = "Freja eID";
        public const string Login_More_Options_Office365_ID = "Office 365";
        public const string Login_More_Options_SSL_ID = "SSL Client Authentication";
        public const string Login_More_Options_Salesforce_ID = "Salesforce";

        ///   ///<summary>
        /// Elements paths for Google authentictaion
        /// </summary>
        public const string Login_Google_Email_ID = "identifierId";
        public const string Login_Google_Next_Button_ID = "identifierNext";        
        public const string Login_Google_Next_Button_CSSSelector = ".CwaK9 .snByac";
        public const string Login_Google_Password_Name = "password";
        public const string Login_Google_Password_Next_Button_ID = "passwordNext";
        

        ///   ///<summary>
        /// Elements paths for LinkedIn authentictaion
        /// </summary>
        public const string Login_LinkedIn_Email_ID = "session_key-login";
        public const string Login_LinkedIn_Password_ID = "session_password-login";
        public const string Login_LinkedIn_Button_Name = "signin";

        ///<summary>
        /// Elements paths for Office 365 authentictaion
        /// </summary>
        public const string Login_Office365_Email_ID = "i0116";
        public const string Login_Office365_Button_ID = "idSIButton9";
        public const string Login_Office365_Password_ID = "i0118";

        ///   ///<summary>
        /// Elements paths for SalesForce authentictaion
        /// </summary>
        public const string Login_SalesForce_Email_ID = "username";
        public const string Login_SalesForce_Password_ID = "password";
        public const string Login_SalesForce_Button_ID = "Login";
        public const string Login_SalesForce_Allow_Button_ID = "oaapprove";
        #endregion

        #region Elements paths for Dashboard links 
        ///<summary>
        ///Element paths for menu options
        /// </summary>
        public const string Dashboard_Menu_Option_ID = "userDrop";
        public const string Dashboard_Enterprise_Settings_ID = "menu-enterprise-profile";
        public const string Dashboard_MySettings_ID = "menu-personal-profile";
        public const string Dashboard_ServicePlan_ID = "menu-service-plan";
        public const string Dashboard_Billing_ID = "menu-billing";
        public const string Dashboard_Activity_ID = "menu-activity";
        public const string Dashboard_Help_ID = "menu-help";
        public const string Dashboard_About_ID = "menu-about";
        public const string Dashboard_Logout_ID = "menu-logout";        
        public const string Dashboard_Service_Upgrade_Button_CSSSelector = ".modal-footer .btn-success";
        public const string Dashboard_User_Stats_CSSSelector = ".top-signers-block .dropdown";
        public const string Dashboard_User_Stats_Top_Signer_CSSSelector = ".top-signers-block .dropdown .dropdown-menu li:nth-child(1)";
        public const string Dashboard_User_Stats_Top_Sender_CSSSelector = ".top-signers-block .dropdown .dropdown-menu li:nth-child(2)";

        ///<summary>
        ///Element paths for dashboard & document link
        /// </summary>
        public const string Dashboard_Main_CssSelector = "[href*='#/Dashboard']";
        public const string Dashboard_Main_Document_CssSelector = "[href*='#/Home']";

        ///<summary>
        ///Element paths for counts
        /// </summary>
        public const string Dashboard_Count_Pending_ID = "pending";
        public const string Dashboard_Count_InProgress_ID = "inprogress";
        public const string Dashboard_Count_Declined_ID = "declined";
        public const string Dashboard_Count_Completed_ID = "completed";

        ///<summary>
        ///Element paths for workflow
        /// </summary>
        public const string Dashboard_Workflow_Dropdown_CSSSelector = ".workflow-dropdown .dropdown-toggle";
        public const string Dashboard_New_Workflow_CSSSelector = ".workflow-dropdown .btn-holder .btn";
        public const string Dashboard_Workflow_Only_ME_CSSSelector = ".workflow-dropdown li:nth-child(1) a";
        public const string Dashboard_Workflow_Me_Others_CSSSelector = ".workflow-dropdown li:nth-child(2) a";
        public const string Dashboard_Workflow_Just_Others_CSSSelector = ".workflow-dropdown li:nth-child(3) a";
        public const string Dashboard_Workflow_Cancel_CSSSelector = ".icon";
        public const string Upload_Document_Fail_CSS_Selector = ".progress.upload-item.failure";
        public const string Upload_Document_Fail_Text_CSS_Selector = ".progress.upload-item.failure .item .row div:nth-child(2)";

        ///<summary>
        ///Element paths for settings actions links
        /// </summary>
        public const string Dashboard_Perosnal_Edit_CSSSelector = "[ui-sref='personal.profile']";
        public const string Dashboard_Perosnal_Signature_CssSelector = "[href*='#/Settings/Signature']";
        public const string Dashboard_Personal_Templates_CssSelector = "[href*='#/Settings/Templates']";
        public const string Dashboard_Personal_Contacts_CssSelector = "[href*='#/Settings/Contacts']";
        public const string Dashboard_Personal_Delegate_CssSelector = "[href*='#/Settings/Delegate']";
        public const string Dashboard_Personal_Notifications_CssSelector = "[href*='#/Settings/Notifications']";
        public const string Dashboard_Enterprise_Users_CssSelector = "[href*='#/Enterprise/Users']";
        public const string Dashboard_Enterprise_Templates_CssSelector = "[href*='#/Enterprise/Templates']";
        public const string Dashboard_Enterprise_APIKey_CssSelector = "[href*='#/Enterprise/Integration']";
        public const string Dashboard_Enterprise_Branding_CssSelector = "[href*='#/Enterprise/Branding']";
        public const string Dashboard_Enterprise_Contacts_CssSelector = "[href*='#/Enterprise/Contacts']";
        public const string Dashboard_Enterprise_Users_View_CSSSelector = ".top-users-block .personal-info-edit .text-blue";
        public const string Dashboard_Enterprise_Stats_More_CSSSelector = ".top-signers-block .personal-info-edit .text-blue";
        public const string Dashboard_Service_Plan_Button_ID = "btn-upgrade";
        public const string Dashboard_Service_Cancel_Button_CSSSelector = ".modal-footer .btn-default";

        ///<summary>
        ///Element paths for dashboard footer link
        /// </summary>
        public const string Dashboard_Footer_About_CSSSelector = " .footer-links li:nth-child(1) a";
        public const string Dashboard_terms_CSSSelector = " .footer-links li:nth-child(2) a";
        public const string Dashboard_Locale_Dropdown_ID = "dropdownMenu2";
        public const string Dashboard_Locale_ID = "en-US";
        #endregion

        #region Elements paths for activity logs 
        public const string Activity_Logs_Verify_XPath = "/html/body/div/div/div/div/div[2]/div/div[2]/div[1]/div/div[3]/span";
        public const string Activity_Logs_Verify_Second_Activity_XPath = "/html/body/div/div/div/div/div[2]/div/div[2]/div[2]/div/div[3]/span";
        public const string Activity_Logs_Verify_CSS_Selector = "div[ng-repeat$='logs.activities.logs'] > div div:nth-child(3)";
        #endregion

        #region Element paths for Id's of Personal/Enterprise Settings
        public const string Enterprise_Profile_ID = "enterprise.profile";
        public const string Enterprise_Users_ID = "enterprise.users";
        public const string Enterprise_Roles_ID = "enterprise.roles";
        public const string Enterprise_Contacts_ID = "enterprise.contacts";
        public const string Enterprise_Groups_ID = "enterprise.groups";
        public const string Enterprise_Templates_ID = "enterprise.templates";
        public const string Enterprise_Library_ID = "enterprise.library";
        public const string Enterprise_Notifications_ID = "enterprise.notificationSettings";
        public const string Enterprise_Integrations_ID = "enterprise.integration";
        public const string Enterprise_Branding_ID = "enterprise.branding";
        public const string Enterprise_Advanced_ID = "enterprise.advanced";

        public const string Personal_Profile_ID = "personal.profile";
        public const string Personal_Signatures_ID = "personal.signature";
        public const string Personal_Contacts_ID = "personal.contacts";
        public const string Personal_Groups_ID = "personal.groups";
        public const string Personal_Templates_ID = "personal.templates";
        public const string Personal_Library_ID = "personal.library";
        public const string Personal_Notifications_ID = "personal.notificationSettings";
        public const string Personal_CloudDrives_ID = "personal.clouddrive";
        public const string Personal_LegalNotices_ID = "personal.legalnotice";
        public const string Personal_DelegateSigning_ID = "personal.delegate";
        public const string Personal_Documents_ID = "personal.documents";
        #endregion

        #region Element paths for My/Enterprise settings
        /// <summary>
        /// General Element paths for My Settings and Enterprise Settings 
        /// </summary>
        //Search for Document listing, Contacts, Groups, Templates, Library, Legal Notices, Roles, Integrations..
        public const string Search_CssSelector = "[type=search]";
        public const string Common_Tab_Search_CssSelector = ".tab-pane.active [type=search]";
        //Edit icon for Contacts, Groups, Templates, Library, Legal Notices, Roles, Integrations..
        public const string Edit_Icon_CssSelector = ".icon.pull-right.edit";
        public const string Add_Icon_CssSelector = ".icon.plus-circle.pull-right";
        public const string Delete_Icon_CssSelector = ".icon.pull-right.flip.delete";


        public const string Edit_Tab_Icon_CssSelector = ".tab-pane.active .icon-edit";
        public const string Add_Tab_Icon_CssSelector = ".tab-pane.active .plus-circle";
        public const string Delete_Tab_Icon_CssSelector = ".tab-pane.active .icon-trash";
        public const string Delete_Tab_Item_Icon_CssSelector = ".tab-pane.active .delete";

        public const string Delete_Icon_Generic_CssSelector = ".icon.icon-trash";
        public const string Delete_ConfirmationYes_XPath = "/html/body/div[1]/div/div/div[3]/button[1]";
        public const string Submit_DialogBox_CssSelector = "[type=submit]";
        public const string Submit_DialogBox_Tab_CssSelector = ".tab-pane.active [type=submit]";
        public const string Upload_CSV_Contcts_Button_ClassName = ".pull-left";
        public const string General_Checkbox_ClassName = "checkbox";
        public const string Delete_Confirmation_Text_ClassName = "confirm-modal-text";
        public const string Upload_Icon_CssSelector = ".list-inline";
        public const string Delete_User_Permanent_CheckBox_ID = "deletePermanent";
        public const string Enterprise_User_Password_Change_CssSelector = ".pull-right.reset";
        public const string Enterprise_User_Activity_CssSelector = ".icon.document-log";
        public const string Search_Enter_CssSelector = ".input-group-btn .btn-submit";                

        /// <summary>
        /// Element Paths for Profile - General
        /// </summary>      
        public const string General_Username_ID = "userName";
        public const string General_MobileNumber_Name = "mobileNumber";
        public const string General_JobTitle_Name = "jobTitle";
        public const string General_Company_Name = "companyName";
        public const string General_BrowseButton_CssSelector = ".btn-default";
        public const string General_ImageCropDoneButton_XPath = "/html/body/div[1]/div/div/div[3]/button[1]/span[1]";
        public const string General_SaveButton_Id = "btn-save-personal-general-settings";
        public const string General_Profile_Image_Css_Selector = ".tab-pane.active .scroll-auto .avatar-area [type=file]";


        /// <summary>
        /// Element Paths for Profile - Change Password
        /// </summary>
        public const string ChangePassword_tab_CssSelector = ".nav-tabs li:nth-child(2) a";
        public const string ChangePassword_OldPassword_Name = "oldpassword";
        public const string ChangePassword_NewPassword_Name = "newPassword";
        public const string ChangePassword_ConfirmPassword_Name = "userConfirmPassword";
        public const string ChangePassword_SaveButton_Id = "btn-save-personal-password-settings";

        /// <summary>
        /// Element Paths for Profile - Security Question
        /// </summary>
        public const string SecurityQuestion_tab_CssSelector = ".nav-tabs li:nth-child(3) a";
        public const string SecurityQuestion_Password_ID = "passwordSQ";
        public const string SecurityQuestion_SecurityQuestion_Name = "secretQuestion";
        public const string SecurityQuestion_Answer_Name = "answer";
        public const string SecurityQuestion_SaveButton_Id = "btn-save-personal-question-settings";

        ///<summary>
        ///Element Paths for Profile - Change Locale
        /// </summary>
        public const string Profile_tab_CssSelector = ".nav-tabs li:nth-child(1) a";
        public const string Locale_tab_CssSelector = ".nav-tabs li:nth-child(4) a";
        public const string Locale_Country_Id = "locale-country";
        public const string Locale_CountryInput_CssSelector = "#locale-country .form-control";
        public const string Locale_CountrySelect_XPath = "/html/body/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/form/div/div[1]/div/div[1]/div/ul";
        public const string Locale_TimeZone_Id = "locale-timezone";
        public const string Locale_TimeZoneInput_CssSelector = "#locale-timezone .form-control";
        public const string Locale_TimeZoneSelect_XPath = "/html/body/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/form/div/div[1]/div/div[2]/div/ul";
        public const string Locale_Language_Id = "locale-language";
        public const string Locale_LanguageInput_XPath = "#locale-language .form-control";
        public const string Locale_LanguageSelect_XPath = "//*[@id='ui-select-choices-row-2-']/a";
        public const string Locale_SaveButton_Id = "btn-save-personal-locale-settings";

        /// <summary>
        /// Element Paths for Profile - Enterprise
        /// </summary>
        public const string Enterprise_tab_CssSelector = ".nav-tabs li:nth-child(5) a";

        ///<summary>
        ///Elements Paths for Enterprise User
        /// </summary>
        public const string Enterprise_User_Select_Role_ClassName = "ui-select-choices-row-inner";
        public const string Enterprise_User_Select_Role_Dropdown_ClassName = "dropdown";
        public const string Enterprise_User_Search_Role_Css_Css_Selector = ".dropdown .dropdown-menu .ui-select-choices-group span"; //div[contains(@class, 'dropdown')]/ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/span[text() = 'Enterprise Users']";  //".dropdown .dropdown-menu .ui-select-choices-group span[text = 'Enterprise Users']";
        public const string Enterprise_User_Enabled_Chcekbox_ID = "chEnable";
        public const string Enterprise_Invitation_Resend_CssSelector = ".tab-pane.active .grid-body div:nth-child(1) .pointer";
        public const string Enterprise_Invitation_Deletion_CssSelector = ".tab-pane.active .grid-body div:nth-child(1) .link-remove";
        public const string Enterprise_Stats_Topdisk_CssSelector = ".sort-menu li:nth-child(3) a";
        public const string Enterprise_Stats_Topsender_CssSelector = ".sort-menu li:nth-child(2) a";
        public const string Enterprise_Stats_Order_CssSelector = ".sort-menu li:nth-child(2) span";
        public const string Enterprise_User_Sort_Stats_One_Css_Selecter = ".tab-pane.active .grid-header > div:nth-child(3)";
        public const string Enterprise_User_Sort_Stats_Two_Css_Selecter = ".tab-pane.active .grid-header > div:nth-child(4)";
        public const string Enterprise_User_Sort_Stats_Three_Css_Selecter = ".tab-pane.active .grid-header > div:nth-child(5)";
        public const string Enterprise_User_AD_CheckBox_ID = "provisioningEnabled";
        public const string Enterprise_User_AD_Tab_ID = "provisioningEnabled";
        public const string Enterprise_User_AD_Group_Name_By_Name = "adGroupName";
        public const string Enterprise_User_Invitation_Tab_ID = "enterprise-user-invitation";
        public const string Enterprise_User_Stats_Tab_ID = "enterprise-user-stats";
        public const string Enterprise_User_Document_Stats_Tab_ID = "enterprise-user-document-stats";
        public const string Enterprise_User_ActiveDirectory_Tab_ID = "enterprise-user-active-directory";
        public const string Enterprise_User_ActiveDirectory_Group_Css_Selecter = "span[ng-click='user.adProvisioning($event)']";
        public const string Enterprise_User_Document_Charts_Tab_ID = "document-charts";
        public const string Enterprise_User_Signature_Charts_Tab_ID = "signature-stats";
        public const string Enterprise_User_Document_Bar_Charts_Css_Selector = ".tab-pane.active .bar-chart .custom-popover .btn-default";
        public const string Enterprise_User_Document_Line_Charts_Css_Selector = ".tab-pane.active .line-chart .custom-popover .btn-default";

        ///<summary>
        /// Element Paths for Personal Signature Settings
        /// </summary>                
        // Signature Appearance
        public const string Personal_Signatures_SignatureAppearacne_Web_DrawCheckbox_Id = "drawSignature";
        public const string Personal_Signatures_SignatureAppearacne_Web_TextCheckbox_CSS_Selector = "label[for='signature.hand_web.text']";
        public const string Personal_Signatures_SignatureAppearacne_Web_TextInput_XPath = "//*[@id='webSigTxt']";
        public const string Personal_Signatures_SignatureAppearacne_Web_UploadCheckbox_CSS_Selector = "label[for= 'signature.hand_web.upload']";
        public const string Personal_Signatures_SignatureAppearacne_Web_Upload_BrowseButton_CSS_Selector = "div[id='uploadSignature'] button";
        public const string Personal_Signatures_SignatureAppearacne_Web_Upload_CropDoneButton_XPath = "/html/body/div[1]/div/div/div[3]/button[1]";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_DrawCheckbox_CSS_Selector = "label[for='signature.hand_mobile.draw']";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_TextCheckbox_CSS_Selector = "label[for='signature.hand_mobile.text']";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_TextInput_CSS_Selector= "input[name='mobSigText']";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_UploadCheckbox_Id = "label[for='signature.hand_mobile.upload']";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_Upload_BrowseButton_CSS_Selector = "div[id='uploadSignature_mobile'] button";
        public const string Personal_Signatures_SignatureAppearacne_Mobile_Upload_CropDoneButton_XPath = "/html/body/div[1]/div/div/div[3]/button[1]";
        public const string Personal_Signatures_SignatureAppearacne_Initials_DrawCheckbox_CSS_Selector = "label[for='signature.initialOption.draw']";
        public const string Personal_Signatures_SignatureAppearacne_Initials_TextCheckbox_CSS_Selector = "label[for='signature.initialOption.text']";
        public const string Personal_Signatures_SignatureAppearacne_Initials_TextInput_CSS_Selector = "input[name='initlSigText']";
        public const string Personal_Signatures_SignatureAppearacne_Initials_UploadCheckbox_CSS_Selector = "label[for='signature.initialOption.upload']";
        public const string Personal_Signatures_SignatureAppearacne_Initials_Upload_BrowseButton_CSS_Selector = "div[id='uploadSignature_Initial'] button";
        public const string Personal_Signatures_SignatureAppearacne_Initials_Upload_CropDoneButton_XPath = "/html/body/div[1]/div/div/div[3]/button[1]";
        public const string Personal_Signatures_SignatureAppearacne_DropDown_ClassName = ".dropdown.form-group";
        public const string Personal_Signatures_SaveButton_XPath = ".btn-bottom btn-primary";
        public const string Personal_Signatures_Select_Appearace_CSS_Selector = "ul.dropdown-menu > li:nth-child(3) a";
        public const string Personal_Signatures_Select_Appearace1_CSS_Selector = "ul.dropdown-menu > li:nth-child(1) a";
        public const string Personal_Signatures_Select_Appearace2_CSS_Selector = "ul.dropdown-menu > li:nth-child(2) a";
        public const string Personal_Web_Signatures_Upload_Image_Css_Selector = "#handSignature_WEB #uploadSignature [type=file]";
        public const string Personal_Mobile_Web_Signatures_Upload_Image_Css_Selector = "#handSignature_mobile #uploadSignature_mobile [type=file]";
        public const string Personal_Initial_Signatures_Upload_Image_Css_Selector = "#initialSignature #uploadSignature_Initial [type=file]";

        // Signing Detail     
        public const string Personal_Signing_Appearance_Tab_CssSelector = ".nav-tabs li:nth-child(1) a";
        public const string Personal_SigningDetailsTab_CssSelector = ".nav-tabs li:nth-child(2) a";
        public const string Personal_Web_ClientSideCheckbox_CSS_Selector = "label[for='local']";
        public const string Personal_Web_ServerSideCheckbox_CSS_Selector = "label[for='server']";
        public const string Personal_Web_SigningCapacityDropDown_CssSelector = ".ui-select-match .btn-default";
        public const string Personal_Web_SelectSigningCapacity_CSS_Selector = ".ui-select-choices .ui-select-choices-row";
        public const string Personal_Mobile_ClientSideCheckbox_Id = "signature.mobileKey.local";
        public const string Personal_Mobile_ServerSideCheckbox_Id = "label[for='signature.mobileKey.server']";
        public const string Personal_Mobile_SigningCapacityDropDown_CssSelector = ".ui-select-match .btn-default";
        public const string Personal_Mobile_SelectSigningCapacity_CSSSelector = ".ui-select-choices .ui-select-choices-row";
        public const string Personal_AdditionalInformation_PreDefinedDropDown_CssSelector = ".ui-select-match .btn-default";       
        public const string Personal_AdditionalInformation_Location_XPath = "//*[@ng-model='signature.location']";
        public const string Personal_AdditionalInformation_ContactInformation_XPath = "//*[@ng-model='signature.contactInfo']";
        public const string Personal_SigningDetail_SaveButton_XPath = ".btn-bottom btn-primary";
        public const string Personal_SigningDetail_Signcapacity_dropdown_CSSSelector = "div[ng-if='signature.mobileKey'] .ui-select-match .btn-default";
        public const string Signing_Field_Assign_DropDown_CssSelector = ".ui-select-match .btn-default";
        public const string Select_Signer_CSS_Selector = ".ui-select-choices .ui-select-choices-row";

        /// <summary>
        /// Element paths for Contacts and Groups
        /// </summary>
        public const string GroupName_TextField_CssSelector = "[name=uName]";
        public const string GroupDescription_TextField_XPath = "/html/body/div[1]/div/div/form/div[2]/div[2]/input";
        public const string Remove_Group_Member_Button_CssSelector = ".icon.icon-cross";       
        public const string Add_Group_Member_TextField_CssSelector = "[id=typeaHead]";
        public const string Add_Group_Memeber_Button_XPath = "/html/body/div[1]/div/div/form/div[2]/div[3]/auto-add-contact/div/div/div[2]/button";
        public const string Edit_ContactName_TextField_CssSelector = "[name=uName]";
        public const string Edit_ContactEmail_TextField_CssSelector = "[name=userEmail]";
        public const string Add_Bulk_Contacts_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string General_Statistic_tab_CSSSelector = ".nav-tabs li:nth-child(3) a";


        /// <summary>
        /// Element paths for Templates
        /// </summary>
        public const string Templates_Uploadicon_ClassName = "fileinput-button";
        public const string Upload_Icon_By_CssSelector = ".fileinput-button input";
        public const string Templates_AddRecipient_XPath = "/ html/body/div[1]/div/div/div/div[2]/div/div/form/div/div[2]/div/div[2]/div[1]/div[1]/div/input";
        public const string Templates_SelectRecipient_XPath = "/ html / body / ul[3] / li[1] / a";
        public const string Templates_NextButton_CssSelector = ".btn-success";
        public const string Templates_DoneButton_XPath = "//button[text()='DONE']";
        public const string Templates_SaveButton_XPath = "/html/body/div[1]/div/div/form/div[3]/button[1]";
        public const string Templates_EsignField_CssSelector = "[type=esign]";

        ///<summary>
        /// Element Paths for Library
        /// </summary>
        // Add Document      
        public const string Library_ApplyTemplateDropDown_ClassName = "dropdown";
        public const string Library_Select_Template_CSSSelector = ".ui-select-choices-group .ui-select-choices-row";       
        public const string Library_Upload_and_Done_Button_CssSelector = ".btn-primary";

        //Search Enterprise Documents from Personal Library      
        public const string Library_Dropdown_XPath = "//*[@id='contactDrop']";
        public const string Personal_Enterprise_SelectDropdown_CssSelector = ".dropdown-menu li:nth-child(2) a";      

        // Library - Edit Document         
        public const string Library_DocumentNameField_Name = "lName";    

        // Library - Search Personal Document       
        public const string Library_SelectPersonalDropdown_XPath = "/html/body/div/div/div/div/div/div[2]/div/div/div[2]/div[1]/div/div[1]/div/ul/li[1]/a";

        /// <summary>
        /// Element Paths for Notifictaion
        /// </summary>   
        public const string Notification_Email_Password_Change_CheckBox_ID = "emailMeOnChangePassword";
        public const string Notification_OnScreen_Payment_Received_CheckBox_ID = "notifyMeOnOnlinePayment";
        public const string Notification_Push_Workflow_Complete_CheckBox_ID = "pushNotifyDocumentComplete";
        public const string Notifications_Email_Content_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string Notifications_Email_Content_Subject_Name = "subject";
        public const string Notifications_Save_Button_ID = "btn-save-notifications";
        public const string Notifications_Reset_Default_Button_ID = "btn-reset-email-settings";
        public const string Notifications_Email_Content_Save_Button_ID = "btn-save-email-settings";
        public const string Notifications_Confirm_Yes_Button_CSSSelector = "[ng-click='onSave()']";
        public const string Notifications_Email_Type_Dropdown_CSSSelector = ".caret";
        public const string Notifications_Email_Type_Dropdown_Value_ID = "WORKFLOW_COMPLETED";

        /// <summary>
        /// Element Paths for Cloud Drives
        /// </summary> 
        public const string Enable_Dropbox_XPath = "//*[@ng-model='authCloudDrive.enableDropBox']/span[text() = 'Enable']";
        public const string Disable_Dropbox_XPath = "//*[@ng-model='authCloudDrive.enableDropBox']/span[text() = 'Disable']";
        public const string Dropbox_Email_XPath = "//div[@class='login-email text-input login-text-input standard']";
        public const string Dropbox_Password_XPath = "//div[@class='text-input login-password login-text-input standard']";
        public const string Dropbox_Login_CssSelector = "button.login-button.signin-button.button-primary";

        public const string Enable_GoogleDrive_XPath = "//*[@ng-model='authCloudDrive.enableGoogleDrive']/span[text() = 'Enable']";
        public const string Disable_GoogleDrive_XPath = "//*[@ng-model='authCloudDrive.enableGoogleDrive']/span[text() = 'Disable']";
        public const string GoogleDrive_Email_Id = "identifierId";
        public const string GoogleDrive_Advanced_Linktext = "Advanced";
        public const string GoogleDrive_MoreAdvanced_LinkText = "Go to signinghub.com (unsafe)";
        public const string GoogleDrive_Submit_Id = "submit_approve_access";

        public const string Enable_OneDrive_XPath = "//*[@ng-model='authCloudDrive.enableOneDrive']/span[text() = 'Enable']";
        public const string Disable_OneDrive_XPath = "//*[@ng-model='authCloudDrive.enableOneDrive']/span[text() = 'Disable']";
        public const string OneDrive_Email_Id = "i0116";
        public const string OneDrive_NextButton_Id = "idSIButton9";
        public const string OneDrive_Password_Id = "i0118";

        /// <summary>
        /// Element Paths for Legal Notices
        /// </summary>      
        public const string LegalNotice_NameField_Name = "title";
        public const string LegalNotice_ContentFie_CssSelector = ".mce-edit-area iframe";
        public const string LegalNotice_SaveButton_CssSelector = ".modal-footer .btn-primary";

        /// Element Paths for Delegate Signing
        /// </summary>       
        public const string Enable_Checkbox_CssSelector = "[for=enableDelegate]";
        public const string Delegate_Checkbox_Id = "enableDelegate";
        public const string CrossIcon_CssSelector = ".input-group-btn .btn-close";
        public const string DelegateSigningTo_Field_XPath = "//*[@id='typeaHead']";
        public const string From_DatePicker_XPath = "/html/body/div[1]/div/div/div/div/div[2]/div/div/div[2]/form/div[1]/div/div/div[2]/div[3]/div/div/button";
        public const string Today_FromDatePicker_XPath = "/html/body/div[2]/div[3]/table/tfoot/tr/th";
        public const string To_DatePicker_XPath = "/html/body/div[1]/div/div/div/div/div[2]/div/div/div[2]/form/div[1]/div/div/div[2]/div[4]/div/div/button";
        public const string Today_ToDatePicker_XPath = "/html/body/div[3]/div[3]/table/tfoot/tr/th";
        public const string DelegateSigning_SaveButton_CssSelector = ".btn-bottom .btn-primary";
        public const string Today_DatePicker_ClassName = "today";
        public const string First_DateTimePicker_CssSelector = ".datetimepicker";
        public const string Second_DateTimePicker_CssSelector = ".datetimepicker~.datetimepicker";
        public const string Third_DateTimePicker_CssSelector = ".datetimepicker ~ .datetimepicker ~ .datetimepicker";
        public const string Fourth_DateTimePicker_CssSelector = ".datetimepicker ~ .datetimepicker ~ .datetimepicker ~ .datetimepicker";
        public const string Fourth_Today_DateTimePicker_CssSelector = ".datetimepicker ~ .datetimepicker ~ .datetimepicker ~ .datetimepicker";
        public const string Third_Today_DatePicker_CssSelector = ".datetimepicker ~ .datetimepicker ~ .datetimepicker .today";

        /// <summary>
        /// Element Paths for Documents - Individual User
        /// </summary>    
        public const string Documents_SelectCheckbox_XPath = "/html/body/div/div/div/div/div/div[2]/div/div/div[2]/div/div[3]/label";
        public const string Documents_SaveButton_CssSelector = ".btn";
        #endregion

        #region Document listing Folder
        public const string FolderName_TextField_CssSelector = "[name=folderName]";
        public const string Folder_CssSelector = ".folder-list";
        public const string Folder_Options_XPath = "//ul[contains(@class, 'folder-list')]/li[last()]/div[contains(@class, 'dropdown')]";
        public const string Folder_Name_Update_XPath = "(html/body/ul)[last()]/li[1]";
        public const string Folder_Delete_XPath = "(html/body/ul)[last()]/li[2]";
        public const string Add_Folder_Icon_CssSelector = ".icon.icon-plus-circle";
        #endregion

        #region Document listing filters/Sorting        
        public const string Filter_All_IdSelector = "listing-filter-all";        
        public const string Filter_Draft_IdSelector = "listing-filter-draft";        
        public const string Filter_Inprogress_IdSelector = "listing-filter-inprogress";               
        public const string Filter_Decined_IdSelector = "listing-filter-declined";
        public const string Filter_Pending_IdSelector = "listing-filter-pending";
        public const string Document_Listing_Open_Document_XPath = "//div[contains(@class, 'listing')]/div/div/div[3]";
        public const string Document_Listing_Select_Document1_XPath = "//div[contains(@class, 'listing')]/div[1]/div/div[1]/div/div[@class= 'checkbox']";
        public const string Document_Listing_Select_Document2_XPath = "//div[contains(@class, 'listing')]/div[2]/div/div[1]/div/div[@class= 'checkbox']";
        public const string Viewer_Back_Button_XPath = "//div[@class = 'custom-container']/span[contains(@class, 'icon-arrow-left')]";
        public const string New_Workflow_Back_Arrow_XPath = "//div[@class = 'custom-container']/span[contains(@class, 'arrow-left')]";
        public const string Document_Listing_Sort_Order_CssSelector = ".dropdown.sort";
        public const string Document_Listing_Order_By_Date_XPath = "//ul[contains(@class, 'sort-menu')]/li[1]";
        public const string Document_Listing_Order_By_Name_XPath = "//ul[contains(@class, 'sort-menu')]/li[2]";

        #endregion

        #region Document listing search
        public const string Submit_Search_CssSelector = ".tab-pane.active [type=submit]";
        public const string Clear_Search_CssSelector = "[type=button].btn.btn-default.btn-close";
        public const string Advance_Search_Button_CssSelector = "[type=button].btn.btn-default.btn-search";
        public const string Advance_Search_DocumentName_IDSelector = "advanceSearch.documentName";
        public const string Advance_Search_Owner_IDSelector = "advanceSearch.owner";
        public const string Advance_Search_ToName_IDSelector = "advanceSearch.workflowSigner";
        public const string Advance_Search_DocumentId_IDSelector = "advanceSearch.documentId";
        public const string Advance_Search_PackageId_IDSelector = "advanceSearch.documentPackageId";
        public const string Advance_Search_Document_Status_XPath = "//div[@ng-model='advanceSearch.selectedDocumentStatus']";
        public const string Advance_Search_Signed_Document_Status_XPath = "//ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/div[3]";
        public const string Advance_Search_Inprogress_Document_Status_XPath = "//ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/div[5]";
        public const string Advance_Search_Folder_XPath = "//div[@ng-model='advanceSearch.selectedFolderStatus']";
        public const string Advance_Search_Inbox_Folder_XPath = "//ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/div[4]";
        public const string Advance_Search_Document_Type_XPath = "//div[@ng-model='advanceSearch.selectedDocumentType']";
        public const string Advance_Search_PDF_Document_Type_XPath = "//ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/div[4]";
        public const string Advance_Search_Source_IDSelector = "advanceSearch.source";
        public const string Advance_Search_From_Size_XPath = "//div[@id='size']/div[1]/input";
        public const string Advance_Search_To_Size_XPath = "//div[@id='size']/div[2]/input";
        public const string Advance_Search_From_Date_XPath = "//div[@id= 'modifiedDate']/div[1]/div[3]";
        public const string Advance_Search_Select_From_Date_XPath = "//div[@class= 'datetimepicker-days']/table/tbody/tr[1]/td[1]";
        public const string Advance_Search_To_Date_XPath = "//div[@id= 'modifiedDate']/div[last()]/div[last()]";
        public const string Advance_Search_Select_To_Date_XPath = "//html/body/div[contains(@class, 'datetimepicker')][last()]/div[@class= 'datetimepicker-days']/table/tfoot";
        public const string Advance_Search_Certified_Checkbox_XPath = "//label[@for ='advanceSearch.hasCertifiedSignature']";
        public const string Advance_Search_Documents_Fields_Checkbox_XPath = "//label[@for ='advanceSearch.hasFormField']";
        public const string Advance_Search_Button = "[type=submit].btn.btn-primary.ladda-button";
        public const string Document_listing_Clear_Search = "//li[@class ='clear-search']";
        public const string Select_First_Document_CssSelector = "#home-dcument-list div:nth-child(1) .checkbox";
        public const string More_Action_CssSelector = ".icons-list .dropdown .icon-more-vert";
        public const string More_Action_EvidenceReport_CssSelector = ".icon-evidencereport";
        public const string Document_Listing_Search_CssSelector = "[type=search]";
        public const string Document_Listing_Submit_Search_CssSelector = "[type=submit]";
        public const string Submit_Dialog_Box_CssSelector = ".modal-footer .btn-primary";
        #endregion

        #region Document listing More Options
        public const string Document_listing_Select_First_Document_XPath = "//div[contains(@class, 'listing')]/div[1]";
        public const string Document_listing_Select_Second_Document_XPath = "//div[contains(@class, 'listing')]/div[2]";
        public const string Document_listing_Preview_Document_CSS_Selector = ".icon-info";
        public const string Document_listing_Bulk_CSS_Selector = ".icon-sign";
        public const string Document_listing_Preview_Document_Close_XPath = "//span[contains(@class, 'modal-close')]";
        public const string Document_listing_Download_Document_CSS_Selector = ".icon-download";
        public const string Document_listing_Delete_Document_CSS_Selector = ".icon-trash";
        public const string Document_listing_Send_Reminder_CSS_Selector = ".icon-remind";
        public const string Document_listing_More_Options_XPath = "//ul[contains(@class, 'icons-list')]/li[contains(@class, 'dropdown')]/span";
        public const string Document_listing_Rename_Document_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.rename']";
        public const string Document_Rename_Document_Field_CssSelector = "[type=text]";
        public const string Document_listing_Comment_On_Document_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.comment']";
        public const string Document_Comment_TextArea_Field_XPath = "//textarea[@name= 'txtcomment']";
        public const string Document_Comment_Model_Close_XPath = "//span[contains(@class, 'modal-close')]";
        public const string Document_listing_Print_Document_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.print']";
        public const string Document_listing_Start_New_WorkFlow_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.startNewWorkflow']";
        public const string Document_listing_WorkFlow_History_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.documentLog']";
        public const string Document_listing_Workflow_Evidence_Report_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.evidenceReport']";
        public const string Document_listing_WorkFlow_History_Search_CSSSelector = "[type=search]";
        public const string Model_Close_XPath = "//span[contains(@class, 'modal-close')]";
        public const string WorkFlow_History_Search_Button_CSSSelector = "[type=button].btn.btn-default.btn-submit";
        public const string Document_listing_Move_To_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.move']";
        public const string Document_Move_To_Folder_XPath = "//label[@for ='targetFolderId_1']";
        public const string Document_Move_To_Button_XPath = "[type=button].btn.btn-primary";
        public const string Document_listing_Recall_Document_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.recall']";
        public const string Document_listing_Bulk_Share_XPath = "//ul[@class = 'dropdown-menu']/li[@ng-if = 'document.allowedOperations.share']";
        public const string Document_listing_Select_All_Documents_Id = "document.allSelect";
        public const string Document_listing_Bulk_Sign_Next_Button_Css_Selector = "[type=button].btn.btn-primary";

        #endregion

        #region Share document

        public const string New_Workflow_NextButton_CssSelector = ".btn-success";
        public const string Model_Close_CSSSelector = ".modal-close";
        public const string Bulk_Share_Apply_Template_CSSSelector = ".grid-body > div:nth-child(1) > div > div:nth-child(3) span";
        public const string Template_Search_CSS_Selector = "[type=text]";
        public const string Select_Searched_Template = "//div[contains(text(),'" + TestData.Template_Name_Text + "')]";
        #endregion

        #region Pending Wokflow
        public const string Workflow_Pending_ESign_CSSSelector = "#signatureField div.signaturefield:nth-child(1)";
        public const string Workflow_Initial_CSSSelector = "#initials div:nth-child(1)";
        public const string Workflow_Pending_InPerosn_CSSSelector = "#inperson div.signaturefield:nth-child(1)";
        public const string Viewer_More_Options_IdSelector = "dropdownMenu1";
        public const string Viewer_Decline_Option_CSSSelector = ".more-actions-dropdown .dropdown-menu li:nth-child(5)";
        public const string Viewer_Finish_Button_CSSSelector = ".custom-container .btn-holder .btn.btn-success";
        public const string Workflow_Pending_HandSignature_CSSSelector = "#handSignature div:nth-child(1)";
        #endregion

        #region Viewer Add, Edit Remove fields
        public const string Viewer_DocumentViewer_ClassName = "document-area";

        public const string DocumentListing_Prepare_XPath = "//span[text()='PREPARE']";
        public const string Viewer_SignatureField_ESign_CSSSelector = "[type=esign]";
        public const string Viewer_SignatureField_Digital_CSSSelector = "[type=digital]";
        public const string Viewer_SignatureField_InPerson_CSSSelector = "[type=inperson]";
        public const string Viewer_Name_Field_CSSSelector = "[type=name]";
        public const string Viewer_Email_Field_CSSSelector = "[type=email]";
        public const string Viewer_Radio_Field_CSSSelector = "[type=redio]";
        public const string Viewer_CheckBox_Field_CSSSelector = "[type=checkBox]";

        #endregion

        #region Enterprise Settings Elements Path

        #region Elements paths for Enterprise Roles
        
        public const string Enterprise_Add_Role_CSSSelector = ".icon.plus-circle";
        public const string Enterprise_Role_Name_CSSSelector = "[name=uName]";
        public const string Enterprise_Role_Description_XPath = "html/body/div[1]/div/div/form/div[2]/div[2]/input";
        public const string Enterprise_Role_DefaultCheckBox_ID = "default";
        public const string Enterprise_Role_SubmitButton_CSSSelector = "[type=submit]";

        public const string Enterprise_Search_Role_TextField_CSSSelector = "[type=search]";        
        public const string Enterprise_Role_Name_Field_Value_ByName = "role";
        public const string Enterprise_Role_Default_Checkbox_Id = "default";

        public const string Enterprise_Roles_ServerSideSigning_CheckBox_ID = "signature.digitalWeb.isServer";
        public const string Enterprise_Roles_Save_Button_CSSSelector = "[type=submit].btn-primary";
        public const string Enterprise_Roles_Success_Message_ClassName = "toast-message";

        public const string Enterprise_Roles_Delete_Confirmation_Button_ClassName = "ladda-label";

        public const string Enterprise_Roles_SignatureAppearance_Draw_CheckBox_ID = "appearance.handWeb.isDraw";
        public const string Enterprise_Roles_UserSettings_Library_CheckBox_ID = "advance.library";
        public const string Enterprise_Roles_EnterpriseSettings_Templates_CheckBox_ID = "enterprise.manageTemplates";
        public const string Enterprise_Roles_LoginAuthentication_AllowPublicAuth_CheckBox_ID = "enterprise.isPublicProfileAllowed";

        public const string Enterprise_Roles_SignatureAppearance_Tab_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string Enterprise_Roles_UserSettings_Tab_CSSSelector = ".nav-tabs li:nth-child(3) a";
        public const string Enterprise_Roles_EnterpriseSettings_Tab_CSSSelector = ".nav-tabs li:nth-child(4) a";
        public const string Enterprise_Roles_LoginAuthentication_Tab_CSSSelector = ".nav-tabs li:nth-child(5) a";

        public const string Enterprise_Roles_Web_Text_Signature_CSSSelector = "appearance.handWeb.isText";
        public const string Enterprise_Roles_Initial_Text_Signature_CSSSelector = "appearance.initial.isText";        

        #endregion Elements paths for Enterprise Roles

        #region Element Paths for Enterprise Templates

        public const string Enterprise_Templates_Add_Template_ClassName = "icon-plus-circle";
        public const string Enterprise_Templates_Upload_Document_ClassName = "fileinput-button";
        public const string Enterprise_Templates_Selection_CheckBox_CSSSelector = "[type=checkbox]";
        //public const string Enterprise_Templates_Add_Recipient_Email_XPath = "/html/body/div[1]/div/div/div/div[2]/div/div/form/div/div[2]/div/div[2]/div[1]/div[1]/div/input";
        public const string Enterprise_Templates_Select_Recipient_XPath = "/ html / body / ul[3] / li[1] / a";
        public const string Enterprise_Templates_Next_Button_CSSSelector = "[type=button]";
        public const string Enterprise_Templates_SignatureField_CSSSelector = "[type=esign]";
        public const string Enterprise_Templates_DocumentViewer_ClassName = "document-area";
        public const string Enterprise_Templates_NameField_Name = "rename";
        public const string Enterprise_Templates_Delete_CheckBox_ClassName = "checkbox";
        public const string Enterprise_Templates_Done_Button_CSSSelector = "[type=button]";
        public const string Enterprise_Template_Save_Button_CSSSelector = "[type=submit]";



        #endregion Element Paths for Enterprise Templates

        #region Element Paths for Integration

        
        public const string Enterprise_Integration_ClientID_Name = "applicationeName";
        public const string Enterprise_Integration_CallBackURL_Name = "url";
        public const string Enterprise_Integration_ClientSecret_Button_CSSSelector = "[type=submit].btn-default";
        public const string Enterprise_Integration_Save_Button_CSSSelector = "[type=submit].btn-primary";
        public const string Enterprise_Integration_Selection_CheckBox_CSSSelector = "[ng-model='item.remove']";
        public const string Enterprise_Integration_WorkflowCompletion_Tab_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string Enterprise_Integration_WorkflowCompletion_CheckBox_ID = "publishHistory";
        public const string Enterprise_Integration_WorkflowCompletion_URL_CSSSelector = "[type=url]";
        public const string Enterprise_Integration_WorkflowCompletion_TestURL_Button_CSSSelector = "[name=url] + .input-group-btn .btn";
        public const string Enterprise_Integration_WorkflowCompletion_AddDocument_CheckBox_ID = "include";
        public const string Enterprise_Integration_Next_Tab_Css_Selecter = ".modal-body .nav.nav-tabs li:nth-child(2)";
        public const string Enterprise_Integration_Allowed_Domains_Name_Selecter = "allowedDomains";
        public const string Enterprise_Integration_Is_Hidden_Id_Selecter = "isHidden";
        public const string Enterprise_Integration_Collapse_Id_Selecter = "collapseViewerPanels";
        public const string Enterprise_Integration_App_Edit_CssSelecter = ".pull-right.icon.edit-key";

        #endregion

        #region Element Paths for Branding

        public const string Enterprise_Branding_CompanyLogo_Browse_Button_ID = "btn-upload-branding-logo";
        public const string Enterprise_Branding_Favicon_Browse_Button_ID = "btn-upload-branding-favicon";
        public const string Enterprise_Branding_Save_Button_CSSSelector = "[type=submit].btn-primary";
        public const string Enterprise_Branding_ResetDefault_Button_ID = "btn-reset-branding";
        public const string Enterprise_Branding_Colours_Tab_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string Enterprise_Branding_CompanyLogo_Upload_CSSSelector = ".tab-pane.active .scroll-auto div:nth-child(1) .panel-body [type=file]";
        public const string Enterprise_Branding_Favicon_Upload_CSSSelector = ".tab-pane.active .scroll-auto div:nth-child(2) .panel-body [type=file]";

        #endregion

        #region Element Paths for Enterprise Advanced Settings

        public const string Enterprise_Advanced_StoragePolicy_CheckBox_CSSSelector = "[type=checkbox]";
        public const string Enterprise_Advanced_LegalNotice_Tab_CSSSelector = ".nav-tabs li:nth-child(2) a";
        public const string Enterprise_Advanced_LegalNotice_Name_CSSSelector = "[type=text].form-control";
        public const string Enterprise_Advanced_LegalNotice_Content_ID = "uiTinymce0_ifr";
        public const string Enterprise_Advanced_CertificateFilters_Tab_CSSSelector = ".nav-tabs li:nth-child(3) a";
        public const string Enterprise_Advanced_CertificateFilters_FilterValue_Name = "value";
        public const string Enterprise_Advanced_Selection_CheckBox_CSSSelector = "[ng-model='item.remove']";
        public const string Enterprise_Advanced_PasswordPolicy_Tab_CSSSelector = ".nav-tabs li:nth-child(4) a";
        public const string Enterprise_Advanced_Remove_Enterprise_Tab_CSSSelector = ".nav-tabs li:nth-child(4)";
        public const string Enterprise_Advanced_PasswordPolicy_MinLength_CSSSelector = "[type=number]";
        public const string Enterprise_Advanced_PasswordPolicy_UpperCase_CheckBox_ID = "ContainULCase";
        public const string Enterprise_Advanced_Others_Tab_CSSSelector = ".nav-tabs li:nth-child(5) a";
        public const string Enterprise_Advanced_Others_CheckBox_CSSSelector = "[type=checkbox]";
        public const string Enterprise_Advanced_Others_URL_Name = "loginPageUrl";
        public const string Enterprise_Advanced_Others_XML_URL_Name = "documentProcessingUrl";
        public const string Enterprise_Advanced_Others_XML_URL_Test_Id = "btn-test-url-documentProcessing";
        public const string Enterprise_Advanced_StoragePolicy_Save_Button_ID = "btn-save-default-settings";
        public const string Enterprise_Advanced_PasswordPolicy_Save_Button_ID = "btn-save-password-policy";
        public const string Enterprise_Advanced_Others_Save_Button_ID = "btn-save-advanced-others";
        public const string Enterprise_Advanced_LegalNotice_Save_CSSSelector = "[type=submit].btn-primary";
        public const string Enterprise_Advanced_Others_Test_URL_ID = "btn-test-url-documentProcessing";
        public const string Enterprise_Advanced_CertificateFilters_SAN_Css_Selector = "//ul[contains(@class, 'dropdown-menu')]/li[contains(@class, 'ui-select-choices-group')]/div[8]";
        public const string Enterprise_Advanced_CertificateFilters_Dropdown_Css_Selector = "dropdown";
        public const string Enterprise_Advanced_Allow_Print_By_Id = "allow-print";
        public const string Enterprise_Advanced_Allow_Add_Text_By_Id = "allow-commenting";
        public const string Enterprise_Advanced_Password_Policy_Number_By_Id = "contain-one-number";
        public const string Enterprise_Advanced_Document_Revision_By_Id = "save-revision";
        public const string Bar_Chart_Dropdown_Css_Selector = ".bar-chart .dropdown button";
        public const string General_Dropdown_Second_Value_CSSSelector = ".dropdown-menu li:nth-child(2) a";
        public const string Enterprise_Chart_Button_CSS_Selector = ".btn.btn-primary";        
        public const string Line_Chart_Dropdown_Css_Selector = ".line-chart .dropdown .dropdown-toggle";
        
        #endregion




















































































        /// <summary>
        /// Workflow Element Paths
        /// </summary>
        #region
        ///<summary>
        /// Element Path for Templates
        /// </summary>

        public const string Workflow_Library_Upload_CSSSelector = ".icon-online-library";
        public const string Workflow_Library_DropDown_CSSSelector = ".custom-dropdown .caret-override";
        public const string Workflow_Library_DropDown_Value_CSSSelector = ".dropdown-menu li:nth-child(1)";
        public const string Workflow_Library_Search_CSSSelector = ".form-control";
        public const string Workflow_Library_ALL_CheckBox_ID = "library.isAllSelect";
        public const string Workflow_Library_Done_Button_CSSSelector = ".modal-footer .btn-primary";
        public const string Workflow_NEXT_Button_CSSSelector = ".custom-container .btn-success";        
        public const string Workflow_Only_Me_Field_Name = "Text1";
        public const string Workflow_Only_Me_Initial_CSSSelector = "#initialField div:nth-child(1)";        
        public const string Workflow_Option_Text_CSSSelector = ".signing-modal .nav-tabs .icon-keyboard-o";
        public const string Workflow_Option_Draw_CSSSelector = ".signing-modal .nav-tabs .icon-sign";
        public const string Workflow_Option_Upload_CSSSelector = ".signing-modal .nav-tabs .icon-upload";
        public const string Workflow_Only_Me_Initial_Signer_Name = "signerName";
        public const string General_Modal_Success_Button_CSSSelector = ".modal-footer .btn-success";
        public const string Workflow_Only_Me_InPerosn_CSSSelector = "#inpersonField div.signaturefield:nth-child(1)";
        public const string Workflow_Only_Me_HandSignature_CSSSelector = "#handSignatureField div:nth-child(1)";
        public const string Workflow_Only_Me_Draw_Canvas_ID = "handDrawCanvas";
        public const string Workflow_Only_Me_Draw_Canvas_Area_ID = "drawHere";
        public const string Workflow_Only_Me_DSign_CSSSelector = "#signatureField div.signaturefield:nth-child(1)";
        public const string Workflow_Template_Selection_CSSSelector = ".icon-add-template";
        public const string Workflow_Template_DropDown_CSSSelector = ".custom-dropdown .pull-right";
        public const string Workflow_Template_Select_Radio_Name = "radioButton";        
        public const string Workflow_Upload_Button_CSSSelector = ".active .btn-default";
        public const string Image_Upload_Sign_Button_CSSSelector = ".active .moxie-shim input";
        public const string Workflow_Draw_Sign_CSSSelector = "#draw-canvas-area #canvas-area";
        public const string Password_Field_On_Sign_CSSSelector = "userPassword";
        public const string Upload_Image_On_Sign_CSSSelector = ".tab-pane.active [type=file]";



        /// <summary>
        /// Elements Path for workflows
        /// </summary>
        public const string Workflow_Add_Recipient_Icon_CSSSelector = ".icon-add-recipient";
        public const string Workflow_Recipient_Search_CSSSelector = ".form-control";
        public const string Workflow_Logged_In_Recipient_Select_CSSSelector = ".form-control + .contact-tooltip";
        public const string Workflow_DSign_Signature_Field_CSSSelector = "[type=digital]";
        public const string Workflow_ESign_Signature_Field_CSSSelector = "[type=esign]";
        public const string Workflow_Inperson_Signature_Field_CSSSelector = "[type=inperson]";
        public const string Workflow_Initial_Signature_Field_CSSSelector = "[type=initial]";
        public const string Workflow_Name_Field_CSSSelector = "[type=name]";
        public const string Workflow_Email_Field_CSSSelector = "[type=email]";
        public const string Workflow_JobTitle_Field_CSSSelector = "[type=jobTitle]";
        public const string Workflow_Company_Field_CSSSelector = "[type=company]";
        public const string Workflow_Date_Field_CSSSelector = "[type=date]";
        public const string Workflow_Text_Field_CSSSelector = "[type=text]";
        public const string Workflow_Radio_Button_CSSSelector = "[type=radio]";
        public const string Workflow_CheckBox_CSSSelector = "[type=checkBox]";
        public const string Workflow_On_Page_Comments_CSSSelector = "[type=onPageComment]";
        public const string Workflow_Sign_Password_CssSelector = "[type=password]";
        public const string Workflow_Role_Reviewer_CssSelector = ".custom-dropdown-menu .review";
        public const string Workflow_Role_Editor_CssSelector = ".custom-dropdown-menu .icon-edited";
        public const string Workflow_Role_MeetingHost_CssSelector = ".custom-dropdown-menu .icon-host-signers";
        public const string Workflow_Role_SendAcopy_CssSelector = ".custom-dropdown-menu .icon-send-a-copy";
        public const string Workflow_Role_Signer_CssSelector = ".custom-dropdown-menu .icon-pending";
        public const string Workflow_Single_Signer_CssSelector = ".drop-column .btn-default";
        public const string Workflow_Remarks_TextArea_CssSelector = ".form-control";
        
        #endregion

        #region Element paths for Enterprise Profile
        public const string Enterprise_ProfileName_Name = "enterpriseName";
        public const string Enterprise_Profile_Button_CssSelector = "button.btn";
        #endregion

        #region Enterprise User
        public const string Register_User_Name = "uName";
        public const string Register_User_Email = "uEmail";
        public const string Register_User_Role = ".ui-select-match";
        public const string Register_User_EnterpriseUser = ".ui-select-choices-row-inner";
        public const string ClickCheck_User_Enterprise_Css = ".ng-pristine";
        public const string Edit_Enterprise_User_CssSelector = ".tab-pane.active .edit";
        public const string Edit_Enterprise_User_Role_CssSelector = ".caret pull-right";
        public const string Select_EnterpriseAdmin_Role_CssSelector = ".ui-select-choices-row-inner";
        public const string Enterprise_User_Activation_Email_Checkbox_ID = "chActivationEmail";
        public const string Enterprise_User_Terms_Condition_Checkbox_CSS_Selecter = ".scroll-auto div:nth-child(1) div:nth-child(8) input";
        public const string Enterprise_Bulk_Users_Terms_Condition_Checkbox_CSS_Selecter = "chkAgreeTermsAndConditons";
        #endregion

        #endregion  Enterprise Settings Elements Path

        #region Upload region         
        public const string New_Workflow_Upload_Library_Document_ClassName = ".icon-online-library";
        public const string New_Workflow_Upload_Library_Search_CSS_Selector = "[type=text]";
        public const string New_Workflow_Upload_Library_Search_Searched_Document = "//div[contains(text(),'" + TestData.Sample_Upload_Third_Party_Document_Name + "')]";
        public const string New_Workflow_Document_Merge_Class = ".icon-merge-document";      

        //Google drive
        public const string New_Workflow_Upload_Google_Drive_Icon_CSS_Selector = ".fileinput-button.google-drive";
        public const string New_Workflow_Upload_Google_Drive_Button_Next_Click_Id = "identifierNext";
        public const string General_Type_PasswordCss_Selector = "[type=password]";
        public const string New_Workflow_Upload_Google_Drive_Button_Password_Next_Click_Id = "passwordNext";
        public const string New_Workflow_Upload_Google_Drive_Doc_Frame_Search_XPath = "//input[@type='text']";
        public const string New_Workflow_Upload_Google_Drive_Doc_Frame_Searched_Element_CSS_Selector = ".An-mc-lp div:nth-child(2)";
        public const string New_Workflow_Upload_Google_Drive_Doc_Frame_Searched_Element__Click_CSS_Selector = "arguments[0].click();";

        //DropBox
        public const string New_Workflow_Upload_Dropbox_Auth_Dialog_Email_CSS_Selector = ".credentials-form__fields .login-email";
        public const string New_Workflow_Upload_Dropbox_Auth_Dialog_Password_CSS_Selector = ".credentials-form__fields .login-password";
        public const string New_Workflow_Upload_Dropbox_Auth_Dialog_Login_Button_CSS_Selector = ".signin-button";
        public const string New_Workflow_Upload_Dropbox_Doc_Dialog_Seach_CSS_Selector = ".dropins-search-input";
        public const string New_Workflow_Upload_Dropbox_Doc_Dialog_Seach_Input_CSS_Selector = ".dropins-search-input";
        public const string New_Workflow_Upload_Dropbox_Doc_Dialog_Checkbox_CSS_Selector = ".mc-checkbox-input";
        public const string New_Workflow_Upload_Dropbox_Doc_Dialog_Checkbox_Click_CSS_Selector = "arguments[0].click();";
        public const string New_Workflow_Upload_Dropbox_Doc_Dialog_Upload_Click_CSS_Selector = ".mc-button-primary";
        public const string New_Workflow_Upload_Dropbox_Upload_Icon_Click_CSS_Selector = ".dropbox";
        //OneDrive
        public const string New_Workflow_Upload_OneDrive_Doc_Dialog_Select_Click_XPath = "//*[@data-selection-index = '4']";
        public const string New_Workflow_Upload_OneDrive_Doc_Dialog_Scroll_View_XPath = "arguments[0].scrollIntoView(true);";
        public const string New_Workflow_Upload_OneDrive_Doc_Dialog_Element_Click_XPath = "arguments[0].click();";
        public const string New_Workflow_Upload_OneDrive_Doc_Dialog_Chile_Element_Click_XPath = "button.od-Button:nth-child(1) > span:nth-child(1)";
        public const string New_Workflow_Upload_OneDrive_Icon_Click_CSS_Selector = ".onedrive";
        public const string New_Workflow_Upload_OneDrive_Email_Click_Id = "i0116";
        public const string New_Workflow_Upload_OneDrive_Next_Click_Id = "idSIButton9";
        public const string New_Workflow_Upload_OneDrive_Password_Click_Id = "i0118";
        public const string New_Workflow_Upload_OneDrive_Submit_Click_Id = "idSIButton9";
        public const string New_Workflow_Upload_OneDrive_Select_Document_XPath = "//*[@data-item-index = '3']/div/div/div/span";
        public const string New_Workflow_Upload_OneDrive_Open_Document_XPath = ".od-Button-label.od-ButtonBarCommand-label";


        #endregion

        #region Certify
        public const string New_Workflow_Certify_Icon_Click_CSS_Selector = ".icons-list li:nth-child(1)";
        public const string New_Workflow_Certify_Dialog_Dropdown_Click_XPath = "//div[@ng-model='certify.certifyType']";
        public const string New_Workflow_Certify_Dialog_Dropdown_Done_CSS_Selector = "[type=submit]";
        public const string New_Workflow_Certify_Dialog_Dropdown_No_Changes_Click_XPath = "//li[contains(@class, 'ui-select-choices-group')]/div[3]";
        public const string New_Workflow_Certify_Dialog_Dropdown_Form_Filling_Click_XPath = "//li[contains(@class, 'ui-select-choices-group')]/div[4]";
        public const string New_Workflow_Certify_Dialog_Lock_Document_CheckBox_Click_XPath = "//input[@ng-model='certify.unlockDocument']";
        #endregion

        #region New workflow delete document
        public const string New_Workflow_Delete_Document_Icon_Click_CSS_Selector = ".icons-list li:nth-child(3)";
        #endregion

        #region New workflow more options i.e Rename
        public const string New_Workflow_More_Option_Icon_Click_CSS_Selector = ".icon.icon-more-vert.dropdown-toggle";
        public const string New_Workflow_More_Option_Rename_Option_Click_CSS_Selector = ".pull-left.icon.icon-rename-document";
        public const string New_Workflow_More_Option_Rename_Dialog_Name_TextField_CssSelector = "[name=rename]";
        public const string New_Workflow_More_Option_Download_Option_Click_CSS_Selector = ".pull-left.icon.icon-download";
        public const string New_Workflow_More_Option_Add_To_Library_Option_Click_CSS_Selector = ".dropdown-menu.dropdown-menu-right .pull-left.icon.icon-online-library";

        //document rename
        public const string New_Workflow_Package_Name_Rename_Click_CSS_Selector = ".icon.edit";
        public const string New_Workflow_Rename_Package_Text_Click_XPath = "//input[@ng-model='documentPackageRename.name']";

        //document reoder
        public const string New_Workflow_Document_Reoder_2nd_Document_CSS_Selector = "#upload_1 .item-info";
        public const string New_Workflow_Document_Reoder_1st_Document_CSS_Selector = "#upload_0 .item-info";

        //change workflow type
        public const string New_Workflow_Change_Workflow_Type_CSS_Selector = ".btn-settings .icon.icon-settings";
        public const string New_Workflow_Change_Workflow_Type_Parallel_CSS_Selector = ".radio-area div:nth-child(2)";
        public const string New_Workflow_Change_Workflow_Type_Individual_XPath = "//div[@class= 'radio-area']/div[3]";
        public const string New_Workflow_Change_Workflow_Type_Continue_On_Decline_XPath = "//label[@for='continueOnDecline']";
        public const string New_Workflow_Continue_On_Decline_XPath = "//label[@for='continueWorkflow']";
        public const string New_Workflow_Custom_Workflow_Type_CSS_Selector = ".workflow-type-bar .btn-group label:nth-child(4)";

        //csv upload
        public const string New_Workflow_Change_CSV_Recipients_CSS_Selector = ".icon.icon-import-csv";
        public const string New_Workflow_Change_CSV_Recipients_Upload_Icon_CSS_Selector = ".fileinput-button";

        //comments
        public const string New_Workflow_Comments_Icon_CSS_Selector = ".icon.icon-message-alert";
        public const string New_Workflow_Comment_Text_Click_XPath = "//textarea[@name='txtcomment']";
        public const string New_Workflow_Close_Model_Click_CSS_Selector = ".modal-close";

        //email message
        public const string New_Workflow_Email_Message_Icon_CSS_Selector = ".icon.icon-edit-email-message";
        public const string New_Workflow_Email_Message_Text_Click_XPath = "//textarea[@name='txtMessage']";

        //post prcessing
        public const string New_Workflow_Post_Process_Icon_CSS_Selector = ".icon.icon-post-processing";
        public const string New_Workflow_Post_Process_Text_Click_XPath = "//label[@for='postProcess.showPostProcess']";

        public const string New_Workflow_Post_Process_Add_Email_CSS_Selector = ".input-group-btn";
        public const string New_Workflow_Post_Process_Email_Text_XPath = "//input[@ng-model='addContact.selectedRecord']";

        public const string New_Workflow_Post_Process_Email_Message_Text_Click_XPath = "//textarea[@ng-model='postProcess.emailMessage']";

        public const string New_Workflow_Post_Process_2nd_Tab_Click_CSS_Selector = ".nav.nav-tabs li:nth-child(2)";
        public const string New_Workflow_Post_Process_Enable_Dropbox_XPath = "//label[@ng-model='postProcess.enableDropBox']/span[text() = 'Enable']";
        public const string New_Workflow_Post_Process_Enable_Google_Drive_XPath = "//label[@ng-model='postProcess.enableGoogleDrive']/span[text() = 'Enable']";
        public const string New_Workflow_Post_Process_Enable_One_Drive_XPath = "//label[@ng-model='postProcess.enableOneDrive']/span[text() = 'Enable']";

        //Add recipient 
        public const string New_Workflow_Add_Recipient_Click_CSS_Selector = ".recipient-area div:nth-child(2) div:nth-child(1)";
        public const string New_Workflow_Add_Recipient1_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/div[2]/div/div/div/input";
        public const string New_Workflow_Add_Recipient1_Email_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/div[2]/div/div[2]/input";
        public const string New_Workflow_Add_Recipient2_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[2]/div[2]/div/div/div/input";
        public const string New_Workflow_Add_Recipient2_Email_XPath = "//div[@ng-model='global.documentPackage.signers']/div[2]/div[2]/div/div[2]/input";        
        public const string Individual_Workflow_Add_Recipient1_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/div[1]/div[1]/div/div/input";
        public const string Individual_Workflow_Add_Recipient2_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[2]/div[1]/div[1]/div/div/input";
        public const string New_Workflow_Add_Recipient2_Change_Type_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[2]/div/div/button";
        public const string New_Workflow_Add_Recipient2_Change_Type_Reviewer_CSS_Selector = ".dropdown-menu.dropdown-menu-right.custom-dropdown-menu.show-up li:nth-child(2)";
        public const string New_Workflow_Recipient_Change_Type_Editor_CSS_Selector = ".dropdown-menu.dropdown-menu-right.custom-dropdown-menu.show-up li:nth-child(3)";
        public const string New_Workflow_Recipient_Change_Type_Meeting_Host_CSS_Selector = ".dropdown-menu.dropdown-menu-right.custom-dropdown-menu.show-up li:nth-child(4)";
        public const string New_Workflow_First_Recipient_Change_Type_Click_CSS_Selector = ".recipient-list div:nth-child(1) .recipient-holder .drop-column .btn-default";
        public const string New_Workflow_Add_Parallel_Recipient1_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/div/div/div/div/input";
        public const string New_Workflow_Add_Custom_Second_Recipient_Order_CSS_Selector = ".recipient-list div:nth-child(2) .recipient-holder.custom-workflow input";
        public const string New_Workflow_Add_Custom_Third_Recipient_Order_CSS_Selector = ".recipient-list div:nth-child(3) .recipient-holder.custom-workflow input";


        //Add placeholder
        public const string New_Workflow_Add_Recipient3_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[3]/div[2]/div/div/div/input";
        public const string New_Workflow_Add_Recipient4_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[4]/div[2]/div/div/div/input";
        public const string New_Workflow_Add_Recipient5_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[5]/div[2]/div/div/div/input";
        public const string New_Workflow_Add_Placeholder_Click_CSS_Selector = ".icon.icon-add-placeholder";
        public const string New_Workflow_Add_Placeholder_CSS_Selector = ".recipient .recipient-holder div:nth-child(1) .input-column .input-group input";
        public const string New_Workflow_Placeholder3_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[3]/div[2]/div/div/div/div/button";
        public const string New_Workflow_Placeholder4_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[4]/div[2]/div/div/div/div/button";
        public const string New_Workflow_Add_Parallel_Placeholder2_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[3]/div/div/div/div/input";

        //Set permission
        public const string New_Workflow_Change_Recipient1_Permissions_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/ul[1]/li[1]";
        public const string New_Workflow_Change_Recipient1_Permissions_Set_Attachment_XPath = "//label[@for='permission.allowAddAttachment']";
        public const string New_Workflow_Change_Recipient1_Permissions_Allow_Download_XPath = "//label[@for='permission.allowDownload']";

        public const string Merge_Document_Top_By_Id = "True";
        public const string Attachment_Icon_By_CSS_Selector = "[data-target='attachment']";
        public const string Attachment_Button_CSSSelector = "[ng-click=\"attachment.openModalDialog('upload')\"]";

        //Recipient Access option
        public const string New_Workflow_Change_Recipient1_Access_Option_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/ul[1]/li[2]";
        public const string New_Workflow_Change_Recipient1_Access_Option_Authentication_Click_XPath = "//label[@for='docAccess.userAuthentication']";
        public const string New_Workflow_Change_Recipient1_Access_Option_Authentication_Password_Click_XPath = "//input[@ng-model='docAccess.password']";
        public const string New_Workflow_Change_Recipient1_Access_Option_Access_Duration_Click_XPath = "//label[@for='docAccess.duration']";
        public const string New_Workflow_Change_Recipient1_Access_Option_Access_Duration_CheckBox_Click_XPath = "//div[@ng-if='docAccess.duration']/div[2]/label";
        public const string New_Workflow_Change_Recipient1_Access_Option_Access_Duration_Type_Click_XPath = "//div[@ng-if='docAccess.durationType']/div/input";
        public const string New_Workflow_Change_Recipient1_Access_Option_Access_Duration_Type_Days_Click_XPath = "//input[@ng-model='docAccess.durationInDays']";

        //delete recipient
        public const string New_Workflow_Change_Recipient1_Delete_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/ul[1]/li[3]";

        //set reminder
        public const string New_Workflow_Change_Recipient1_Set_Reminder_Option_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/ul[1]/li[4]";
        public const string New_Workflow_Change_Recipient1_Set_Reminder_Click_XPath = "//div[@ng-model='global.documentPackage.signers']/div[1]/ul[1]/li[4]/ul[1]/li[1]";
        public const string New_Workflow_Change_Recipient1_Set_Reminder_checkBox_XPath = "//label[@for='autoRemind.setReminder']";
        public const string New_Workflow_Change_Recipient1_Set_Reminder_Set_Value_XPath = "//input[@ng-model='autoRemind.reminderDuration']";
        public const string New_Workflow_Change_Recipient1_Set_Auto_Reminder_checkBox_XPath = "//label[@for='autoRemind.setAutoReminder']";
        public const string Reminder_Set_Value_Name = "reminderDuration";
        public const string Auto_Reminder_Set_Value_Name = "autoRemindDuration";
        public const string Auto_Reminder_Limit_Value_Name = "autoRemindLimit";
        #endregion

        public const string Attachment_Document_Link_By_CSS_Selector = "[ng-click=\"toggleOpen()\"]";
        public const string Attachment_Document_Remove_By_CSS_Selector = "[ng-click=\"attachment.remove(item)\"]";
        public const string Attachment_Confirm_OK_Button = "[type=submit]";
        public const string Attachment_Download_Child_Node_By_CSS = "[class=\"icon icon-download pull-right\"]";

        public const string Package_Download_By_CSS_Selector = "[download-document-package]";
        public const string Package_Workflow_History_By_CSS_Selector = "[show-document-log]";
        public const string Navigate_Next_Workflow_From_Viewer = "[ng-click=\"navigate.navigateDocument(navigate.nextDocId)\"]";
        public const string Navigate_Previous_Workflow_From_Viewer = "[ng-click=\"navigate.navigateDocument(navigate.previousDocId)\"]";
        public const string Workflow_History_Search_Text_Button = "[ng-click=\"documentLog.search()\"]";
        public const string Workflow_History_Search_Text_Box = "[type=\"search\"]";
        public const string Workflow_History_Dialog_Close_Button = "[ng-click=\"onClose()\"]";
        public const string Workflow_Close_By_CSS_Selector = "[ng-click=\"viewer.close()\"]";
        public const string Workflow_Burger_Icon_By_CSS_Selector = "#dropdownMenu1";
        public const string Workflow_Delete_From_Viewer_By_CSS_Selector = "[class=\"icon icon-trash pull-left\"]";
        public const string Workflow_Print_From_Viewer_By_CSS_Selector = "[class=\"icon icon-print pull-left\"]";
        public const string Workflow_Delete_Confirm_From_Viewer_By_CSS_Selector = "[ng-click=\"onSave()\"]";
        public const string Workflow_Comments_Dialog_By_CSS_Selector = "[uib-tooltip=\"Comments\"]";
        public const string Workflow_Add_Comments_TextArea_By_CSS_Selector = "[placeholder=\"Enter message for all recipients\"]";
        public const string Workflow_Add_Comment_Button_By_CSS_Selector = "[ng-click=\"docComments.addComment(form.$valid)\"]";
        public const string Workflow_Save_Form_Field_By_CSS_Selector = "ul.dropdown-menu .icon.icon-save.pull-left";
        public const string Delegate_From_Viewer_By_CSS_Selector = ".icon-delegate";
        public const string Delegate_Name_By_CSS_Selector = ".modal-body .search-form .blue input";

        //Viewer image
        public const string Viewer_Image1_CSS_Selector = "img[id$= '_1_img']";
        public const string Viewer_Image2_CSS_Selector = "img[id$= '_2_img']";
        public const string Viewer_Image3_CSS_Selector = "img[id$= '_3_img']";
        public const string Viewer_Image4_CSS_Selector = "img[id$= '_4_img']";
        public const string Viewer_Signer1_CSS_Selector = "#collaborators div:nth-child(1)";
        public const string Viewer_Signer2_CSS_Selector = "#collaborators div:nth-child(2)";
        public const string Viewer_Signer3_CSS_Selector = "#collaborators div:nth-child(3)";
        public const string Viewer_Signer4_CSS_Selector = "#collaborators div:nth-child(4)";
        public const string Viewer_Placeholder2_CSS_Selector = "#collaborators div:nth-child(2) .title";

        //Edit signature field
        public const string Viewer_Signer_Active_Signature_Field_CSS_Selector = "div[id^= 'signer_'].signaturefield.current-signer";
        public const string Viewer_Signer_Active_Signature_Field_Edit_Cog_CSS_Selector = "#editIcon .icon-settings";
        public const string Viewer_Signer_Active_Signature_Field_Delete_Cog_CSS_Selector = "#editIcon .icon-trash";
        public const string Viewer_Signer_Active_Signature_Field_Dimension_Expand_CSS_Selector = "span[id^= 'ui-id-']";
        public const string Viewer_Signer_Active_Signature_Field_Dimension_Left_Position_CSS_Selector = "input[name='leftPosition']";
        public const string Viewer_Signer_Active_Signature_Field_Dimension_Top_Position_CSS_Selector = "input[name='topPosition']";
        public const string Viewer_Signer_Active_Signature_Field_Dimension_Width_Position_CSS_Selector = "input[name='width']";
        public const string Viewer_Signer_Active_Signature_Field_Dimension_Height_Position_CSS_Selector = "input[name='height']";
        public const string Viewer_Signer_ESign_OTP_Check_Box_By_Id = "currentSignature.showOTP";
        public const string Viewer_Signer_ESign_OTP_Text_Box_By_Name = "mobileNumber";

        //Edit inperson
        public const string Viewer_Signer_Active_Inperson_Field_CSS_Selector = "div[id^= 'inperson_'].signaturefield.current-signer";
        public const string Viewer_Signer_Active_Inpeson_Field_Edit_Cog_CSS_Selector = "#inpersonEdit .icon-settings";
        public const string Viewer_Signer_Active_Inpeson_Field_Delete_Cog_CSS_Selector = "#inpersonEdit .icon-trash";
        public const string Viewer_Signer_Active_Inpeson_Replicate_Option_click_CSS_Selector = ".ms-parent button";
        public const string Viewer_Signer_Active_Inpeson_Replicate_Option_Select_All_click_CSS_Selector = ".ms-drop .ms-select-all";
        public const string Viewer_Signer_Active_Inpeson_OTP_Check_CSS_Selector = "label[for='inperson.showOTP']";
        public const string Viewer_Signer_Active_Inpeson_OTP_Input_CSS_Selector = "input[type='tel']";
        public const string Viewer_Edit_Inperson_Field_CSS_Selector = "#inpersonEdit .icon-settings";
        public const string Viewer_Delete_Inperson_Field_CSS_Selector = ".grid-body.scroll-auto div:nth-child(3) div:nth-child(1) div:nth-child(4) div:nth-child(1) span input";

        //Edit initial
        public const string Viewer_Signer_Active_Initial_Field_CSS_Selector = "div[id^= 'initial_'].signaturefield.current-signer";
        public const string Viewer_Signer_Active_Initial_Field_Edit_Cog_CSS_Selector = "#initialEditIcon .icon-settings";
        public const string Viewer_Signer_Active_Initial_Field_Delete_Cog_CSS_Selector = "#initialEditIcon .icon-trash";
        public const string Viewer_Signer_Active_Initial_Replicate_Option_click_CSS_Selector = ".ms-parent .ms-choice";
        public const string Viewer_Signer_Active_Initial_Replicate_Option_Select_All_click_CSS_Selector = ".ms-drop .ms-select-all";
        public const string Viewer_Signer_Active_Initial_OTP_Check_CSS_Selector = "label[for='inperson.showOTP']";
        public const string Viewer_Signer_Active_Initial_OTP_Input_CSS_Selector = "input[type='tel']";
        public const string Viewer_Delete_Initial_Field_CSS_Selector = ".grid-body.scroll-auto div:nth-child(3) div:nth-child(1) div:nth-child(4) div:nth-child(1) input";

        #region User defined fields edit common
        public const string Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Click_CSS_Selector = "#assignedTo span";
        public const string Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(4)";
        public const string Viewer_Signer_Active_Form_Field_Assigned_To_Dropdown_Radio_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(4)";
        public const string Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Click_CSS_Selector = "#fontType span";
        public const string Viewer_Signer_Active_Form_Field_Font_Type_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(5)";
        public const string Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Click_CSS_Selector = "#fontSize span";
        public const string Viewer_Signer_Active_Form_Field_Font_Size_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(7)";
        public const string Viewer_Signer_Active_Form_Field_Placeholder_CSS_Selector = "#placeHolder input";
        public const string Viewer_Signer_Active_Form_Field_Allowed_Length_CSS_Selector = "#allowedLength input";

        public const string Viewer_Signer_Active_Form_Field_Date_Type_Dropdown_Click_CSS_Selector = "#dateFormatType span";
        public const string Viewer_Signer_Active_Form_Field_Date_Type_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(5)";
        public const string Viewer_Left_Panel_Toggle_CSS_Selector = "#toggleButtonLeft";
        public const string Viewer_Signer_Active_CheckBox_Field_Edit_Required_CSS_Selector = "#mandatory label";

        public const string Viewer_Form_Field_Font_Size1_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(3)";
        public const string Viewer_Form_Field_Font_Size2_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(4)";
        public const string Viewer_Form_Field_Font_Size3_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(5)";
        public const string Viewer_Form_Field_Font_Size4_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(6)";
        public const string Viewer_Form_Field_Font_Size5_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(8)";
        public const string Viewer_Form_Field_Font_Size6_Dropdown_Select_CSS_Selector = "ul.ui-select-choices > li div:nth-child(9)";

        #endregion


        //Edit Name
        public const string Viewer_Signer_Active_Name_Field_CSS_Selector = "div[type^='SH_FF_NAME_']";
        public const string Viewer_Signer_Active_Name_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_NAME_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Name_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_NAME_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Name_Field_Input_CSS_Selector = "div[type^='SH_FF_NAME_'] input";
        public const string Viewer_Form_Field1_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(1) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field2_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(2) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field3_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(3) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field4_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(4) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field5_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(5) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field6_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(6) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Field7_Settings_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(7) #input_userdefined .field-user .field-icons .icon-settings";
        public const string Viewer_Form_Unassigned_Field_Settings_CSS_Selector = "#unsignedExistingFields div:nth-child(1) .signaturefield .field-icons .icon-settings";
        public const string Viewer_Unassigned_Field_Fill_CSS_Selector = "#unsignedExistingFields div:nth-child(1) .signaturefield";

        //Edit Email
        public const string Viewer_Signer_Active_Email_Field_CSS_Selector = "div[type^='SH_FF_EMAIL_']";
        public const string Viewer_Signer_Active_Email_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_EMAIL_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Email_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_EMAIL_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Email_Field_Input_CSS_Selector = "div[type^='SH_FF_EMAIL_'] input";

        //Edit Job Title
        public const string Viewer_Signer_Active_Job_Title_Field_CSS_Selector = "div[type^='SH_FF_JOBTITLE_']";
        public const string Viewer_Signer_Active_Job_Title_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_JOBTITLE_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Job_Title_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_JOBTITLE_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Job_Title_Field_Input_CSS_Selector = "div[type^='SH_FF_JOBTITLE_'] input";

        //Company
        public const string Viewer_Signer_Active_Company_Field_CSS_Selector = "div[type^='SH_FF_COMPANY_']";
        public const string Viewer_Signer_Active_Company_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_COMPANY_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Company_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_COMPANY_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Company_Field_Input_CSS_Selector = "div[type^='SH_FF_COMPANY_'] input";

        //Date
        public const string Viewer_Signer_Active_Date_Field_CSS_Selector = "div[type^='SH_FF_DATE_']";
        public const string Viewer_Signer_Active_Date_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_DATE_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Date_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_DATE_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Date_Field_Input_CSS_Selector = "div[type^='SH_FF_DATE_'] input";

        //Text
        public const string Viewer_Signer_Active_Text_Field_CSS_Selector = "div[type^='SH_FF_TEXT_']";
        public const string Viewer_Signer_Active_Text_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_TEXT_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Text_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_TEXT_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Text_Field_Input_CSS_Selector = "div[type^='SH_FF_TEXT_'] input";
        public const string Viewer_Text1_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(1) #input_userdefined .field-user input";
        public const string Viewer_Text2_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(2) #input_userdefined .field-user input";
        public const string Viewer_Text3_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(3) #input_userdefined .field-user input";
        public const string Viewer_Text4_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(4) #input_userdefined .field-user input";
        public const string Viewer_Text5_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(5) #input_userdefined .field-user input";
        public const string Viewer_Text6_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(6) #input_userdefined .field-user input";
        public const string Viewer_Text7_Field_Input_CSS_Selector = "div[ng-controller='FormFieldsController'] div:nth-child(7) #input_userdefined .field-user input";
        public const string Viewer_On_Page_Comment_CSS_Selector = "#beforeComment_0";
        public const string Viewer_On_Page_Comment_Save_CSS_Selector = "#page-comments .icon.icon-save";

        //Checkbox
        public const string Viewer_Signer_Active_CheckBox_Field_CSS_Selector = "div[type^='SH_FF_CHECKBOX_']";
        public const string Viewer_Signer_Active_CheckBox_Field_Edit_Cog_CSS_Selector = "div[type^='SH_FF_CHECKBOX_'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_CheckBox_Field_Delete_Cog_CSS_Selector = "div[type^='SH_FF_CHECKBOX_'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_CheckBox_Field_Input_CSS_Selector = "div[type^='SH_FF_CHECKBOX_'] label";

        //Radio
        public const string Viewer_Signer_Active_Radio_Field_CSS_Selector = "div[type^='RADIO-']";
        public const string Viewer_Signer_Active_Radio_Field_Edit_Cog_CSS_Selector = "div[type^='RADIO-'] .field-icons .icon-settings";
        public const string Viewer_Signer_Active_Radio_Field_Delete_Cog_CSS_Selector ="div[type^='RADIO-'] .field-icons .icon-trash";
        public const string Viewer_Signer_Active_Radio_Field_Input_CSS_Selector = "div[type^='RADIO-'] input";

        //Change recipients pending/inprogress mode
        public const string Viewer_Change_Recipient_Pending_First_Signer_CSS_Selector = ".grid-body.scroll > div:nth-child(1) input";
        public const string Viewer_Change_Recipient_Pending_Second_Signer_CSS_Selector = ".grid-body.scroll > div:nth-child(2) input";

        //Viewer open recipient dialog
        public const string Viewer_Recipient_Dialog_CSS_Selector = ".pull-right .icon-settings";
        public const string Viewer_Document_Dialog_CSS_Selector = ".pull-left .icon-settings";

        public const string General_Submit_Button_CSS_Selector = "button[type='submit']";

        public const string Settings_Locale_Select_To_Dropdown_CSS_Selector = "ul.ui-select-choices > li div:nth-child(3)";

        public const string Enterprise_Settings_Invite_Search_Css_Selector = ".tab-pane.active input[type='search']";

        public const string General_Error_Toaster_Message_Css_Selector = "#toast-container .toast.toast-error";
        public const string General_Error_Toaster_Message_Text_Css_Selector = "#toast-container > div:nth-child(1) .toast-message";
        public const string General_Error_Toaster_Message_Close_Css_Selector = "#toast-container .toast-close-button";
        public const string General_Success_Toaster_Message_Css_Selector = "#toast-container .toast.toast-success";
        public const string General_Success_Toaster_Message_Text_Css_Selector = "#toast-container .toast-message";

        public const string Enteprise_Integration_External_User_Icon_CSS_Selector = ".pull-right.icon.edit-user";
        public const string Enteprise_Integration_External_User_Icon_Add_CSS_Selector = ".icon.plus-circle";
        public const string Enteprise_Integration_External_User_Email_CSS_Selector = "input[type='email']";
        public const string Enteprise_Integration_External_User_Icon_Edit_CSS_Selector = ".edit";
        public const string Enteprise_Integration_External_User_Icon_Trash_CSS_Selector = ".icon.pull-right.delete";
        public const string Enteprise_Integration_External_User_CheckBox_CSS_Selector = ".pull-left.checkbox";

        #region Authorized device 
        public const string Authorised_Device_tab_CssSelector = ".nav-tabs li:nth-child(6) a";
        public const string Select_Authorised_Device_CssSelector = ".custom-grid.hover div:nth-child(2) div:nth-child(1) div:nth-child(1) div label";
        public const string Remove_Device_Confirm_Button_CssSelector = ".btn-primary";
        #endregion

        #region Role validation
        public const string Enterprise_Roles_UserSettings_Signature_Settings_CheckBox_ID = "advance.digitalSignature";
        public const string Enterprise_Roles_UserSettings_Groups_Contacts_CheckBox_ID = "advance.groups";
        public const string Enterprise_Roles_UserSettings_Template_CheckBox_ID = "advance.templates";        
        public const string Enterprise_Roles_UserSettings_Notification_CheckBox_ID = "advance.notificationSettings";
        public const string Enterprise_Roles_UserSettings_Clouds_CheckBox_ID = "enterprise.manageDropBox";
        public const string Enterprise_Roles_UserSettings_Legal_Notice_CheckBox_ID = "advance.legalNotice";
        public const string Enterprise_Roles_UserSettings_Delegate_Signing_CheckBox_ID = "advance.delegates";
        public const string Enterprise_Roles_UserSettings_Only_Registerd_Users_CheckBox_ID = "advance.manageDelegateSignerShare";
        public const string Enterprise_Roles_UserSettings_Only_Enterprise_Contact_CheckBox_ID = "advance.manageShareWithinEnterprise";
        public const string Enterprise_Roles_UserSettings_Automatically_Proceed_Workflow_CheckBox_ID = "advance.autoFinsih";
        public const string Enterprise_Roles_UserSettings_Advance_CheckBox_ID = "advance.managePersonalAdvance";

        public const string Enterprise_Roles_EnterpriseSettings_Notification_CheckBox_ID = "enterprise.manageNotifications";
        public const string Enterprise_Roles_EnterpriseSettings_Profile_CheckBox_ID = "enterprise.manageProfile";
        public const string Enterprise_Roles_EnterpriseSettings_Groups_CheckBox_ID = "enterprise.manageGroups";
        public const string Enterprise_Roles_EnterpriseSettings_Library_CheckBox_ID = "enterprise.manageLibrary";
        public const string Enterprise_Roles_EnterpriseSettings_Roles_CheckBox_ID = "enterprise.manageRole";
        public const string Enterprise_Roles_EnterpriseSettings_Users_CheckBox_ID = "enterprise.manageUsers";
        public const string Enterprise_Roles_EnterpriseSettings_Branding_CheckBox_ID = "enterprise.manageBranding";
        public const string Enterprise_Roles_EnterpriseSettings_Integration_CheckBox_ID = "enterprise.manageIntegration";
        public const string Enterprise_Roles_EnterpriseSettings_Advance_CheckBox_ID = "enterprise.manageAdvanced";
        public const string Enterprise_Roles_EnterpriseSettings_Reports_CheckBox_ID = "enterprise.manageReport";

        public const string Checkbox_CSS_Selector = ".grid-body.scroll-auto div:nth-child(2)";
        public const string Library_Listing_Checkbox_CSS_Selector = ".grid-body.scroll-auto div:nth-child(1)";

        public const string View_Group_Members_CSS_Selector = ".underline-text";

        public const string Template_Name_CSS_Selector = ".modal-body div div:nth-child(2) input";

        public const string Rename_Template_CSS_Selector = ".dropdown-menu li:nth-child(2)";

        public const string Upload_Template_Fail_CSS_Selector = ".progress.upload-item.failure";

        public const string Duplicate_Legal_Notice_Message_CSS_Selector = "#Title div";

        public const string Role_View_Users_CSS_Selecter = ".underline-text";
        public const string Search_Button_CSS_Selecter = ".btn.btn-default.btn-submit";

        public const string Active_Tab_Checkbox_CSS_Selector = ".tab-pane.active .grid-body > div:nth-child(1)";

        public const string Active_Tab_Delete_Icon_CssSelector = ".tab-pane.active .icon-trash";
        public const string Cookies_Button_Css_Selecter = ".cookies-info-bar.activate .btn.btn-default";
        public const string General_Cancel_Button_CssSelector = ".btn-bottom .btn.btn-default";
        public const string Enterprise_Duplicate_Legal_Notice_Message_CSS_Selector = ".ngMessagesClass";
        public const string User_Stats_Date_Time_From_Css_Selecter = ".tab-pane.active .listing-header > div:nth-child(1) > div:nth-child(1) .date-time-holder";
        public const string User_Stats_Date_Time_Clear_From_Css_Selecter = ".tab-pane.active .listing-header > div:nth-child(1) > div:nth-child(1) .date-time-holder .btn-close";

        public const string User_Stats_Date_Time_To_Css_Selecter = ".tab-pane.active .listing-header > div:nth-child(1) > div:nth-child(2) .date-time-holder";
        public const string User_Stats_Date_Time_Clear_To_Css_Selecter = ".tab-pane.active .listing-header > div:nth-child(1) > div:nth-child(2) .date-time-holder .btn-close";

        public const string Document_Permission_Css_Selecter = ".icon.icon-lock";
        public const string Document_Access_Permission_Css_Selecter = ".icon-authentication";
        public const string Document_Access_Permission_Password_Css_Selecter = "docAccess.userAuthentication";
        public const string Document_Access_Duration_Permission_Css_Selecter = "docAccess.duration";
        public const string Document_Access_Permission_Password_Field_By_Name = "password";
        public const string Document_Access_Permission_OTP_Field_By_Name = "mobileNumber";
        public const string Document_Access_Permission_OTP_By_Id = "otp";
        public const string Document_Permission_Allow_Attachment_By_Id = "permission.allowAddAttachment";
        public const string Document_Permission_Allow_Print_Css_Selecter = "permission.allowPrint";
        public const string Document_Permission_Allow_Download_Css_Selecter = "permission.allowDownload";
        public const string Document_Permission_Allow_Legal_Notice_Css_Selecter = "permission.allowLegalNotice";
        public const string Document_Permission_Allow_Change_Signer_Css_Selecter = "permission.allowChangeSigner";

        public const string Select_First_Recipient_By_Css_Celector = ".recipient-list div:nth-child(1) .recipient-holder div:nth-child(1) .input-column .input-group input";

        public const string Start_New_Workflow_Delete_Recipient_Css_Celector = ".recipient .icon-trash";

        public const string Recipient_Model_From_Listing_Css_Celector = ".listing div:nth-child(1) .doc-title-area .sub-info .icon-more-horiz";
        public const string Frist_Recipient_From_Listing_Css_Celector = ".custom-grid .grid-body div:nth-child(1) .input-group.blue.no-btn input";
        public const string Second_Recipient_From_Listing_Css_Celector = ".custom-grid .grid-body div:nth-child(2) .input-group.blue.no-btn input";
        public const string Third_Recipient_From_Listing_Css_Celector = ".custom-grid .grid-body div:nth-child(3) .selected .search-form .input-group.blue .input-group-btn";
        public const string Fourth_Recipient_From_Listing_Css_Celector = ".custom-grid .grid-body div:nth-child(4) .selected .search-form .input-group.blue .input-group-btn";
        public const string Placeholder_Bar_In_Viewer_By_Id = "showRecipients";
       
        public const string Document_Access_Permission_From_Date = "html/body/div/div/div/div/div[2]/ng-form/div[2]/div[2]/div[1]/div[1]/div/div[2]/div[2]/button";
        public const string Permission_Select_From_Date_XPath = "//html/body/div[contains(@class, 'datetimepicker')]/div[@class= 'datetimepicker-days']/table/tfoot";

        public const string Viewer_Attachment_Css_Selector = ".icon.icon-attachment";
        public const string Viewer_Add_Attachment_Css_Selector = ".icon.add-attachment";
        public const string Error_Toaster_Message_Text_Css_Selector = ".error-message";

        public const string Personal_Advance_Tab_By_Id = "personal.advance";
        public const string Personal_Advance_Remove_Account_Button_By_Id = "btn-save-remove-account";

        public const string Enterprise_Reports_Tab_By_Id = "enterprise.reports";

        #endregion
    }
}
