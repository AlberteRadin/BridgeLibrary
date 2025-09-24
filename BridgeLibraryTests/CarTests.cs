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
            var car = new Car("FB30360", DateTime.Now);

            double Price = car.Price();

            Assert.AreEqual(250, Price);
        }
       [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car("FB30360", DateTime.Now);

            string VehicleType = car.VehicleType();

            Assert.AreEqual("Car", VehicleType);
        }
    }
}