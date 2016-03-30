namespace UnitTesting
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MsTest
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.OleDb",
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='F:\\Users\\Александр\\Source\\Repos\\AutomationTesting\\HW\\TestResults\\TestData.xls';Persist Security Info=False;Extended Properties='Excel 8.0'",
            "Sheet1$", DataAccessMethod.Sequential)]
        public void DataSourceTest()
        {
            string rowNumber = this.TestContext.DataRow["Number"].ToString();
            string rowText = this.TestContext.DataRow["Text"].ToString();

            Assert.IsNotNull(rowNumber);
            Assert.IsNotNull(rowText);
        }

        [TestMethod]
        public void SimpleStringAssert()
        {
            StringAssert.Contains("ABCD", "BC");
        }
        
      [TestMethod]
      public void SimpleTestExample()
      {
          Assert.IsTrue(true);
      }



  }
}
