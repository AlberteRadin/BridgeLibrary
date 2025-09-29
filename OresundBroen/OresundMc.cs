using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLibrary;
namespace OresundBroenLibrary
{
    public class OresundMc : Vehicle
    {
        public OresundMc(string licensePlate, DateTime date, bool brobizz)
           : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 235;
            if (Brobizz)
            {
                return 92;
            }
            else
            {
                return basePrice;
            }
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }

    }
}
