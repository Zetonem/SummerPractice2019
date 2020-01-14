using System;
using NUnit.Framework;

namespace SummerPractice2019.Lecture6.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3, 10, 10, 34, 25)]
        [TestCase(-9, -3, -6,-7, 5)]
        [TestCase(1, 1, 1, 1, 0)]
        public void Test01Distance(Double x1, Double y1, Double x2, Double y2, Double answer)
        {
            Double res = Task01.DistanceBetweenTwoPoints(x1, y1, x2, y2);

            Assert.AreEqual(answer, res);
        }

        [Test]
        public void Test02CatsCount()
        {
            for (Int32 i = 0; i < 500; i++)
                new CatTask02();

            Assert.AreEqual(500, CatTask02.CatsCount);
        }

        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -3, -4)]
        public void Test03CalculatorSum2Numbers(Int32 x, Int32 y, Int32 answer)
        {
            Int32 res = Calculator.Sum(x, y);

            Assert.AreEqual(answer, res);
        }

        [TestCase(1, 2, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -3, 2)]
        public void Test03CalculatorSubstraction(Int32 x, Int32 y, Int32 answer)
        {
            Int32 res = Calculator.Substraction(x, y);

            Assert.AreEqual(answer, res);
        }

        [TestCase(1, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, 6)]
        public void Test03CalculatorMult(Int32 x, Int32 y, Int32 answer)
        {
            Int32 res = Calculator.Multiplication(x, y);

            Assert.AreEqual(answer, res);
        }

        [TestCase(0)]
        [TestCase(1, 1)]
        [TestCase(0, 1, 2, 3, -6)]
        [TestCase(15, 1, 2, 3, 4, 5)]
        public void Test03CalculatorSum(Int32 answer, params Int32[] numbers)
        {
            Int32 res = Calculator.Sum(numbers);

            Assert.AreEqual(answer, res);
        }
    }
}