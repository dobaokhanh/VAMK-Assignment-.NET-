using Assignment1._2.DAO;
using Assignment1._2.Entity;
using Assignment1._2.Services;
using Assignment1._2.Util;
using System;
using System.Collections.Generic;

namespace Assignment1._2.Program
{
    class Program
    {
        private static List<Flight> listOfFlight = FlightDAO.getFlightDAO();
        private static List<Customer> listOfCustomer = CustomerDAO.getCustomerDAO();
        static void Main(string[] args)
        {
            String choice;
            CustomerService _customerService = new CustomerService();
            FlightService _flightService = new FlightService();
            do
            {
                Console.WriteLine("------------------------MENU---------------------");
                Console.WriteLine("1. Create flights \n" +
                                  "2. Create customers \n" +
                                  "3. Add customers to flight \n" +
                                  "4. Book flight for customer \n" +
                                  "5. Search flight \n" +
                                  "6. Search customer \n" +
                                  "7. Get all flight informations \n" +
                                  "8. Get all customer information \n" +
                                  "9. Exit ");
                choice = Console.ReadLine();
                choice.Trim();
                switch (choice)
                {
                    case Constants.CREATE_FLIGHT:
                        _flightService.GetFlightInfo(listOfFlight);
                        break;
                    case Constants.CREATE_CUSTOMER:
                        _customerService.GetCustomerInfo(listOfCustomer);
                        break;
                    case Constants.ADD_CUSTOMER:
                        _flightService.AddCustomer(listOfFlight);
                        break;
                    case Constants.ADD_FLIGHT:
                        _customerService.AddFlight(listOfCustomer);
                        break;
                    case Constants.SEARCH_FLIGHT:
                        _flightService.SearchFlight(listOfFlight);
                        break;
                    case Constants.SEARCH_CUSTOMER:
                        _customerService.SearchCustomer(listOfCustomer);
                        break;
                    case Constants.GET_ALL_FLIGHT:
                        _flightService.PrintFlight(listOfFlight);
                        break;
                    case Constants.GET_ALL_CUSTOMER:
                        _customerService.PrintCustomers(listOfCustomer);
                        break;
                    default:
                        choice = Constants.EXIT;
                        break;
                }
            } while (!choice.Equals(Constants.EXIT));
        }
    }
}
