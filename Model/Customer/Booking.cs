public class Booking
    {
       
        public DateTime JourneyDate { get; set; }
 
        public  required string Source { get; set; }
        public int Destination {get; set; }
        public required string BoardingPoint { get; set; }
        public required string DropPoint { get; set; }
        public required string NumberOfPassenger { get; set; }
        public required string BookingStatus { get; set; }
       
 
    }