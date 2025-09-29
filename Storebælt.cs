using BridgeLibrary;
namespace StorebæltTicketLibrary
{
    public class Storebælt : Vehicle
    {
        public Storebælt(string licensePlate, DateTime date, bool brobizz)
          : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 230;

            // Apply weekend discount
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% discount on weekends
            }

            if (Brobizz)
                return basePrice * 0.9;
           
            return basePrice;
        }


    }
}
