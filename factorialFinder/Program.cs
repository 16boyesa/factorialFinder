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

            Console.WriteLine("Please enter a number to be calculated iteratively");
            Console.WriteLine(IterativeFactorial(int.Parse(Console.ReadLine())));

            Console.ReadLine();

        }

        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n <= 2)
            {
                return n;
            }
            return n * RecursiveFactorial(n-1);
        }

        private static int IterativeFactorial(int n)
        {
            int output = 1;
            for (int i = n; i > 1; i--)
            {
                output = output * i;
            }
            return output;
        }
    }
}
