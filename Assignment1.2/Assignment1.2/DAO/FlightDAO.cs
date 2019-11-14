using Assignment1._2.Entity;
using System.Collections.Generic;

namespace Assignment1._2.DAO
{
    class FlightDAO
    {
        private static List<Flight> flightDAO = new List<Flight>();

        public static List<Flight> GetFlightDAO()
        {
            return flightDAO;
        }

        public static void SetFlightDAO(List<Flight> _flightDAO)
        {
            flightDAO = _flightDAO;
        }

        public static Flight GetFlightById(string id)
        {
            Flight flightFound = new Flight();
            foreach (Flight flight in flightDAO)
            {
                if (flight.Id.Equals(id))
                {
                    flightFound = flight;
                    break;
                }

            }
            return flightFound;
        }
    }
}
