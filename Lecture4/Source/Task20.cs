using System;

namespace SummerPractice2019.Lecture4
{
    internal sealed class Task20
    {
        internal static void PosAndNeg(Int32 a, Int32 b, Int32 c, Int32 d)
        {
            Int32[] array = new[] {a, b, c, d};
            Int32 posCount = 0;
            Int32 negCount = 0;

            for (Int32 i = 0; i < 4; i++)
                if (array[i] > 0)
                    posCount++;
                else if (array[i] < 0)
                    negCount++;

            Console.WriteLine($"Количество положительных чисел: {posCount}");
            Console.WriteLine($"Количество отрицательных чисел: {negCount}");
        }
        public void Run()
        {
            PosAndNeg(0, 2, 3, 4);
            PosAndNeg(0, -2, -3, 4);
        }
    }
}