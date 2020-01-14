using System;

namespace SummerPractice2019.Lecture3
{
    internal sealed class Task13
    {
        private const Int32 _count = 3;

        private static void MirrorTriplePrinter()
        {
            Console.Write("Введите строку: ");

            String str = Console.ReadLine();

            for (Int32 i = 0; i < _count; i++)
                Console.WriteLine(str);
        }

        public void Run()
        {
            Task13.MirrorTriplePrinter();
        }
    }
}