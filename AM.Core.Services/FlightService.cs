using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    //link the class to the interface through inheritance
    public class FlightService: IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
           IList<DateTime> flightDates = new List<DateTime>();
              foreach (var flight in Flights)
              {
                if (flight.Destination == destination)
                {
                    flightDates.Add(flight.FlightDate);
                }
              }
              return flightDates;
        }
    }
}
