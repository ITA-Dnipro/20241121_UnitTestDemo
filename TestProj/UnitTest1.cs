using _20241121_UnitTestDemo;

namespace TestProj
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void SumPositiveNumbersTestMethod()
        {
            Calculator c1 = new Calculator();
            int arg1 = 10;
            int arg2 = 131;
            int expected = 141;

            int actualResult = c1.GetSum(arg1, arg2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void SumNegativeNumbersTestMethod()
        {
            Calculator c1 = new Calculator();
            int arg1 = -10;
            int arg2 = -11;
            int expected = -21;

            int actualResult = c1.GetSum(arg1, arg2);

            Assert.AreEqual(expected, actualResult);
        }
    }
}