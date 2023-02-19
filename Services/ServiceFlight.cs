using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // 6)
        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;

            // 7)
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                }

            }
            return dates;
        }

        // 8)
        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> flights = new List<Flight>();
            
            if (filterType.Equals("Destination"))
            {

                foreach (var flight in Flights)
                {
                    if (flight.Destination.Equals(filterValue)) 
                    {
                        flights.Add(flight);
                        Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

                    }
                }
                    
            }
            if (filterType.Equals("PlaneType"))
            {

                foreach (var flight in Flights)
                {
                    if (flight.plane.PlaneType.Equals(filterValue))
                    {
                        flights.Add(flight);
                        Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

                    }
                }

            }
            if (filterType.Equals("PlaneType"))
            {

                foreach (var flight in Flights)
                {
                    if (flight.plane.PlaneType.Equals(filterValue))
                    {
                        flights.Add(flight);
                        Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

                    }
                }

            }
            if (filterType.Equals("FlightDate"))
            {

                foreach (var flight in Flights)
                {
                    if (flight.FlightDate.Equals(filterValue))
                    {
                        flights.Add(flight);
                        Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);
                    }
                }

            }
            if (filterType.Equals("EffectiveArrival"))
            {

                foreach (var flight in Flights)
                {
                    if (flight.EffectiveArrival.Equals(filterValue))
                    {
                        flights.Add(flight);
                        Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}" ,flight.FlightDate, flight.Destination, flight.EffectiveArrival,flight.plane.PlaneType,flight.EstimateDuration,flight.passengers);

                    }
                }

            }
        }
        // 9 )
        void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.plane.PlaneId == plane.PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        // 11)

        int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = Flights
                .Count(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7);
            return query;
        }

        // 12)
        Double DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimateDuration);
            return query;
        }

        // 13)
        List<Flight> OrderedDurationFlights()
        {
            //var query = Flights
            //    .OrderByDescending(f => f.EstimateDuration).ToList();

            //Syntax de requet
            var query = from f in Flights
                        orderby f.EstimateDuration descending
                        select (f);

            return query.ToList();
        }

        // 14)
        List<Traveller> SeniorTravellers(Flight flight)
        {
            var query = flight.passengers.OfType<Traveller>()
                    //.Where(p => p is Traveller)   // bech yraja3li liste passenger , donc nbadeloha list traveller
                    .OrderBy(p => p.BirthDate).Take(3).ToList();

            List<Passenger> p = new List<Passenger>(query);   // cast implicite  ( ken bech n5aliw e return List Passenger )
            return query;
        }

        // 15)
        void DestinationGroupedFlights()
        {
            var query = Flights
                .GroupBy(f => f.Destination).ToList();
            foreach (var f in query)
            {
                Console.WriteLine("Destination : " + f.Key);
                foreach (var g in f)
                {
                    Console.WriteLine(g.FlightDate);
                }
            }
        }

        /*----------------[Expressions Lambda / Les méthodes LINQ prédéfinies]------------------*/
        // 16)

        delegate void FlightDetailsDel(Plane plane);

        // Define a lambda expression that takes a Plane object and prints its details
        FlightDetailsDel printDetails = (plane) =>
        {
            Console.WriteLine("Plane details:");
            Console.WriteLine("ID: {0}", plane.PlaneId);
            Console.WriteLine("Capacity: {0}", plane.Capacity);
            Console.WriteLine("Manufacture Date: {0}", plane.ManufactureDate);
            Console.WriteLine("Plane Type: {0}", plane.PlaneType);
        };



        delegate float DurationAverageDel(string destination);

        DurationAverageDel getAverageDuration = (destination) =>
        {
            float totalDuration = 0;
            int count = 0;
            List<Flight> flights = new List<Flight>();

            foreach (Flight flight in flights)
            {
                if (flight.Destination == destination)
                {
                    totalDuration += flight.EstimateDuration;
                    count++;
                }
            }

            if (count > 0)
            {
                return totalDuration / count;
            }
            else
            {
                return 0;
            }
        };

        // 17) 

        private FlightDetailsDel showFlightDetails;
        private DurationAverageDel durationAverage;

        public void GetFlightDetails(Plane plane)
        {
            // Call the ShowFlightDetails delegate to print the details of a Plane object
            showFlightDetails(plane);
        }

        public void GetDurationAverage(string destination)
        {
            // Call the DurationAverage delegate to calculate the average duration of flights to a given destination
            double averageDuration = durationAverage(destination);
            Console.WriteLine($"Average duration to {destination}: {averageDuration}");
        }


        // 18) 

        //    public ServiceFlight()
        //    {
        //        showFlightDetails = plane => {
        //            var query = Flights
        //                .Where(f => f.plane.PlaneId == plane.PlaneId)
        //                .Select(f => new { f.Destination, f.FlightDate });

        //            foreach (var item in query)
        //            {
        //                Console.WriteLine(item);
        //            }
        //        };


        //        durationAverage = destination => {
        //            var query = Flights
        //                .Where(f => f.Destination.Equals(destination))
        //                .Average(f => f.EstimateDuration);
        //            return query;
        //        };

        //    // ...
        //}

        // 19)
        public ServiceFlight()
        {
            // Assign the ShowFlightDetails delegate to an anonymous method that prints the flight details of a given plane
            showFlightDetails = plane => {
                var query = from flight in Flights
                            where flight.plane.PlaneId == plane.PlaneId
                            select new { flight.Destination, flight.FlightDate };

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            };

            // Assign the DurationAverage delegate to an anonymous method that calculates the average duration of flights to a given destination
            durationAverage = destination => {
                var query = from flight in Flights
                            where flight.Destination.Equals(destination)
                            select flight.EstimateDuration;

                double averageDuration = query.Average();
                return (float)averageDuration;
            };
        }



    }
}
