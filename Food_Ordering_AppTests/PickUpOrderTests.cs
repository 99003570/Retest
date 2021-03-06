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
    public class PickUpOrderTests
    {
        [TestMethod()]
        public void CheckoutPickUpTest()
        {
            double expected = 540;
            PickUpOrder CObj = new PickUpOrder();
            double actual = CObj.CheckoutPickUp(10, 10,"100","sandy");
            Assert.AreEqual(actual, expected);
        }
    }
}

