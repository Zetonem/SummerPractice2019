using System;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task15
    {
        public static Int32 Square(Int32 x)
        {
            return x * x;
        }

        public void Run()
        {
            Console.Write("Введите число: ");

            Int32 x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Square of {x} is {x * x}.");
        }
    }
}