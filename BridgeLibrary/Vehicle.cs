using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary
{
    public class Vehicle
    {
        public string LicensePlate { get; }
        public DateTime Date { get; }

        public Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// En metode der returnerer prisen for en bil der bruger broen
        /// </summary>
        /// <returns>Den returnere 250 Kr</returns>
        public virtual double Price()
        {
            return 0;
        }

        /// <summary>
        /// En metode der returnere typen af køretøj som Car
        /// </summary>
        /// <returns>Returnere en string Car</returns>
        public virtual string VehicleType()
        {
            return "";
        }
    }
}
