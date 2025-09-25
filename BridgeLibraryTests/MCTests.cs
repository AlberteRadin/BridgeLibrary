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

        [TestMethod()]
        public void licensePlateTooLongMC()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var mc = new MC("fg356987", DateTime.Now); // 8 characters
            });
        }

        [TestMethod()]
        public void licensePlateCorrectLengthMC()
        {
            var mc = new MC("ABC1234", DateTime.Now); // 7 characters
            Assert.AreEqual("ABC1234", mc.LicensePlate);
        }
    }
}