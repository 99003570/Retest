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
    public class CateringOrderTests
    {
        [TestMethod()]
        public void CheckoutCateringTest()
        {
            double expected = 540;
            CateringOrder CObj = new CateringOrder();
            double actual = CObj.CheckoutCatering(10, 10, "sandy", "100");
        }
    }
}

