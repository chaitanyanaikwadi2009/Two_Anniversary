public class AdminBooking
    {
       
        public int VehicleId { get; set; }
 
        public  required DateTime BookingDate { get; set; }
        public DateTime JourneyDate {get; set; }
        public required string BoardingPoint { get; set; }
        public required string DropPoint { get; set; }
        public required int ContactNo { get; set; }
        public required int Fare { get; set; }
       
 
    }