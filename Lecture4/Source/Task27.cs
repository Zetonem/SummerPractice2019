using System;

namespace SummerPractice2019.Lecture4
{
    public class Task27
    {
        public void Run()
        {
            Console.Write("Введите строку: ");
            String str = Console.ReadLine().ToLower();

            for (Int32 i = 0; i < 5; i++)
                Console.WriteLine(str);
        }
    }
}