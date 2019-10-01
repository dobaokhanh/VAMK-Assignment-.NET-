using System.Collections.Generic;

namespace Assignment1._2.Util
{
    class Validator
    {

        private static readonly List<string> customerIdList = new List<string>();
        private static readonly List<string> flightIdList = new List<string>();
        private const string DATE_FORMAT_REGEX = "";
        /// <summary>
        /// Check the existence of customer Id
        /// If customer id is not existed, add new id to customerId list
        /// </summary>
        /// <param name="_customerId"></param>
        /// <returns>false if the customer id is not existed, otherwise throw return true </returns>
        public static bool IsCustomerIdExisted(string _customerId)
        {
            if (!customerIdList.Contains(_customerId))
            {
                customerIdList.Add(_customerId);
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// check the existence of flight id
        /// Id flight id is not existed, add new id to flight id list
        /// </summary>
        /// <param name="_flightId"></param>
        /// <returns>false if the flight id is not existed, otherwise return true</returns>
        public static bool IsFlightIdExisted(string _flightId)
        {
            if (!flightIdList.Contains(_flightId))
            {
                flightIdList.Add(_flightId);
                return false;
            }
            else
                return true;
        }
    }
}
