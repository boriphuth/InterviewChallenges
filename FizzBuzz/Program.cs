using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    //Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
    //For numbers which are multiples of both three and five print “FizzBuzz”.
    class Program
    {
        static void Main(string[] args)
        {
            for (var iCounter = 1; iCounter <= 100; iCounter++)
            {
                if (iCounter % 3 == 0 && iCounter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (iCounter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (iCounter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(iCounter);
                }
            }

        }
    }
}
