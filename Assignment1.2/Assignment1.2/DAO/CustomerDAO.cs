using Assignment1._2.Entity;
using System.Collections.Generic;

namespace Assignment1._2.DAO
{
    class CustomerDAO
    {
        private static List<Customer> customerDAO = new List<Customer>();

        public static List<Customer> getCustomerDAO() {
            return customerDAO;
        }

        public static void setCustomerDAO(List<Customer> _customerDAO)
        {
            customerDAO = _customerDAO;
        }
    }
}
