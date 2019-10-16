using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boolean_Extended;

namespace Boolean_Extended_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void MSTest_NotNullString()
        {
            string name = "Kathy";
            bool expectedResult = false;
            bool result = name.isNull();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTest_NullString()
        {
            string name = null;
            bool expectedResult = true;
            bool result = name.isNull();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MSTest_NullInt()
        {
            int? i = null;
            bool expectedResult = true;
            bool result = i.isNull();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
