using System;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task14
    {
        public static Int32 Multiply(Int32 a, Int32 b, Int32 c)
        {
            return a * b * c;
        }

        public void Run()
        {
            Random rnd = new Random(30);

            Int32 a = rnd.Next(10), b = rnd.Next(10), c = rnd.Next(10);
            Console.WriteLine($"{a} * {b} * {c} = {Task14.Multiply(a, b, c)}");
        }
    }
}