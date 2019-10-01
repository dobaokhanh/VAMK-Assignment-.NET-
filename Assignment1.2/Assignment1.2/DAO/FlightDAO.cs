using Assignment1._2.Entity;
using System.Collections.Generic;

namespace Assignment1._2.DAO
{
    class FlightDAO
    {
        private static List<Flight> flightDAO = new List<Flight>();

        public static List<Flight> getFlightDAO()
        {
            return flightDAO;
        }

        public static void setFlightDAO(List<Flight> _flightDAO)
        {
            flightDAO = _flightDAO;
        }
    }
}
