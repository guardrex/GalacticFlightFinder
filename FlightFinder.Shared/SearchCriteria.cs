using System;

namespace FlightFinder.Shared
{
    public class SearchCriteria
    {
        public string FromSpaceportCode { get; set; }
        public string ToSpaceportCode { get; set; }
        public DateTime OutboundDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public TicketClass TicketClass { get; set; }

        public SearchCriteria(string fromSpaceportCode, string toSpaceportCode)
        {
            FromSpaceportCode = fromSpaceportCode;
            ToSpaceportCode = toSpaceportCode;
            OutboundDate = DateTime.Now.Date;
            ReturnDate = OutboundDate.AddDays(7);
        }
    }
}
