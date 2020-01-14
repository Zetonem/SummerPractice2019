using System;

namespace SummerPractice2019.Lecture3
{
    internal sealed class Task12
    {
        private const Int32 _count = 3;

        private static void TriplePrinter()
        {
            for (Int32 i = 0; i < _count; i++)
                Console.WriteLine("Просто не значит не правильно!");
        }

        public void Run()
        {
            Task12.TriplePrinter();
        }
    }
}