using Microsoft.VisualStudio.TestTools.UnitTesting;
using Food_Ordering_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Food_Ordering_AppTests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void CheckCustomerTypeTest()
        {
            Boolean expected = true;
            Validation ValidObj = new Validation();
            string abc = "Visitor";
            Boolean actual = ValidObj.CheckCustomerType(abc);
            Assert.AreEqual(expected, actual);
        }
    }
}