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
    public class StoreBæltRepositoryTests
    {
        [TestMethod()]
        public void AddTicket_StoresTicket()
        {
            // Arrange
            var repo = new StoreBæltRepository();
            var ticket = new Storebælt("ABC1234", DateTime.Now, false);

            // Act
            repo.AddTicket(ticket);
            var allTickets = repo.GetAllTickets();

            // Assert
            Assert.IsTrue(allTickets.Any(t => t.LicensePlate == "ABC1234"));
        }

        [TestMethod()]
        public void GetAllTickets_ReturnsAllTickets()
        {
            // Arrange
            var repo = new StoreBæltRepository();
            var ticket1 = new Storebælt("PLATE1", DateTime.Now, false);
            var ticket2 = new Storebælt("PLATE2", DateTime.Now, true);

            // Act
            repo.AddTicket(ticket1);
            repo.AddTicket(ticket2);
            var allTickets = repo.GetAllTickets();

            // Assert
            Assert.IsTrue(allTickets.Any(t => t.LicensePlate == "PLATE1"));
            Assert.IsTrue(allTickets.Any(t => t.LicensePlate == "PLATE2"));
        }

            [TestMethod()]
        public void GetTicketsByLicensePlate_ReturnsCorrectTickets()
        {
            // Arrange
            var repo = new StoreBæltRepository();
            var ticket1 = new Storebælt("SAMEP", DateTime.Now, false);
            var ticket2 = new Storebælt("SAMEP", DateTime.Now.AddDays(1), true);
            var ticket3 = new Storebælt("DIFFP", DateTime.Now, false);

            // Act
            repo.AddTicket(ticket1);
            repo.AddTicket(ticket2);
            repo.AddTicket(ticket3);
            var filtered = repo.GetTicketsByLicensePlate("SAMEP");

            // Assert
            Assert.AreEqual(2, filtered.Count);
            Assert.IsTrue(filtered.All(t => t.LicensePlate == "SAMEP"));
        }
    }
}