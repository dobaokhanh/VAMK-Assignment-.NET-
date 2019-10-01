using System;
using System.Collections.Generic;

namespace Assignment1._2.Entity
{
    class Flight
    {
        private String id;
        private String origin;
        private String destination;
        private DateTime date;
        private List<string> customerId;
        public Flight()
        {
            CustomerId = new List<string>();
        }

        public Flight(String id, string origin, string destination, DateTime date)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
        }

        public Flight(string id, string origin, string destination, DateTime date, List<string> customerId)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
            CustomerId = customerId;
        }

        public string Id { get => id; set => id = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<string> CustomerId { get => customerId; set => customerId = value; }

        public override string ToString()
        {
            return "Id: " + Id + "\t Origin: " + Origin + "\t Destination: " + Destination + "\t Date: " + Date + "\t Customer Id: [" + string.Join((", "), CustomerId) + "] \n";
        }
    }
}
