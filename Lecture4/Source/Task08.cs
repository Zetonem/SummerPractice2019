using System;

namespace SummerPractice2019.Lecture4
{
    internal sealed class Task08
    {
        public static void Compare(Int32 x)
        {
            if (x > 0)
                Console.WriteLine("Число положительное");
            else if (x < 0)
                Console.WriteLine("Число отрицательное");
            else
                Console.WriteLine("Введен 0!!!");
        }

        public void Run()
        {
            Task08.Compare(10);
            Task08.Compare(-10);
            Task08.Compare(0);
        }
    }
}