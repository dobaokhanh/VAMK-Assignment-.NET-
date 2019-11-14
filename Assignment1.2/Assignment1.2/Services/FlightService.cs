using Assignment1._2.DAO;
using Assignment1._2.Entity;
using Assignment1._2.Util;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Assignment1._2.Services
{
    class FlightService
    {
        /// <summary>
        /// Get flight information from user
        /// </summary>
        /// <param name="_flightList"></param>
        public void GetFlightInfo(List<Flight> _flightList)
        {
            Flight _flight;
            String _flightId, _origin, _destination, _date;
            String _loopFlight;
            DateTime _isDate;
            do 
            {
                _flight = new Flight();
                 do
                 {
                    Console.WriteLine("Enter the flight id: ");
                    _flightId = Console.ReadLine();
                    if (!Validator.IsFlightIdExisted(_flightId))
                        _flight.Id = _flightId;
                    else
                    {
                        Console.WriteLine("The flight id is existed! Please enter again");
                        continue;
                    }
                    break;
                 } while (true);

                Console.WriteLine("Enter the origin: ");
                _origin = Console.ReadLine();
                _flight.Origin = _origin;
                Console.WriteLine("Enter the destination: ");
                _destination = Console.ReadLine();
                _flight.Destination = _destination;
                do
                {
                    Console.WriteLine("Enter the date (dd/mm/yyyy): ");
                    _date = Console.ReadLine();
                    if(!DateTime.TryParseExact(_date, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _isDate))
                    {
                        Console.WriteLine("Please enter the correct format of date! ");
                        continue;
                    }
                    break;
                } while (true);
                _flight.Date = _isDate;
                _flightList.Add(_flight);
                Console.WriteLine("Add flight succeed !");
                Console.WriteLine("Do you want to continue entering flight (Y/N): ");
                _loopFlight = Console.ReadLine();
            } while (_loopFlight[0] == 'Y' || _loopFlight[0] == 'y');
        }

        /// <summary>
        /// Add customer id to customer id collection of flight
        /// </summary>
        /// <param name="_flightList"></param>
        public void AddCustomer(List<Flight> _flightList)
        {
            Flight _flight = new Flight();
            String _flightId, _customerId, _loopCustomer = "N";
            do
            {
                Console.WriteLine("Enter the flight id: ");
                _flightId = Console.ReadLine();
                if (!Validator.IsFlightIdExisted(_flightId))
                {
                    Console.WriteLine("The flight id is not existed ! Please enter again");
                    continue;
                }
                break;
            } while (true);
            
            foreach(Flight f in _flightList)
            {
                if(f.Id.Equals(_flightId)) {
                    _flight = f;
                    break;
                }
            }

            do
            {
                Console.WriteLine("Enter the customer id: ");
                _customerId = Console.ReadLine();
                if (!Validator.IsCustomerIdExisted(_customerId))
                {
                    Console.WriteLine("This customer id is not existed! Please enter again");
                    _loopCustomer = "Y";
                    continue;
                }
                _flight.CustomerId.Add(_customerId);
                Console.WriteLine("Add succeed !");
                Console.WriteLine("Do you want to continue entering customer id (Y/N): ");
                _loopCustomer = Console.ReadLine();
            } while (_loopCustomer[0] == 'Y' || _loopCustomer[0] == 'y');
        }

        /// <summary>
        /// Search flight information 
        /// </summary>
        /// <param name="flightId"></param>
        /// <param name="_flightList"></param>
        public void SearchFlight(List<Flight> _flightList)
        {
            String _flightId;
            do
            {
                Console.WriteLine("Enter the flight id: ");
                _flightId = Console.ReadLine();
                if (!Validator.IsFlightIdExisted(_flightId))
                {
                    Console.WriteLine("This flight id is not existed !");
                    continue;
                }
                break;
            } while (true);
            
            foreach(Flight f in _flightList)
            {
                if (f.Id.Equals(_flightId))
                {
                    Console.WriteLine(f.ToString());
                    foreach(string customerId in f.CustomerId)
                    {
                        Console.WriteLine(CustomerDAO.GetCustomerById(customerId).ToString());
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Print out all the information of flights
        /// </summary>
        /// <param name="_flightList"></param>
        public void PrintFlight(List<Flight> _flightList)
        {
            foreach (var f in _flightList)
                Console.WriteLine(f.ToString());
        }
    }
}
