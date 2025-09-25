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
        public MC(string licensePlate, DateTime date)
            : base(licensePlate, date)
        {
        }


        /// <summary>
        /// Overrider Price metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Den returnere 120Kr</returns>
        public override double Price()
        {
            return 120;
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
