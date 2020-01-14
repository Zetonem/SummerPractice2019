using System;

namespace SummerPractice2019.Lecture4
{
    public sealed class Task19
    {
        public static Int32 FindDif(Int32[] array)
        {
            if (array[0] == array[1])
                return 3;
            if (array[0] == array[2])
                return 2;
            if (array[1] == array[2])
                return 1;

            return -1;
        }

        public void Run()
        {
            Console.WriteLine("Введите 3 числа так, чтобы 2 были одинаковыми, а одно отличное от них.");
            Int32[] array = new int[3];
            Console.Write("Введите число: ");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            array[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Среди чисел {array[0]}, {array[1]} и {array[2]} отличным числом является число в {FindDif(array)} позиции.");
        }
    }
}