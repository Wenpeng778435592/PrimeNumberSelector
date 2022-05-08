using System;
using System.Collections.Generic;

namespace PrimeNumberSelector.PrimeNumberSelector
{
    public class PrimeNumberList
    {
        public int MinNumber;
        public int MaxNumber;
        public List<int> PrimeNumbers;

        public PrimeNumberList(int minNumber, int maxNumber)// ctor for shortcut
        {
            this.MinNumber = minNumber;
            this.MaxNumber = maxNumber;
            PrimeNumbers = FindPrimeNumber();
        }
        public bool IsInputValid() 
            // test if input is valid
        {
            //using ternary operators, refactored code
            Console.WriteLine(MaxNumber > 0 && MaxNumber >= MinNumber
                ? "valid input."
                : "Invalid input range.");
            return MaxNumber > 0 && MaxNumber >= MinNumber;
        }
        public List<int> FindPrimeNumber()
        {
            var primeNumber = new List<int>();
            if (!IsInputValid()) return primeNumber;
            MinNumber = TransformMinInput();
            for (var i = MinNumber; i <= MaxNumber; i++)
                // find prime number within range
            {
                if (IsPrime(i))
                {
                    primeNumber.Add(i);
                }
            }
            return primeNumber;

        }

        public int TransformMinInput()
        {
            MinNumber = MinNumber < 1 ? 1 : MinNumber;
            //numbers less than 1 will be ignored
            return MinNumber;
        }

        public bool IsPrime(int number)
        {
            switch (number)
            {
                case 1:
                    return false;
                case 2:
                    return true;
            }

            var ceiling = Math.Ceiling(Math.Sqrt(number));
            //the factor of a composite number can be at max the square root of it
            for (var i = 2; i <= ceiling; ++i)
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
