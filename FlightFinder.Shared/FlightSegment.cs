using System;

namespace FlightFinder.Shared
{
    public class FlightSegment
    {
        public string Spaceline { get; set; }
        public string FromSpaceport { get; set; }
        public string FromSpaceportCode { get; set; }
        public string ToSpaceport { get; set; }
        public string ToSpaceportCode { get; set; }
        public DateTime DepartureTime { get; set; }
        public double DurationHours { get; set; }
        public TicketClass TicketClass { get; set; }
    }
}
