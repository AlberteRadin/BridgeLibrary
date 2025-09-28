using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLibrary;
using System.Diagnostics.CodeAnalysis;
namespace BridgeLibrary.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            var car = new Car("FB30360", DateTime.Now, false);

            double Price = car.Price();

            Assert.AreEqual(250, Price);
        }
       [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car("FB30360", DateTime.Now, false);

            string VehicleType = car.VehicleType();

            Assert.AreEqual("Car", VehicleType);
        }

        [TestMethod()]
        public void licensePlateTooLongCar()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var car = new Car("fg356987", DateTime.Now, true); // 8 characters
            });
        }

        [TestMethod()]
        public void licensePlateCorrectLengthCar()
        {
            var car = new Car("ABC1234", DateTime.Now, true); // 7 characters
            Assert.AreEqual("ABC1234", car.LicensePlate);
        }

        [TestMethod()]
        public void Price_WithBrobizz_Gives10PercentDiscount()
        {
            var car = new Car("FB30360", DateTime.Now, true);
            double price = car.Price();
            Assert.AreEqual(225, price); // 250 * 0.9 = 225
        }

        [TestMethod()]
        public void Price_WithoutBrobizz_NoDiscount()
        {
            var car = new Car("FB30360", DateTime.Now, false);
            double price = car.Price();
            Assert.AreEqual(250, price);
        }
    }
    
}