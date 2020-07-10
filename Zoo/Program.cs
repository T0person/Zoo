using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell cell = new Cell();

            while (true)
            {
                Console.WriteLine("\nВыбирай:");
                Console.WriteLine("1. Добавить быка");
                Console.WriteLine("2. Добавить корову");
                Console.WriteLine("3. Посмотреть всех животных");
                Console.WriteLine("4. Удалить животное");
                Console.WriteLine("5. Выйти из программы\n");


                if (Int32.TryParse(Console.ReadLine(), out int temp) && temp < 6 && temp > 0)
                {
                    switch (temp)
                    {
                        case 1:
                            Ram ram = new Ram(NewAnimal(), Output());
                            Animal animalR = ram;
                            cell.AddAnimal(animalR);
                            break;
                        case 2:
                            Cow cow = new Cow(NewAnimal(), Output());
                            Animal animalC = cow;
                            cell.AddAnimal(animalC);
                            break;
                        case 3:
                            cell.GetAnimal();
                            break;
                        case 4:
                            cell.RemoveAnimal(new Ram(NewAnimal()));
                            break;
                        case 5:
                            Environment.Exit(15);
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine("\n\nНе правильный ввод!!!\n Нужно ввести цифру от 1 до 5!\n\n");
            }
        }

        static string NewAnimal()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Назовите животного\n");
                string name = Console.ReadLine();
                if (!Int32.TryParse(name, out int not_name))
                    return name;
                else
                    Console.WriteLine("\nИмя не может быть цифрой!\n\n");
            }
        }

        static bool Output()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Куда будет выводиться звук? 1 / 0 (фаил / консоль) соответственно\n");
                if (Int32.TryParse(Console.ReadLine(), out int num) && num < 2 && num > -1)
                {
                    switch (num)
                    {
                        case 1:
                            return true;
                        case 0:
                            return false;
                    }
                }
                else
                    Console.WriteLine("\n\nНе правильный ввод!!!\n Нужно ввести цифру от 0 до 1!\n\n");
            }
        }
    }
}
