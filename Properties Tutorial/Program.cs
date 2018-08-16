using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Doing the Properties Turorial

namespace Properties_Tutorial
{
    class TimePeriod
    {
        private int days;
        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                days = value;
            }
        }
        
        public int Weeks
        {
            get
            {
                return days / 7;
            }
            set
            {
                days = value * 7;
            }
        }
        private int months;

        public int Months
        {
            get
            {
                return years / 12;
            }

        }
        private int years;
        public int Years
        {
            get
            {
                return years;
            }

            set
            {
                years = value * 365;
            }
        }
        



    }

   

    public class Currency 
    {
        private float aud;

        public float Aus
        {
            get
            {
                return aud;
            }
            set
            {
                aud = value;
            }
        }
        public float USD
        {
            get
            {
                return aud * 0.73f;
            }
            set
            {
                aud = value / 0.73f;
            }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {

            Currency dollar = new Currency();
            Console.Write("Enter value in AUD: $");
            dollar.Aus = float.Parse(Console.ReadLine());
        

            Console.WriteLine("Value in USD: $" + dollar.USD.ToString("n2"));
            Console.ReadLine();
            Console.Write("Enter value in USD: $");
            dollar.USD = float.Parse(Console.ReadLine());
            Console.WriteLine("Value in AUD: $" + dollar.Aus.ToString("n2"));

            //
            /*          TimePeriod time = new TimePeriod();
                        Console.WriteLine("Enter a number of days: ");
                        time.Days = int.Parse(Console.ReadLine());
                        Console.WriteLine("That many days is: ");
                        Console.WriteLine("Weeks: " + time.Weeks);
                        Console.WriteLine("Months: " + time.Months);
                        Console.WriteLine("Years: " + time.Years);
            */

            Console.ReadLine();
        }
    }
}

// Check https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties