using System;

namespace Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0) 
            {
                Console.WriteLine("Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadKey();
        }
    }
}
