using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_1.Entity
{
    class Concert
    {
        private string title;
        private string location;
        private string date;
        private string time;
        private double price;

        public Concert()
        {
        }

        public Concert(string title, string location, string date, string time, double price)
        {
            Title = title;
            Location = location;
            Date = date;
            Time = time;
            Price = price;
        }

        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.Price < c2.Price)
                return true;
            return false;
        }

        public static bool operator >(Concert concert1, Concert concert2)
        {
            if (concert1.Price > concert2.Price)
                return true;
            return false;
        }

        public static Concert operator ++(Concert concert)
        {
            concert.Price += 5;
            return concert;
        }

        public static Concert operator --(Concert concert)
        {
            concert.Price -= 5;
            return concert;
        }

        public string Title { get => title; set => title = value; }
        public string Location { get => location; set => location = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return "Title: " + Title + "\t Location: " + Location + "\t Date: " + date + "\t Time: " + Time + "\t Price: " + Price + "\n";
        }
    }
}
