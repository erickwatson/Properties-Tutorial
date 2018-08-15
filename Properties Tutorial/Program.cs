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
        private int days = 2;

        public int Days
        {
            get
            {
                return days;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();

            Console.WriteLine(time.Days);
            Console.ReadLine();
        }
    }

    
}
// Check https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties