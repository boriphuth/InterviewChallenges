using System;

namespace EvenlyDivisibleBy
{
    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
    //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 12?
    class Program
    {
        static void Main(string[] args)
        {

            long lastIteration = 12;

            var smallestDivisibleNumber = FindSmallestDivisibleNumber(lastIteration);
            Console.WriteLine(smallestDivisibleNumber);
            Console.ReadKey();
        }

        public static long FindSmallestDivisibleNumber(long last)
        {
            long smallestSoFar = 1;
            bool allTrue = false;
            while (!allTrue)
            {
                allTrue = true;
                for (var iIteration = last; iIteration >= 1; iIteration--)
                {
                    while (smallestSoFar % iIteration != 0)
                    {
                        smallestSoFar++;
                        allTrue = false;
                    }
                }
            }

            return smallestSoFar;
        }
    }
}
