using System;
namespace Calculator
{ 
internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter expression: ");
            string expression = Console.ReadLine();
            double result = 0;
            result = Convert.ToDouble(
                new System.Data.DataTable().Compute(expression, null));
            Console.WriteLine("Answer: " + result);
            Console.ReadKey();
        }
    }
}