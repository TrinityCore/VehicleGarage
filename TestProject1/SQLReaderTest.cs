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
        public void ReadSQLTest()
        {
            List<CreatureTemplate> actual = SQLReader.ReadSQL<CreatureTemplate>();

            var records =
                from r in actual
                where r.Id == 1
                select r;

            Assert.AreEqual(1, records.Count());
            foreach (var record in records)
            {
                Assert.AreEqual(record.Name, "Waypoint (Only GM can see it)");
                Assert.AreEqual(record.NPCFlag, (uint)0);
                Assert.AreEqual(record.UnitFlags, (uint)0);
                Assert.AreEqual(record.DynamicFlags, (uint)0);
                Assert.AreEqual(record.VehicleId, (uint)0);
                Assert.AreEqual(record.AIName, String.Empty);
                Assert.AreEqual(record.InhabitType, (uint)7);
                Assert.AreEqual(record.ScriptName, String.Empty);
                Assert.AreEqual(record.WDBVerified, (uint)1);
            }
        }
    }
}
