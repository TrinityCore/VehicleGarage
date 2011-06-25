using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;
using VehicleGarage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VehicleGarage.DBCStores;
using VehicleGarage.DBCStructures;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for FormMainTest and is intended
    ///to contain all FormMainTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FormMainTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for _lvSearchResults_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("VehicleGarage.exe")]
        public void _lvSearchResults_SelectedIndexChangedTest()
        {
            FormMain_Accessor target = new FormMain_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target._lvSearchResults_SelectedIndexChanged(sender, e);

            var tabControl = target._tcSeats;
            for (uint i = 0; i < (uint) Constants.MaxVehicleSeats; ++i)
                tabControl.TabPages.Add("seat" + i);

            Assert.AreEqual(tabControl.TabCount, 8+1);

            foreach (TabPage tab in tabControl.TabPages.Cast<object>().Where(tab => !tab.Equals(target._tpMain)))
                tabControl.TabPages.Remove(tab);

            tabControl.SelectedTab = target._tpMain;

            Assert.AreEqual(tabControl.TabCount, 1);
        }
    }
}
