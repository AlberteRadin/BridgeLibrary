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
    public class OresundMcTests
    {
        [TestMethod()]
        public void Price_WithoutBrobizz_ReturnsStandardPrice()
        {
            var mc = new OresundMc("MC12345", DateTime.Now, false);
            Assert.AreEqual(235, mc.Price()); // Replace 210 with the actual standard price
        }

        [TestMethod()]
        public void Price_WithBrobizz_ReturnsDiscountedPrice()
        {
            var mc = new OresundMc("MC12345", DateTime.Now, true);
            Assert.AreEqual(92, mc.Price()); // Replace 73 with the actual Brobizz price
        }

        [TestMethod()]
        public void VehicleType_ReturnsOresundMc()
        {
            var mc = new OresundMc("MC12345", DateTime.Now, false);
            Assert.AreEqual("Oresund MC", mc.VehicleType()); // Adjust string if needed
        }
    }
}