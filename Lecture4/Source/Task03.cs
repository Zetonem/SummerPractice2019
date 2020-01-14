using System;

namespace SummerPractice2019.Lecture4
{
    internal sealed class Task03
    {
        private static void UniversalPrinter(String str, Int32 count)
        {
            for (Int32 i = 0; i < count; i++)
                Console.WriteLine(str);
        }

        public void Run()
        {
            Console.Write("Введите строку: ");
            String str = Console.ReadLine();

            Console.Write("Сколько раз вывести эту строку: ");
            Int32 count = Convert.ToInt32(Console.ReadLine());

            Task03.UniversalPrinter(str, count);
        }
    }
}