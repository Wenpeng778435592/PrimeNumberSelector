using System;
using PrimeNumberSelector.PrimeNumberSelector;
using Xunit;

namespace PrimeNumberSelector.test.PrimeNumberSelector.Tests
{
    public class PrimeNumberTest
    {
        [Fact]
        public void TestIsInputValid()
        {
            var primeNumberList1 = new PrimeNumberList(-1000, 2);
            var primeNumberList2 = new PrimeNumberList(-1000, -100);
            var primeNumberList3 = new PrimeNumberList(-1000, 10);
            var primeNumberList4 = new PrimeNumberList(2, 2);

            var inputValid1 = primeNumberList1.IsInputValid();
            var inputValid2 = primeNumberList2.IsInputValid();
            var inputValid3 = primeNumberList3.IsInputValid();
            var inputValid4 = primeNumberList4.IsInputValid();

            Assert.True(inputValid1);
            Assert.True(!inputValid2);
            Assert.True(inputValid3);
            Assert.True(inputValid4);
        }

        [Fact]
        public void TestTransformMinInput()
        {
            var primeNumberList1 = new PrimeNumberList(-1000, 2);
            var primeNumberList2 = new PrimeNumberList(2, 150);

            var minInput1 = primeNumberList1.TransformMinInput();
            var minInput2 = primeNumberList2.TransformMinInput();

            Assert.Equal(1, minInput1);
            Assert.Equal(2, minInput2);
        }

        [Fact]
        public void TestIsPrime()
        {
            var primeNumberList1 = new PrimeNumberList(2, 2);
            var rnd = new Random();
            var num1 = rnd.Next(1, 1001);
            var num2 = rnd.Next(1, 1001);

            var testNum = num1 * num2;
            var testResult = primeNumberList1.IsPrime(testNum);

            Assert.True(!testResult);
        }

        [Fact]
        public void TestFindPrimeNumber()
        {
            var primeNumberList1 = new PrimeNumberList(-100, 2);
            var primeNumberList2 = new PrimeNumberList(2, 10);
            var primeNumberList3 = new PrimeNumberList(-1000, -10);
            var primeNumberList4 = new PrimeNumberList(20, 25);

            var primeNumberActualResult1 = primeNumberList1.FindPrimeNumber();
            var primeNumberActualResult2 = primeNumberList2.FindPrimeNumber();
            var primeNumberActualResult3 = primeNumberList3.FindPrimeNumber();
            var primeNumberActualResult4 = primeNumberList4.FindPrimeNumber();

            int[] primeNumberExpectedResult1 = {2};
            int[] primeNumberExpectedResult2 = {2, 3, 5, 7, };
            int[] primeNumberExpectedResult3 = { };
            int[] primeNumberExpectedResult4 = {23};

            Assert.Equal(primeNumberExpectedResult1, primeNumberActualResult1);
            Assert.Equal(primeNumberExpectedResult2, primeNumberActualResult2);
            Assert.Equal(primeNumberExpectedResult3, primeNumberActualResult3);
            Assert.Equal(primeNumberExpectedResult4, primeNumberActualResult4);
        }

        [Fact]
        public void TestCalculateTargetPrimeNumber()
        {
            var resultList1 = Program.CalculateTargetPrimeNumbers(1, 1000);
            long[] expectList1 = {863, 811, 563, 313, 123334444567};
            var resultList2 = Program.CalculateTargetPrimeNumbers(1, 10);
            long[] expectList2 = {0, 0, 0, 0, 0 };
            Assert.Equal(expectList1, resultList1);
            Assert.Equal(expectList2, resultList2);
        }
    }
}