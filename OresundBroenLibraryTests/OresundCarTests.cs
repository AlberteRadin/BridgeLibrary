using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBroenLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBroenLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
      
            [TestMethod()]
            public void Price_WithoutBrobizz_ReturnsStandardPrice()
            {
                var car = new OresundCar("AB12345", DateTime.Now, false);
                Assert.AreEqual(460, car.Price()); // Replace 410 with the actual standard price
            }

            [TestMethod()]
            public void Price_WithBrobizz_ReturnsDiscountedPrice()
            {
                var car = new OresundCar("AB12345", DateTime.Now, true);
                Assert.AreEqual(178, car.Price()); // Replace 161 with the actual Brobizz price
            }

            [TestMethod()]
            public void VehicleType_ReturnsOresundCar()
            {
                var car = new OresundCar("AB12345", DateTime.Now, false);
                Assert.AreEqual("Oresund Car", car.VehicleType()); // Adjust string if needed
            }
    }
}