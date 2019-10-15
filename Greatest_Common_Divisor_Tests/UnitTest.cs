using Greatest_Common_Divisor;
using NUnit.Framework;

namespace Greatest_Common_Divisor_Tests
{
    public class UnitTest
    {


        [TestCase(546, 1092, 546, 2184, 4368)]
        [TestCase(1, 123213, 324234, 24324121, 43683)]
        [TestCase(3, 171, 1233, 45, 111222111)]
        [TestCase(18, 36, 18)]
        [TestCase(3, -3, -6)]
        [TestCase(11, 121, -33)]
        [TestCase(3, 3, 0, 6)]
        [TestCase(3, 0, 3, 9)]
        [TestCase(-1, 0, -1)]
        public void UTestGetGCD(int expectedResult, params int[] numbers)
        {
            int result = Program.GetGCD(numbers);
            Assert.AreEqual(expectedResult, result);
        }
    }
}