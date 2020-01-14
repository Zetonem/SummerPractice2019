using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task13
    {
        public void Run()
        {
            Console.Write("Введите строку: ");
            String a = Console.ReadLine();
            Console.Write("Введите строку: ");
            String b = Console.ReadLine();
            Console.Write("Введите строку: ");
            String c = Console.ReadLine();

            if (a.Equals(b) && a.Equals(c))
                Console.WriteLine($"{a}, {b}, {c}");
            else if (a.Equals(b))
                Console.WriteLine($"{a} {b}");
            else if (a.Equals(c))
                Console.WriteLine($"{a} {c}");
            else if (b.Equals(c))
                Console.WriteLine($"{b} {c}");
            else
                Console.WriteLine("Все разные");
        }
    }
}