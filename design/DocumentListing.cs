using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture][Parallelizable]
    /// <summary>
    /// User Enterprise settings
    /// </summary>
    public class DocumentListing : General_Methods
    {
        #region Other classes
        Document_Listing_Folders document_Listing_Folders = new Document_Listing_Folders();
        Document_Listing_Fillters_Search document_Listing_Fillters_Search = new Document_Listing_Fillters_Search();
        Document_Listing_More_Options document_Listing_More_Options = new Document_Listing_More_Options();
        #endregion

        #region All methods of document listing 
        /// <summary>
        /// All methods of document listing 
        /// </summary>
        [Test]
        public void AllMethodsOfDocumentListing()
        {
            try
            {
                //Test all folder methods
                document_Listing_Folders.AllFolderOprations();

                //Test filters, sort and search
                document_Listing_Fillters_Search.AllSearchMethods();

                //Test all document listing more options methods
                document_Listing_More_Options.MoreOptionsAllMethods();

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