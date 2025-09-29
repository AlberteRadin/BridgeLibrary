using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorebæltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorebæltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebæltTests
    {
        [TestMethod()]
        public void Price_Weekday_NoDiscount()
        {
            var ticket = new Storebælt("AB12345", new DateTime(2025, 9, 29), false); // Monday
            Assert.AreEqual(250, ticket.Price());
        }

        [TestMethod()]
        public void Price_Weekend_DiscountOnly()
        {
            var ticket = new Storebælt("AB12345", new DateTime(2025, 10, 4), false); // Saturday
            Assert.AreEqual(212.5, ticket.Price());
        }

        [TestMethod()]
        public void Price_Weekday_BrobizzOnly()
        {
            var ticket = new Storebælt("AB12345", new DateTime(2025, 9, 29), true); // Monday
            Assert.AreEqual(225, ticket.Price());
        }

        [TestMethod()]
        public void Price_Weekend_And_Brobizz_BothDiscounts()
        {
            var ticket = new Storebælt("AB12345", new DateTime(2025, 10, 5), true); // Sunday
            Assert.AreEqual(191.25, ticket.Price());
        }
    }
}