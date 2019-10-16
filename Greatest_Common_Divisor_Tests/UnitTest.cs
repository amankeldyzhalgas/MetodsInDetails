using Greatest_Common_Divisor;
using NUnit.Framework;

namespace Greatest_Common_Divisor_Tests
{
    public class UnitTest
    {
        [TestCase( 1092, 546, 2184, 4368, ExpectedResult = 546)]
        [TestCase( 123213, 324234, 24324121, 43683, ExpectedResult =1)]
        [TestCase( 171, 1233, 45, 111222111, ExpectedResult =3)]
        [TestCase( 36, 18, ExpectedResult =18)]
        [TestCase( -3, -6, ExpectedResult =3)]
        [TestCase( 121, -33, ExpectedResult =11)]
        [TestCase( 3, 0, 6, ExpectedResult =3)]
        [TestCase( 0, 3, 9, ExpectedResult =3)]
        [TestCase( 0, -1, ExpectedResult =-1)]
        [TestCase(4, -4, 12, -2, ExpectedResult =2)]
        public int UTestFindGCDEuclid(params int[] numbers)
        {
            return Program.FindGCDEuclid(numbers);
        }

        [TestCase(1092, 546, 2184, 4368, ExpectedResult = 546)]
        [TestCase(123213, 324234, 24324121, 43683, ExpectedResult = 1)]
        [TestCase(171, 1233, 45, 111222111, ExpectedResult = 3)]
        [TestCase(36, 18, ExpectedResult = 18)]
        [TestCase(-3, -6, ExpectedResult = 3)]
        [TestCase(121, -33, ExpectedResult = 11)]
        [TestCase(3, 0, 6, ExpectedResult = 3)]
        [TestCase(0, 3, 9, ExpectedResult = 3)]
        [TestCase(0, -1, ExpectedResult = -1)]
        [TestCase(4, -4, 12, -2, ExpectedResult = 2)]
        public int UTestFindGCDStein(params int[] numbers)
        {
            return Program.FindGCDStein(numbers);
        }
    }
}