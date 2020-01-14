using System;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task01
    {
        public Int32 Run()
        {
            Int32 a = 5;
            Int32 b = 7, c = 10;
            Int32 d = 82;
            Int32 e = 17;

            // Count sum of variables
            Int32 sum = a + b + c + d + e;

            // Output sum of variables
            Console.WriteLine($"Сумма всех значений равна: {sum}");

            return sum;
        }
    }
}