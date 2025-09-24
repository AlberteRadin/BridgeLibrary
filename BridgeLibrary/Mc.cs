using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary
{
    public class MC
    {
        /// <summary>
        /// En MC klasse, med 2 properties: LicensePlate og Date
        /// </summary>
        public string LicensePlate { get; }
        public DateTime Date { get; }

        /// <summary>
        /// En contructor der sætter LicensePlate og Date
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public MC(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// En metode der returnerer prisen for en MC der bruger broen
        /// </summary>
        /// <returns>Den returnere 120Kr</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// En metode der returnere typen af køretøj som MC
        /// </summary>
        /// <returns>Returnere en string MC</returns>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
