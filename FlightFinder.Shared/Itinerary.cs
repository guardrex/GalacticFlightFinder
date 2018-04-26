namespace FlightFinder.Shared
{
    public class Itinerary
    {
        public FlightSegment Outbound { get; set; }
        public FlightSegment Return { get; set; }
        public decimal Price { get; set; }

        public double TotalDurationHours
            => Outbound.DurationHours + Return.DurationHours;

        public string SpacelineName => 
            (Outbound.Spaceline == Return.Spaceline) ? Outbound.Spaceline : "Multiple spacelines";
    }
}
