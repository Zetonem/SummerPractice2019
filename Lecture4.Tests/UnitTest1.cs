using System;
using NUnit.Framework;

namespace SummerPractice2019.Lecture4.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3)]
        public void Task05CatsCount(Int32 catsCount)
        {
            Cat[] cats = new Cat[catsCount];

            for (Int32 i = 0; i < catsCount; i++)
                cats[i] = new Cat();

            for (Int32 i = 0; i < catsCount; i++)
                cats[i].AddCat();

            Assert.AreEqual(catsCount, Cat.InstancesCount);
        }

        [TestCase("Зайцев", "Леонид", "Алексеевич", "Зайцев Леонид Алексеевич")]
        public void Task06FullName(String surname, String name, String patronymic, String answer)
        {
            String res = Task06.CreateFullName(surname, name, patronymic);

            Assert.AreEqual(answer, res);
        }

        [TestCase(30)]
        [TestCase(59)]
        [TestCase(71)]
        public void Task09IsInInterval(Int32 x)
        {
            Assert.IsTrue(Task09.IsBetween30And100(x));
        }

        [TestCase(1)]
        [TestCase(29)]
        [TestCase(125)]
        public void Task09IsNotInInterval(Int32 x)
        {
            Assert.IsFalse(Task09.IsBetween30And100(x));
        }

        [TestCase(100, 700)]
        [TestCase(-17, -10)]
        [TestCase(0, 0)]
        public void Task10TransformNumber(Int32 x, Int32 answer)
        {
            Int32 res = Task10.TransformNumber(x);

            Assert.AreEqual(answer, res);
        }

        [TestCase(999999999)]
        public void Task10TransformNumberOverflow(Int32 x)
        {
            Assert.Throws<OverflowException>(() => Task10.TransformNumber(x));
        }

        [TestCase(1900, false)]
        [TestCase(2000, true)]
        [TestCase(1992, true)]
        public void Task11IsLeapYear(Int32 year, Boolean answer)
        {
            Boolean res = Task11.IsLeapYear(year);

            Assert.AreEqual(answer, res);
        }

        [TestCase(10, 2, 3, false)]
        [TestCase(1, 2, 3, false)]
        [TestCase(3, 4, 5, true)]
        public void Task12IsTriangleExist(Int32 a, Int32 b, Int32 c, Boolean answer)
        {
            Boolean res = Task12.IsTriangleExist(a, b, c);

            Assert.AreEqual(answer, res);
        }

        [TestCase(3, 4, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-100, 100, -100)]
        public void Task14Minimum(Int32 a, Int32 b, Int32 answer)
        {
            Int32 res = Task14.Minimum(a, b);

            Assert.AreEqual(answer, res);
        }

        [TestCase(5, 4, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-100, 100, 100)]
        public void Task15Maximum(Int32 a, Int32 b, Int32 answer)
        {
            Int32 res = Task15.Maximum(a, b);

            Assert.AreEqual(answer, res);
        }

        [TestCase(3, 4, 5, 5)]
        [TestCase(0, -2, -1, 0)]
        [TestCase(-100, 101, 100, 101)]
        public void Task16MaximumOf3(Int32 a, Int32 b, Int32 c, Int32 answer)
        {
            Int32 res = Task16.MaximumOf3(a, b, c);

            Assert.AreEqual(answer, res);
        }

        [TestCase(3, 4, 5, -1, -1)]
        [TestCase(0, 0, -1, 0, -1)]
        [TestCase(-100, 101, 100, 10, -100)]
        public void Task17MinimumOf4(Int32 a, Int32 b, Int32 c, Int32 d, Int32 answer)
        {
            Int32 res = Task17.MinimumOf4(a, b, c, d);

            Assert.AreEqual(answer, res);
        }

        [TestCase(3, 4, 5, new Int32[]{5, 4, 3})]
        [TestCase(0, 0, -1, new Int32[]{0, 0, -1})]
        [TestCase(-100, 101, 100, new Int32[]{101, 100, -100})]
        [TestCase(-8, 11, 0, new Int32[]{11, 0, -8})]
        public void Task18Sort3(Int32 a, Int32 b, Int32 c, Int32[] answer)
        {
            Int32[] res = Task18.Sort3(a, b, c);

            for (Int32 i = 0; i < 3; i++)
                Assert.AreEqual(answer[i], res[i]);
        }
    }
}