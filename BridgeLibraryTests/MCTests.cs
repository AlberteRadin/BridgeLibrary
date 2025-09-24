using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            var mc = new MC("ET75938", DateTime.Now);

            double Price = mc.Price();

            Assert.AreEqual(120, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new MC("ET75938", DateTime.Now);

            string VehicleType = mc.VehicleType();

            Assert.AreEqual("MC", VehicleType);
        }
    }
}