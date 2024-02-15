namespace Backend.Model.Administator
{
    public class Vehicle
    {
        public int VehicleNo {get;set;}

        public required string VehicleName { get; set; }

        public required int SeatingCapacity { get; set; }
        public int DriverId { get; set; }
        public required string VehicleType { get; set; }
        public required int  FarePerKm { get; set; }
       

    }
}