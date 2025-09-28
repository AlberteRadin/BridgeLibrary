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
            var mc = new MC("ET75938", DateTime.Now, false);

            double Price = mc.Price();

            Assert.AreEqual(120, Price);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new MC("ET75938", DateTime.Now, false);

            string VehicleType = mc.VehicleType();

            Assert.AreEqual("MC", VehicleType);
        }

        [TestMethod()]
        public void licensePlateTooLongMC()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var mc = new MC("fg356987", DateTime.Now, true); // 8 characters
            });
        }

        [TestMethod()]
        public void licensePlateCorrectLengthMC()
        {
            var mc = new MC("ABC1234", DateTime.Now, true); // 7 characters
            Assert.AreEqual("ABC1234", mc.LicensePlate);
        }

        [TestMethod()]
        public void Price_WithBrobizz_Gives10PercentDiscount()
        {
            var mc = new MC("MC12345", DateTime.Now, true);
            double price = mc.Price();
            Assert.AreEqual(108, price); // 120 * 0.9 = 108
        }

        [TestMethod()]
        public void Price_WithoutBrobizz_NoDiscount()
        {
            var mc = new MC("MC12345", DateTime.Now, false);
            double price = mc.Price();
            Assert.AreEqual(120, price);
        }
    }
}