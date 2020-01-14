using System;
using NUnit.Framework;

namespace SummerPractice2019.Lecture3.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Task01IsSum121()
        {
            Task01 task = new Task01();

            Int32 res = task.Run();

            Assert.AreEqual(121, res);
        }

        [Test]
        public void Task02IsMult85()
        {
            Task02 task = new Task02();

            Int32 res = task.Run();

            Assert.AreEqual(85, res);
        }

        [TestCase(1, 2, 3, 6)]
        [TestCase(0, 7, 4, 0)]
        [TestCase(5, 2, 3, 30)]
        public void Task14Mult(Int32 a, Int32 b, Int32 c, Int32 answer)
        {
            Int32 res = Task14.Multiply(a, b, c);

            Assert.AreEqual(answer, res);
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(10, 100)]
        [TestCase(5, 25)]
        public void Task15Square(Int32 x, Int32 answer)
        {
            Int32 res = Task15.Square(x);

            Assert.AreEqual(answer, res);
        }

        [TestCase(" ", "   ")]
        [TestCase("Hello", "Hello Hello")]
        [TestCase("F F", "F F F F")]
        public void Task16Twice(String str, String answer)
        {
            String res = Task16.Twice(str);

            Assert.AreEqual(answer, res);
        }

        [TestCase(" ", "   ")]
        [TestCase("Hello", "HelloHelloHello")]
        [TestCase("FF", "FFFFFF")]
        public void Task17Triple(String str, String answer)
        {
            String res = Task17.Add(str);

            Assert.AreEqual(answer, res);
        }

        [TestCase(1, 60)]
        [TestCase(2, 120)]
        [TestCase(0, 0)]
        [TestCase(152, 9120)]
        [TestCase(1000000000, -1)]
        public void Task21Triple(Int32 min, Int32 answer)
        {
            Int32 res = Task21.MinToSec(min);

            Assert.AreEqual(answer, res);
        }
    }
}
