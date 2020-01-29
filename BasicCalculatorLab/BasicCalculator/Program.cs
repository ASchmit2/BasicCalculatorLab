using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR***");

            Console.WriteLine("Enter current temperature.");
            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter relative humidity.");
            int humid = int.Parse(Console.ReadLine());
            decimal dewpoint = temp - (9 * (100 - humid) / 25);
            
            Console.WriteLine("The dewpoint is " + dewpoint);

            Console.WriteLine("Enter current wind speed.");
            int windspeed = int.Parse(Console.ReadLine());

            double windchill = 35.74 + (.6215 * temp) - 35.75 * Math.Pow(windspeed,.16) + .4275 * temp * Math.Pow(windspeed,.16);

            Console.WriteLine("The windchill is " + windchill);
        }
    }
}
