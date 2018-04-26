using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlightFinder.Shared;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FlightSearchController
    {
        public async Task<IEnumerable<Itinerary>> Search([FromBody] SearchCriteria criteria)
        {
            await Task.Delay(500);

            if (criteria.FromSpaceportCode == criteria.ToSpaceportCode)
            {
                return null;
            }

            var rng = new Random();
            var outboundDepartureDT = criteria.OutboundDate.AddHours(rng.Next(24)).AddMinutes(5 * rng.Next(12));
            var inboundDepartureDT = criteria.ReturnDate.AddHours(rng.Next(24)).AddMinutes(5 * rng.Next(12));
            var fromSpaceportItem = SampleData.Spaceports.FirstOrDefault(s => s.Code == criteria.FromSpaceportCode);
            var toSpaceportItem = SampleData.Spaceports.FirstOrDefault(s => s.Code == criteria.ToSpaceportCode);
            var fromSpaceport = fromSpaceportItem.DisplayName;
            var toSpaceport = toSpaceportItem.DisplayName;
            var earthToEarthTrip = fromSpaceportItem.IsEarthSpaceport && toSpaceportItem.IsEarthSpaceport;

            return Enumerable.Range(0, rng.Next(1, 5)).Select(_ => new Itinerary
            {
                Price = rng.Next(100, 2000),
                Outbound = new FlightSegment
                {
                    Spaceline = RandomSpaceline(),
                    FromSpaceport = fromSpaceport,
                    FromSpaceportCode = criteria.FromSpaceportCode,
                    ToSpaceport = toSpaceport,
                    ToSpaceportCode = criteria.ToSpaceportCode,
                    DepartureTime = outboundDepartureDT,
                    DurationHours = earthToEarthTrip ? 0.1 + rng.NextDouble() : rng.Next(10, 100) + rng.NextDouble(),
                    TicketClass = criteria.TicketClass
                },
                Return = new FlightSegment
                {
                    Spaceline = RandomSpaceline(),
                    FromSpaceport = fromSpaceport,
                    FromSpaceportCode = criteria.ToSpaceportCode,
                    ToSpaceport = toSpaceport,
                    ToSpaceportCode = criteria.FromSpaceportCode,
                    DepartureTime = inboundDepartureDT,
                    DurationHours = earthToEarthTrip ? 0.1 + rng.NextDouble() : rng.Next(10, 100) + rng.NextDouble(),
                    TicketClass = criteria.TicketClass
                },
            });
        }

        private string RandomSpaceline()
            => SampleData.Spacelines[new Random().Next(SampleData.Spacelines.Length)];
    }
}
