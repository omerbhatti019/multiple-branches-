using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTest
{
    [TestFixture]
    public class WholeSystem : General_Methods
    {
        MySettings mysettings = new MySettings();
        EnterpriseSettings enterprisesettings = new EnterpriseSettings();
        Dashboard dashboard = new Dashboard();
        Apply_Template applytemplate = new Apply_Template();


        #region Whole system
        [Test]
        public void WholeSystemTest()
        {
            try
            {
                WholeSystemEnterprise();
                Thread.Sleep(2000);

                WholeDashboard();
                Thread.Sleep(3000);

                new DocumentListing().AllMethodsOfDocumentListing();
                Thread.Sleep(5000);

                WholeSystemDocumentSharing();
                Thread.Sleep(5000);

                WholeSystemDocumentPreparation();
                Thread.Sleep(2000);

                WholeSystemDocumentViewer();
                Thread.Sleep(5000);

                WholeSystemViewerMoreActions();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        ///<summary>
        ///Enterprise admin
        /// </summary>
        #region Enteprrise settings
        [Test]
        public void WholeSystemEnterprise()
        {
            try
            {
                //Test all Personal Settings
                mysettings.AllPersonalSettings();

                //Test all Enterprise Settings
                enterprisesettings.AllEnterpriseSettings();

                //Test dashboard
                dashboard.AllDashboardEnterpriseNavigation();

                //Apply Template
                applytemplate.ApplyTemplateAll();

                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        ///<summary>
        ///Individual User
        /// </summary>
        #region Individual settings
        [Test]
        public void WholeSystemIndividual()
        {
            try
            {
                //Test all Personal Settings
                mysettings.PerosnalAllMySettings();

                //Test dashboard
                dashboard.AllDashboardIndvidualNavigation();

                //Apply Template
                applytemplate.ApplyTemplateAll();

                //Log test success
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }


        #endregion


        #region Whole dashboard
        [Test]
        public void WholeDashboard()
        {
            Dashboard _dashboard = new Dashboard();
            try
            {
                Thread.Sleep(2000);
                _dashboard.AllDashboardEnterpriseNavigation();
                Thread.Sleep(2000);
                _dashboard.AllDashboardIndvidualNavigation();
                Thread.Sleep(2000);
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message,ex);
            }
        }
        #endregion



        #region Document sharing
        [Test]
        public void WholeSystemDocumentSharing()
        {
            try
            {
                new Document_Share().AllShareDocument();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Document perparation
        [Test]
        public void WholeSystemDocumentPreparation()
        {
            try
            {
                new DocumentPreparation().RunAllDocumentPreparationTestMethods();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }

        #endregion

        #region Document viewer fields
        [Test]
        public void WholeSystemDocumentViewer()
        {
            try
            {
                new DocumentViewer().RunAllEditFieldsTestCases();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region Document viewer fields
        [Test]
        public void WholeSystemViewerMoreActions()
        {
            try
            {
                new Viewer_MoreAction().Viewer_All_More_Actions();
                LogTestCase(GetCurrentMethod());
            }
            catch (Exception ex)
            {
                LogTestCase(GetCurrentMethod(), ex.Message, ex);
            }
        }
        #endregion

        #region MyRegion

        #endregion

    }
}
