using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSelector
{
    public class PrimeNumberList
    {
        public int MinNumber;
        public int MaxNumber;
        public List<int> PrimeNumbers;
        public PrimeNumberList(int MinNumber, int MaxNumber)
        {
            this.MinNumber = MinNumber;
            this.MaxNumber = MaxNumber;
            this.PrimeNumbers = FindPrimeNumber(MinNumber, MaxNumber);
        }
        public bool isinputValid(int maxNumber, int minNumber) 
            // test if input is valid
        {
            bool validInput = false;
            if (maxNumber > 0 && maxNumber >= minNumber)
            {
                validInput = true;
            }
            else
            {
                validInput = false;
                Console.WriteLine("Invalid range.");
            }
            return validInput;
        }
        public List<int> FindPrimeNumber(int minNumber, int maxNumber)
        {
            var PrimeNumbers = new List<int>();
            if (minNumber < 1 && maxNumber > 0) 
                //numbers less than 1 will be ignored
            {
                minNumber = 1;
            }
            if (isinputValid(maxNumber, minNumber))
            {
                for (int i = minNumber; i <= maxNumber; i++) 
                    // find prime number within range
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
            //the factor of a composite number can be at max the square root of it
            for (int i = 2; i <= ceiling; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
