namespace BridgeLibrary
{ 
    public class Car
    {
        /// <summary>
        /// En Car klasse, med 2 properties: LicensePlate og Date
        /// </summary>
        public string LicensePlate { get; }
        public DateTime Date { get; }

        /// <summary>
        /// En contructor der sætter LicensePlate og Date
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// En metode der returnerer prisen for en bil der bruger broen
        /// </summary>
        /// <returns>Den returnere 250 Kr</returns>
        public double Price()
        {
            return 250;
        }
        
        /// <summary>
        /// En metode der returnere typen af køretøj som Car
        /// </summary>
        /// <returns>Returnere en string Car</returns>
        public string VehicleType()
        {
            return "Car";  
        }



    }
}
