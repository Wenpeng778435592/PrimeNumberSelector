using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSelector
{
    class PrimeNumberList
    {
        public int MinNumber;
        public int MaxNumber;
        public List<int> PrimeNumbers;
        public bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var ceiling = Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i < ceiling; ++i)
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
