namespace UnitTesting
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class NUnitExample
    {
        public Calculator _calc;

        [SetUp]
        public void SetUpInit()
        {
            _calc = new Calculator();
        }

        [TestCase(10, 7, ExpectedResult = 17)]
        public double AddExampleTest(double a, double b)
        {
            return _calc.Add(a, b);
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void SimpleExampleTestCase(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        [Test, Sequential]
        public void TestDivisionBy2(
            [Values(10, 25, 40)] int input,
            [Values(5, 12, 20)] int expectedOutput)
        {
            Assert.AreEqual(expectedOutput, input / 2);
        }

        [Test]
        public void RandomTest([Random(5)] double x)
        {
            Console.WriteLine("X = " + x);
        }

        [Test]
        public void AbsTest()
        {
            var number = 11.9;
            var result = 12;

            var actual = _calc.Abs(number);

            Assert.AreEqual(actual, result);
        }

        [TestCase(0,  ExpectedResult = 1)]
        public double CosTest(int a)
        {
            return _calc.Cos(a);
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void DivideTest(int dividend, int divider, int quotient)
        {
            var actual = _calc.Divide(dividend, divider);

            Assert.AreEqual(quotient ,actual);
        }

        [Test, Sequential]
        public void Pow2Test(
            [Values(10, 2, 5, 1)] double input,
            [Values(100, 4, 25, 1)] double expectedOutput)
        {
            double two = 2;

            var actual = _calc.Pow(input, two);

            Assert.AreEqual(expectedOutput, input);
        }

        [Test]
        public void SqrtTest()
        {
            Assert.AreEqual(2, _calc.Sqrt(4));
        }

        [Test]
        public void SubTest()
        {
            Assert.AreEqual(3, _calc.Sub(4, 1));
        }

        [Test]
        public void IsNegativeTest()
        {
            Assert.True( _calc.isNegative(-1));
        }

        [Test]
        public void IsPositiveTest()
        {
            Assert.False(_calc.isPositive(-1));
        }
    }
}

