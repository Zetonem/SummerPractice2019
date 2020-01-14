using System;

namespace SummerPractice2019.Lecture4
{
    public class Task28
    {
        private String[] Clothes = new[]
        {
            "футболку", "джемпер", "кепку", "джинсы", "шорты"
        };
        public void Run()
        {
            Console.WriteLine("Вы можете одеть:");
            for (Int32 i = 0; i < Clothes.Length; i++)
                Console.WriteLine(Clothes[i]);

            Console.Write("Введите температуру на улице: ");
            Int32 temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 31)
                Console.WriteLine("одеваем шорты и кепку");
            else if (temp >= 30)
                Console.WriteLine("одеваем футболку, шорты и кепку");
            else if (temp >= 27)
                Console.WriteLine("одеваем футболку и шорты");
            else if (temp >= 25)
                Console.WriteLine("одеваем футболку и джинсы");
            else if (temp >= 20)
                Console.WriteLine("одеваем футболку, джемпер и джинсы.");
            else
                Console.WriteLine("сидим дома (удачи нам попробовать выйти на улицу в Питере…)");
        }
    }
}