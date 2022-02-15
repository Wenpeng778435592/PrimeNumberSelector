using System;
using System.Collections.Generic;

namespace PrimeNumberSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool isinputValid(int maxNumber)
        {
            bool validInput = true;
            if(maxNumber < 0)
            {
                validInput = false;
                Console.WriteLine("Invalid range.");
            }
            return validInput;
        }
        public List<int> FindPrimeNumber(int minNumber, int maxNumber)
        {
            var PrimeNumbers = new List<int>();
            if (minNumber < 1 && maxNumber > 0) //need more definition
            {
                minNumber = 1;
            }
            if (isinputValid(maxNumber))
            {
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    if (isPrime(i))
                    {
                        PrimeNumbers.Add(i);
                    }
                }
            }
            return PrimeNumbers;
        }
        public bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var ceiling = Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i < ceiling; ++i)
            {
                if (number % i ==0)
                { 
                    return false;
                }
            }
            return true;
        }
    }
}
