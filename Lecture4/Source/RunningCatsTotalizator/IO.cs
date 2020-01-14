using System;

namespace SummerPractice2019.Lecture4.RunningCatsTotalizator
{
    // Input-output class for race manage
    internal static class SRaceIO
    {
        private static Single Version = 1.0F;   // Current program version
        private const String Agreement = "да"; // Agreement to start race
        private const String Denial = "нет";   // Denial to start race

        /* Start menu control function.
        * ARGUMENTS: None.
        * RETURNS: None.
        */
        public static void StartMenu()
        {
            Console.WriteLine("Добро пожаловать в \"Симулятор кошачьих бегов версии\" {0:#.#}!", Version);
            Console.WriteLine($"Правила очень просты: у нас есть {Cat.s_CatsCount} котов," +
                                     " участвующих в забеге!");
            Console.WriteLine("Каждый из котов имеет свой уникальный номер. Вам нужно угадать кто" +
                                     "прибежит к финишу первым.");
            Console.WriteLine("Для этого достаточно просто ввести его номер с клавиатуры и узнать" +
                                     "угадали или нет!");

            Boolean IsExit = false; // Menu exit status

            while (!IsExit)
            {
                Console.WriteLine($"Хотите сыграть? (введите \"{Agreement}\" чтобы сыграть или \"{Denial}\"," +
                                         " чтобы завершить игру)");
                String Answer = Console.ReadLine().ToLower();

                switch (Answer)
                {
                    case Agreement:
                        Race race = new Race();
                        Console.WriteLine("Спортсмены готовы! Нажмите любую клавишу чтобы начать забег!");
                        Console.ReadKey();
                        race.Run();
                        break;
                    case Denial:
                        IsExit = true;

                        Console.Clear();
                        Console.WriteLine("Очень жаль! До встречи!");
                        break;
                    default:
                        Console.WriteLine("Вы ввели что-то не то! Давайте еще раз...");
                        break;
                }
            }
        } // End of 'StartMenu' function
    } // End of 'SRaceIO' class
} // end of 'SummerPractice2019.Lecture4.RunningCatsTotalizator' namespace

// END OF 'IO.cs' FILE
