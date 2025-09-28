namespace BridgeLibrary
{ 
    public class Car : Vehicle
    {
        /// <summary>
        /// Kalder på Vehicle contructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        public Car(string licensePlate, DateTime date, bool brobizz)
            : base(licensePlate, date, brobizz)
        {
        }


        /// <summary>
        /// overrider Price metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Den returnere 250 Kr</returns>
        public override double Price()
        {
            double basePrice = 250;
            if (Brobizz)
                return basePrice * 0.9;
            return basePrice;
        }

        /// <summary>
        /// overrider VehicleType metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Returnere en string Car</returns>
        public override string VehicleType()
        {
            return "Car";  
        }



    }
}
