public class Route
    {
        public int RouteId { get; set; }
        public required string Source { get; set; }
 
        public  required string Destination { get; set; }
        public int Distance {get; set; }
        public required int Duration { get; set; }
 
       
 
    }