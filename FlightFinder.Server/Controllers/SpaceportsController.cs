using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class SpaceportsController : Controller
    {
        public IEnumerable<Spaceport> Spaceports()
        {
            return SampleData.Spaceports;
        }
    }
}
