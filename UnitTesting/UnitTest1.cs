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
      //Testing for database
        public class UnitTest1
        {
            DataTable myDataTable = new DataTable();
            [TestMethod]
            public void TestMethod1()
            {
                
                string nameDataTable = myDataTable.dtcheck();
                Assert.AreEqual(nameDataTable, "MoviesforRent");
            }
        }
    }
}
