using System;

namespace SummerPractice2019.Lecture3
{
    public sealed class Task16
    {
        public static String Twice(String str)
        {
            String res = str + " " + str;

            Console.WriteLine(res);

            return res;
        }

        public void Run()
        {
            Console.Write("Введите строку: ");
            Task16.Twice(Console.ReadLine());
        }
    }
}