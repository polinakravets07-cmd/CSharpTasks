using System;
namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter triangle height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}