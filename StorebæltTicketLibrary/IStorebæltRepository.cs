using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorebæltTicketLibrary
{
    internal interface IStorebæltRepository
    {
        void AddTicket(Storebælt ticket);
        List<Storebælt> GetAllTickets();
        List<Storebælt> GetTicketsByLicensePlate(string licensePlate);
    }
}
