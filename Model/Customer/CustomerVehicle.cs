public class CustomerVehicle
    {
       
        public DateTime JourneyDate { get; set; }
 
        public  required string Source { get; set; }
        public required string Destination {get; set; }
        public required string VehicleName { get; set; }
 
    }