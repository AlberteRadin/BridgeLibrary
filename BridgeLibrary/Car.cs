namespace BridgeLibrary
{ 
    public class Car : Vehicle
    {
        /// <summary>
        /// Kalder på Vehicle contructor
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date)
            : base(licensePlate, date)
        {
        }


        /// <summary>
        /// overrider Price metoden fra Vehicle klassen
        /// </summary>
        /// <returns>Den returnere 250 Kr</returns>
        public override double Price()
        {
            return 250;
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
