using System.Collections;
using System.Linq;
using VehicleGarage.SQLStores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VehicleGarage.SQLStructures;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for SQLReaderTest and is intended
    ///to contain all SQLReaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SQLReaderTest
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

        [TestMethod()]
        public void VerifyRecordData()
        {
            var actual = SQLReader.LoadCreatureTemplates();

            var record = actual[23693];

            Assert.AreEqual(record.Name, "Duskwing Eagle");
            Assert.AreEqual(record.NPCFlag, 0u);
            Assert.AreEqual(record.UnitFlags, 0u);
            Assert.AreEqual(record.DynamicFlags, 8u);
            Assert.AreEqual(record.VehicleId, 23u);
            Assert.AreEqual(record.AIName, String.Empty);
            Assert.AreEqual(record.InhabitType, 7u);
            Assert.AreEqual(record.ScriptName, String.Empty);
            Assert.AreEqual(record.WDBVerified, 12340u);
        }

        [TestMethod()]
        public void VerifyTableData()
        {
            var actual = SQLReader.LoadCreatureTemplates();

            Assert.AreEqual(actual.Count(), 231);
            Assert.AreEqual(actual.Count(x => x.Value.VehicleId == 0), 0);
            Assert.AreEqual(actual.Max(x => x.Value.Id), 40725u);
        }
    }
}
