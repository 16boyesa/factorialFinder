using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to factorial finder 2022");

            Console.WriteLine("Please enter a number to be calculated recursively");
            Console.WriteLine(RecursiveFactorial(int.Parse(Console.ReadLine())));

            Console.ReadLine();

        }

        private static int RecursiveFactorial(int n)
        {
            if (n == 2)
            {
                return 2;
            }
            return n * RecursiveFactorial(n-1);
        }
    }
}
