using System;
using System.Text;

namespace SummerPractice2019.Lecture4
{
    internal sealed class Human
    {
        public String Surname;
        public String Name;
        public String Patronymic;
    }

    public sealed class Task06
    {
        public static String CreateFullName(String surname, String name, String patronymic)
        {
            return new StringBuilder().Append(surname).Append(" ").Append(name).Append(" ").Append(patronymic).ToString();
        }

        public void Run()
        {
            Human human = new Human();

            Console.Write("Введите фамилию: ");
            human.Surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            human.Name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            human.Patronymic = Console.ReadLine();

            Console.WriteLine("Полное имя: " + Task06.CreateFullName(human.Surname, human.Name, human.Patronymic));
        }
    }
}