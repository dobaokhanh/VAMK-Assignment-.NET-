using Assignment1._2.Entity;
using Assignment1._2.Util;
using System;
using System.Collections.Generic;

namespace Assignment1._2.Services
{
    class CustomerService
    {
        /// <summary>
        /// Get the customer information from user
        /// </summary>
        /// <param name="_customerList"></param>
        public void GetCustomerInfo(List<Customer> _customerList)
        {
            Customer _customer = new Customer();
            String _customerName, _customerId;
            String _loopCustomerInfo;
            do
            {
                do
                {
                    Console.WriteLine("Enter the customer id: ");
                    _customerId = Console.ReadLine();
                    if (!Validator.IsCustomerIdExisted(_customerId))
                        _customer.Id = _customerId;
                    else
                    {
                        Console.WriteLine("Customer id has already existed !");
                        continue;
                    }
                    break;
                } while (true);

                Console.WriteLine("Enter the customer name: ");
                _customerName = Console.ReadLine();
                _customer.Name = _customerName;
                _customerList.Add(_customer);
                Console.WriteLine("Add customer succeed! ");
                Console.WriteLine("Do you want to continue entering customer (Y/N):  ");
                _loopCustomerInfo = Console.ReadLine();
            } while (_loopCustomerInfo[0] == 'Y' || _loopCustomerInfo[0] == 'y');
        }

        /// <summary>
        /// Add flight to flight id collection in customer object
        /// </summary>
        /// <param name="_customerList"></param>
        public void AddFlight(List<Customer> _customerList)
        {
            String _loopFlightId = "";
            String _flightId, _customerId;
            Customer _customer = new Customer();
            do
            {
                Console.WriteLine("Enter the customer id: ");
                _customerId = Console.ReadLine();
                if (!Validator.IsCustomerIdExisted(_customerId))
                {
                    Console.WriteLine("Customer id is not existed! Please enter again. ");
                    continue;
                }
                break;
            } while (true);

            foreach(Customer c in _customerList)
            {
                if(c.Id.Equals(_customerId))
                {
                    _customer = c;
                    break;
                }
            }
                
            do
            {
                Console.WriteLine("Enter the flight id: ");
                _flightId = Console.ReadLine();
                if (!Validator.IsFlightIdExisted(_flightId))
                {
                    Console.WriteLine("This flight id is not existed ! Please enter again.");
                    continue;
                }
                _customer.FlightId.Add(_flightId);
                Console.WriteLine("Add succeed !");
                Console.WriteLine("Do you want to continue entering flight id (Y/N): ");
                _loopFlightId = Console.ReadLine();
            } while (_loopFlightId[0] == 'Y' || _loopFlightId[0] == 'y');

        }

        /// <summary>
        /// Search customer by id
        /// </summary>
        /// <param name="_customerId"></param>
        /// <param name="_customerList"></param>
        public void SearchCustomer(List<Customer> _customerList)
        {
            String _customerId;
            do
            {
                Console.WriteLine("Enter the customer id: ");
                _customerId = Console.ReadLine();
                if(!Validator.IsCustomerIdExisted(_customerId))
                {
                    Console.WriteLine("This customer id is not existed !");
                    continue;
                }
                break;
            } while (true);
            foreach (Customer c in _customerList)
            {
                if (c.Id.Equals(_customerId))
                {
                    Console.WriteLine(c.ToString());
                    break;
                }
            }
            
        }

        /// <summary>
        /// Print all all information of list of customers
        /// </summary>
        /// <param name="_customer"></param>
        public void PrintCustomers(List<Customer> _customerList)
        {
            foreach (var c in _customerList)
                Console.WriteLine(c.ToString());
        }
    }
}
