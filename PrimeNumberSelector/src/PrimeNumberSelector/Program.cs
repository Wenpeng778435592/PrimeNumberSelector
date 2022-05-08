using System;

namespace PrimeNumberSelector.PrimeNumberSelector
{
    public class Program
    {
        private static void Main()
        {
            var resultList = CalculateTargetPrimeNumbers(1, 1000);
            Console.WriteLine($"result is {resultList}");
        }

        public static long[] CalculateTargetPrimeNumbers(int minNumber, int maxNumber)
            //defined return type for unit testing
        {
            //defined as long instead of var to hold 12 digits
            long num1 = 0;
            long num2 = 0;
            long num3 = 0;
            long num4 = 0;
            var primeList = new PrimeNumberList(minNumber, maxNumber);
            var primeResultList = primeList.PrimeNumbers;
            // find prime numbers and store them in a list
            for (var i = (primeResultList.Count - 1); i > 2; i--)
            // start from the product of big prime numbers
            {
                for (var j = i - 1; j > 1; j--)
                {
                    for (var k = j - 1; k > 0; k--)
                    {
                        for (var l = k - 1; l >= 0; l--)
                        {
                            var product = (long)primeResultList[i] * (long)primeResultList[j] * (long)primeResultList[k] * (long)primeResultList[l];
                            var productString = product.ToString();
                            if (productString.Length <= 11)
                            //dispose the small prime number loop if 11 digits or less
                            {
                                break;
                            }

                            if (productString.Length != 12) continue;
                            var minNum = '0';
                            var productChar = productString.ToCharArray();
                            for (var m = 0; m < productChar.Length; m++)
                            {
                                if (minNum == '0')
                                    //for first digit
                                {
                                    minNum = productChar[m];
                                }
                                else if (productChar[m] == minNum || (productChar[m] - minNum == 1))
                                    // for following digits
                                    //test if the digits are sequential ascending or same as previous one
                                {
                                    minNum = productChar[m];
                                    if (m != productChar.Length - 1) continue;
                                    num1 = primeResultList[i];
                                    num2 = primeResultList[j];
                                    num3 = primeResultList[k];
                                    num4 = primeResultList[l];
                                    goto Found;
                                    //goto is used here since there is only 1 valid product

                                }
                                else
                                {
                                    break;
                                    // if not in sequential ascending order, break
                                }

                            }
                        }
                    }
                }
            }
            Found:
            Console.WriteLine(num1 == 0
                ? "No result."
                : $"The product is {num1 * num2 * num3 * num4}," +
                  $" and the prime numbers are {num1}, {num2}, {num3}, {num4}");
            long[] resultList = {num1, num2, num3, num4, num1 * num2 * num3 * num4 };
            return resultList;
        }
    }
}
