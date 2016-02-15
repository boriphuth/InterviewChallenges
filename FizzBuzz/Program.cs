using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
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
