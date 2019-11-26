using Assignment2_1.Entity;
using System;
using System.Collections;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable concerts = new Hashtable();
            concerts.Add("The Nights", new Concert("The Nights", "Helsinki", "20/11/2019", "8.30 pm", 25));
            concerts.Add("Tomorrow Land", new Concert("Tomorrow Land", "Brussel", "1/1/2020", "9.30 am", 100));
            concerts.Add("Alter Bridge", new Concert("Alter Bridge", "Espoo", "20/1/2020", "8.00 pm", 20));
            concerts.Add("Homeless", new Concert("Homeless", "Vaasa", "12/12/2019", "8.00 pm", 5));
            concerts.Add("Souless", new Concert("Souless", "Stockholm", "11/11/2019", "8.00 pm", 40));
            Console.WriteLine("----------------List Of Concert----------------------");

            foreach (string key in concerts.Keys)
            {
                Console.WriteLine(concerts[key].ToString());
            }

            Concert theNights = (Concert)concerts["The Nights"];
            Concert souless = (Concert)concerts["Souless"];

            Console.WriteLine("-----------Test functionality of operators ----------------");
            Console.WriteLine("--------------------Operator: < --------------------");

            Console.WriteLine(theNights.Title + " < " + souless.Title + " ? " + (theNights < souless));

            Console.WriteLine("--------------------Operator: ++ --------------------");
            Console.WriteLine("New price of " + theNights.Title + " is: " + theNights++.Price);

            Console.WriteLine("--------------------Operator: -- --------------------");
            Console.WriteLine("New price of " + souless.Title + " is: " + souless--.Price);

        }
    }
}
