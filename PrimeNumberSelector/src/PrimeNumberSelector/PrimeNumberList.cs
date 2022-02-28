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
            PrimeNumbers = FindPrimeNumber();
        }
        public bool IsInputValid() 
            // test if input is valid
        {
            bool validInput = false;
            if (MaxNumber > 0 && MaxNumber >= MinNumber)
            {
                validInput = true;
            }
            else
            {
                validInput = false;
                Console.WriteLine("Invalid input range.");
            }
            return validInput;
        }
        public List<int> FindPrimeNumber()
        {
            var PrimeNumbers = new List<int>();
            if (IsInputValid())
            {
                MinNumber = TransformMinInput();
                for (int i = MinNumber; i <= MaxNumber; i++)
                // find prime number within range
                {
                    if (IsPrime(i))
                    {
                        PrimeNumbers.Add(i);
                    }
                }
            }
            return PrimeNumbers;
        }

        public int TransformMinInput()
        {
            if (MinNumber < 1)
            //numbers less than 1 will be ignored
            {
                MinNumber = 1;
            }

            return MinNumber;
        }

        public bool IsPrime(int number)
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
