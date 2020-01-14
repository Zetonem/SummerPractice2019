using System;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task17
    {
        public static String Add(String str)
        {
            Console.WriteLine(str);

            return str + str + str;
        }

        public void Run()
        {
            Console.Write("Введите строку: ");
            Task17.Add(Console.ReadLine());
        }
    }
}