using NUnit.Framework;
using OpenQA.Selenium;
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
    public class Document_Listing_Fillters_Search : General_Methods
    {
        #region All Methods

        /// <summary>
        /// Test all methods of filters and search
        /// </summary>
        [Test]
        public void AllSearchMethods()
        {
            try
            {
                //Verify document listing
                VerifyFiltersPrivate();

                //Search from document listing
                SimpleSearchPrivate();

                //Advance search for Document Expiry
                AdvanceSearchDocumentExpiryPrivate();

                //Advance search
                AdvanceSearchPrivate();

                //Advance search for document package
                AdvanceSearchDocumentPackagePrivate();

                //Sort order of document listing
                SortDocumentsListPrivate();

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
        /// Verify Filter and opne document 
        /// </summary>
        [Test]
        public void VerifyFilters()
        {
            try
            {
                VerifyFiltersPrivate();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Sort document listing
        /// </summary>
        [Test]
        public void SortDocumentsList()
        {
            try
            {
                SortDocumentsListPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        
        /// <summary>
        /// Search by name or document in document listing
        /// </summary>
        [Test]
        public void SimpleSearch()
        {
            try
            {
                SimpleSearchPrivate();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Click on advance search button
        /// </summary>
        [Test]
        public void AdvanceSearch()
        {
            try
            {
                AdvanceSearchPrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Advance search for document package
        /// </summary>
        [Test]
        public void AdvanceSearchDocumentPackage()
        {
            try
            {
                AdvanceSearchDocumentPackagePrivate();

                //Log test case
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        ///Advance search for document expiry
        /// </summary>
        [Test]
        public void AdvanceSearchDocumentExpiry()
        {
            try
            {
                AdvanceSearchDocumentExpiryPrivate();
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

        void ChangeFilter(string filterXpath)
        {
            try
            {
                //Click on filter
                FindElement(driver, By.Id(filterXpath)).Click();
                Thread.Sleep(2000);

                //Open document
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Open_Document_XPath)).Click();
                Thread.Sleep(3000);

                //Click on back button from viewer
                FindElement(driver, By.XPath(Elements_Paths.Viewer_Back_Button_XPath)).Click();
                Thread.Sleep(2000);                
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Test filters of document listing
        /// </summary>
        void VerifyFiltersPrivate()
        {
            try
            {
                //Go to document listing
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                Thread.Sleep(2000);

                //Select drat filter
                ChangeFilter(Elements_Paths.Filter_Draft_IdSelector);

                //Select inprogress filter
                ChangeFilter(Elements_Paths.Filter_Inprogress_IdSelector);

                //Select all filter
                FindElement(driver, By.Id(Elements_Paths.Filter_All_IdSelector)).Click();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Test sort order of document listing
        /// </summary>
        void SortDocumentsListPrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                //Click on sort order 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Sort_Order_CssSelector)).Click();

                //Order by date 
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Order_By_Date_XPath)).Click();
                Thread.Sleep(4000);

                //Click on sort order 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Sort_Order_CssSelector)).Click();

                //Order by name
                FindElement(driver, By.XPath(Elements_Paths.Document_Listing_Order_By_Name_XPath)).Click();
                Thread.Sleep(4000);

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        /// <summary>
        /// Search from document listing
        /// </summary>
        void SimpleSearchPrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                //Add text in search field and perform search          
                driver.FindElement(By.CssSelector(Elements_Paths.Document_Listing_Search_CssSelector)).SendKeys(TestData.Simple_Search_Text);

                //Click on search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Document_Listing_Submit_Search_CssSelector)).Click();
                Thread.Sleep(3000);

                FindElement(driver, By.CssSelector(Elements_Paths.Clear_Search_CssSelector)).Click();
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
        /// Click on advance search button
        /// </summary>      
        void AdvanceSearchPrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                //Click on advance search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button_CssSelector)).Click();
                Thread.Sleep(1000);

                FindElement(driver, By.Id(Elements_Paths.Advance_Search_DocumentName_IDSelector)).SendKeys(TestData.Advance_Search_DocumentName_Text);

                FindElement(driver, By.Id(Elements_Paths.Advance_Search_Owner_IDSelector)).SendKeys(TestData.Advance_Search_OwnerName_Text);

                //Click on Document Status dropdown 
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Document_Status_XPath)).Click();

                //Select Signed status
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Signed_Document_Status_XPath)).Click();

                //Click on Folder dropdown 
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Folder_XPath)).Click();

                //Select Inbox folder
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Inbox_Folder_XPath)).Click();

                //Click on Document Type dropdown 
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Document_Type_XPath)).Click();

                //Select PDF Document Type
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_PDF_Document_Type_XPath)).Click();

                //Add document source
                FindElement(driver, By.Id(Elements_Paths.Advance_Search_Source_IDSelector)).SendKeys(TestData.Advance_Search_Source_Text);

                //Add document from size
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_From_Size_XPath)).SendKeys(TestData.Advance_Search_From_Size_Text);

                //Add document to size
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_To_Size_XPath)).SendKeys(TestData.Advance_Search_To_Size_Text);

                //Check "Only certified signed documents" checkbox
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Certified_Checkbox_XPath)).Click();

                //Check "Only documents that have form fields" checkbox
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Documents_Fields_Checkbox_XPath)).Click();

                //Click on search button
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button)).Click();
                Thread.Sleep(5000);

                //Clear Search
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Clear_Search)).Click();
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
        /// Advance search for document package
        /// </summary>
        void AdvanceSearchDocumentPackagePrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                //Click on advance search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button_CssSelector)).Click();
                Thread.Sleep(1000);

                //Add "To" name
                FindElement(driver, By.Id(Elements_Paths.Advance_Search_ToName_IDSelector)).SendKeys(TestData.Advance_Search_To_Text);

                //Add "Document Id"
                FindElement(driver, By.Id(Elements_Paths.Advance_Search_DocumentId_IDSelector)).SendKeys(TestData.Advance_Search_Document_Id_Text);

                //Add "Document Package Id"
                FindElement(driver, By.Id(Elements_Paths.Advance_Search_PackageId_IDSelector)).SendKeys(TestData.Advance_Search_Document_Package_Id_Text);

                //Click on Document Status dropdown 
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Document_Status_XPath)).Click();

                //Select Inprogress status
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Inprogress_Document_Status_XPath)).Click();

                //Add document from size
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_From_Size_XPath)).SendKeys(TestData.Advance_Search_From_Size_Text);

                //Add document to size
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_To_Size_XPath)).SendKeys(TestData.Advance_Search_To_Size_Text);

                //Check "Only certified signed documents" checkbox
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Certified_Checkbox_XPath)).Click();

                //Click on search button
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button)).Click();
                Thread.Sleep(5000);

                //Clear Search
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Clear_Search)).Click();
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
        ///Advance search for document expiry
        /// </summary>        
        void AdvanceSearchDocumentExpiryPrivate()
        {
            try
            {
                FindElement(driver, By.CssSelector(Elements_Paths.Dashboard_Main_Document_CssSelector)).Click();
                
                //Click on advance search button 
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button_CssSelector)).Click();
                Thread.Sleep(1000);

                //Click on "From" date
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_From_Date_XPath)).Click();
                Thread.Sleep(1000);

                try
                {
                    //Select first date of date picker
                    FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Select_From_Date_XPath)).Click();
                }
                catch (Exception)
                {
                }


                //Focus on "Only certified signed documents" checkbox
                FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Certified_Checkbox_XPath)).Click();

                try
                {
                    //Click on "TO" date
                    FindElement(driver, By.XPath(Elements_Paths.Advance_Search_To_Date_XPath)).Click();

                    //Select first date of date picker
                    FindElement(driver, By.XPath(Elements_Paths.Advance_Search_Select_To_Date_XPath)).Click();
                }
                catch (Exception)
                {
                }

                //Click on search button
                FindElement(driver, By.CssSelector(Elements_Paths.Advance_Search_Button)).Click();
                Thread.Sleep(5000);

                //Clear Search
                FindElement(driver, By.XPath(Elements_Paths.Document_listing_Clear_Search)).Click();
                Thread.Sleep(2000);

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
