namespace UnitTesting
{
    using System;
    using CSharpCalculator;
    using NUnit.Framework;

    [TestFixture]
    public class NUnitExample
    {
        public Calculator Calc;

        [SetUp]
        public void SetUpInit()
        {
            this.Calc = new Calculator();
        }

        [TestCase(10, 7, ExpectedResult = 17)]
        public double AddExampleTest(double a, double b)
        {
            return this.Calc.Add(a, b);
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

            var actual = Calc.Abs(number);

            Assert.AreEqual(actual, result);
        }
    }
}

