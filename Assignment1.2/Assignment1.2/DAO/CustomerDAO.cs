using Assignment1._2.Entity;
using System.Collections.Generic;
using System;

namespace Assignment1._2.DAO
{
    class CustomerDAO
    {
        private static List<Customer> customerDAO = new List<Customer>();

        public static List<Customer> GetCustomerDAO() {
            return customerDAO;
        }

        public static void SetCustomerDAO(List<Customer> _customerDAO)
        {
            customerDAO = _customerDAO;
        }

        public static Customer GetCustomerById(string id)
        {
            Customer customerFound = new Customer();
            foreach (Customer cus in customerDAO)
            {
                if (cus.Id.Equals(id))
                {
                    customerFound = cus;
                    break;
                }
                    
            }
            return customerFound;
        }
    }
}
