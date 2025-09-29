using BridgeLibrary;
namespace OresundBroenLibrary
{
    public class OresundCar : Vehicle
    {
        public OresundCar(string licensePlate, DateTime date, bool brobizz)
           : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 460;
            if (Brobizz)
            {
                return 178;
            }
            else
            {
                return basePrice;
            }
              
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }

    }
}
