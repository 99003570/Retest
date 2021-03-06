using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Food_Ordering_App;
namespace Food_Ordering_AppTests
{
    [TestClass()]
    public class VisitorOrderTests
    {
        [TestMethod()]
        public void CheckoutVisitorTest()
        {
            double expected = 440;
            VisitorOrder CObj = new VisitorOrder();
            double actual = CObj.CheckoutVisitor(10, 10,"Ram");
            Assert.AreEqual(actual, expected);
        }
    }
}
