using Xunit;
using System;
using PrimeNumberSelector;
namespace PrimeNumberSelector.Tests
{
    public class PrimeNumberTest
    {
        [Fact]
        public void TestPrimeInput()
        {
            var primeNumberTest1 = new PrimeNumberList(-1000, 2);
            var primeNumberTest2 = new PrimeNumberList(-1000, -100);
            var primeNumberTest3 = new PrimeNumberList(-1000, 10);

            var primNumberTest1List = primeNumberTest1.PrimeNumbers;
            var primNumberTest2List = primeNumberTest2.PrimeNumbers;
            var primNumberTest3List = primeNumberTest3.PrimeNumbers;

            Assert.Single(primNumberTest1List);
            Assert.Empty(primNumberTest2List);
            Assert.Equal(4, primNumberTest3List.Count);
        }

        [Fact]
        public void TestPrimeResult()
        {
            var resultList1 = Program.CalculateTargetPrimeNumbers(1, 1000);
            long[] expectList1 = {863, 811, 563, 313, 123334444567};
            var resultList2 = Program.CalculateTargetPrimeNumbers(1, 10);
            long[] expectList2 = { 0, 0, 0, 0, 0 };
            Assert.Equal(expectList1, resultList1);
            Assert.Equal(expectList2, resultList2);
        }
    }
}