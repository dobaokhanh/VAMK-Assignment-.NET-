using System;
using System.Collections.Generic;

namespace Assignment1._2.Entity
{
    class Customer
    {
        private String name;
        private String id;
        private List<string> flightId;

        public Customer()
        {
            FlightId = new List<string>();
        }

        public Customer(String name, String id, List<string> flightId)
        {
            Name = name;
            Id = id;
            FlightId = flightId;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public List<string> FlightId { get => flightId; set => flightId = value; }

        public override string ToString()
        {
            return "Id: " + Id + "\t Name: " + Name + " \t Flight Id: [" + string.Join((", "), FlightId) + "] \n";
        }
    }
}
