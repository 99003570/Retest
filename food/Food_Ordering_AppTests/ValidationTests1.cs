﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Food_Ordering_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Ordering_AppTests
{
    [TestClass()]
    public class ValidationTests1
    {
        [TestMethod()]
        public void CheckDeliveryFeeTest()
        {
            double value = 100;
            double actual = Validation.CheckDeliveryFee("100");
            Assert.AreEqual(value, actual);

        }
    }
}