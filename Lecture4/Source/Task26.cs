using System;

namespace SummerPractice2019.Lecture4
{
    public class Task26
    {
        public void Run()
        {
            Console.Write("Введите строку: ");
            String str = Console.ReadLine().ToUpper();

            for (Int32 i = 0; i < 7; i++)
                Console.WriteLine(str);
        }
    }
}