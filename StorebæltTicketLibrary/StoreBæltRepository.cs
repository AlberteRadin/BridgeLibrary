using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorebæltTicketLibrary
{
    public class StoreBæltRepository : IStorebæltRepository
    {
        /// <summary>
        /// Represents a collection of tickets associated with Storebælt.
        /// </summary>
        /// <remarks>This field is a static, read-only list that holds ticket information for Storebælt.
        /// It is initialized as an empty list and cannot be reassigned.</remarks>
        private static readonly List<Storebælt> _tickets = new();

        public void AddTicket(Storebælt ticket)
        {
            if (ticket == null) throw new ArgumentNullException(nameof(ticket));
            _tickets.Add(ticket);
        }

        public List<Storebælt> GetAllTickets()
        {
            return new List<Storebælt>(_tickets);
        }

        public List<Storebælt> GetTicketsByLicensePlate(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate)) return new List<Storebælt>();
            return _tickets.Where(t => t.LicensePlate.Equals(licensePlate, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
