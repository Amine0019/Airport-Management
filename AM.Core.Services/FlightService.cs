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
        
        // returns a list of flight dates for a given destination
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

        // returns a list of flight dates for a given destination using LINQ query syntax
        public IList<DateTime> GetFlightDatesLNQ(string destination)
        {
            return (from flight in Flights
                    where flight.Destination == destination
                    select flight.FlightDate).ToList();
        }

        // returns a list of flights based on a filter type and value
        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    return Flights.Where(f => f.Destination == filterValue).ToList();
                case "Departure":
                    return Flights.Where(f => f.Departure == filterValue).ToList();
                case "FlightDate":
                    if(DateTime.TryParse(filterValue, out DateTime date))
                    {
                        return Flights.Where(f => f.FlightDate.Date == date.Date).ToList();
                    }
                    break;
                case "FlightId ":
                    if(int.TryParse(filterValue, out int flightId))
                    {
                        return Flights.Where(f => f.FlightId == flightId).ToList();
                    }
                    break;

                case "EffectiveArrival":
                    if(DateTime.TryParse(filterValue, out DateTime effectiveArrival))
                    {
                        return Flights.Where(f => f.EffectiveArrival.Date == effectiveArrival.Date).ToList();
                    }
                    break;

                case "EstimatedDuration":
                    if(int.TryParse(filterValue, out int estimatedDuration))
                    {
                        return Flights.Where(f => f.EstimatedDuration == estimatedDuration).ToList();
                    }
                    break;


            }
            return new List<Flight>();

        }

        // returns a list of flights sorted by estimated duration in descending order
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration).ToList();
        }
    }
}
