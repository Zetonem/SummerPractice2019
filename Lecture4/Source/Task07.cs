using System;

namespace SummerPractice2019.Lecture4
{
    internal sealed class Task07
    {
        private void CompareWith7(Int32 x)
        {
            if (x > 7)
                Console.WriteLine($"Число {x} больше семи.");
            else
                Console.WriteLine($"Число {x} меньше семи.");
        }

        public void Run()
        {
            CompareWith7(100);
            CompareWith7(3);
        }
    }
}