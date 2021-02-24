using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using MoviesforRent;


namespace UnitTest1
{
    [TestClass]
    public class DataTable
    {
      [TestClass]
        public class UnitTest1
        {
            DataTable myDataTable = new DataTable();
            [TestMethod]
            public void TestMethod1()
            {
                string nameDataTable = myDataTable.Checkdt();
                Assert.AreEqual(nameDataTable, "MoviesforRent");
            }
        }
    }
}
