using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary
{
    public class MC : Vehicle
    {

        /// <summary>
        /// Kalder på Vehicle contructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        public MC(string licensePlate, DateTime date, bool brobizz)
            : base(licensePlate, date, brobizz)
        {
        }


        /// <summary>
        /// Overrider Price metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Den returnere 120Kr</returns>
        public override double Price()
        {
            double basePrice = 120;
            if (Brobizz)
                return basePrice * 0.9;
            return basePrice;
        }

        /// <summary>
        /// overrider VehicleType metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Returnere en string MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
