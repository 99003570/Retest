using Microsoft.VisualStudio.TestTools.UnitTesting;
using Food_Ordering_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Ordering_App.Tests
{
    [TestClass()]
    public class VisitorOrderTest
    {
        [TestMethod()]
        public void CheckoutVisitorTest()
        {
            double expected = 88;
            VisitorOrder VObj = new VisitorOrder();
            double actual = VObj.CheckoutVisitor(2, 2, "Sandy");
            Assert.AreEqual(actual, expected);
        }
    }
}