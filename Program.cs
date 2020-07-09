using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Zoo
{
    class Animal : IAnimal
    {
        public string name, type, say;
        public bool output;

        public virtual void Say()
        {
            Console.WriteLine($"{type} {name}: {say}");
        }

        public string Name()
        {
            return this.name;
        }
    }

    class Ram : Animal, IAnimal, IOutput
    {

        public Ram(string name, bool output)
        {
            this.name = name;
            type = "Баран";
            say = "бе-е-е-е";
            this.output = output;
        }

        public void FileOutput(StreamWriter f)
        {
            f.WriteLine($"{type} {name}: {say}");
        }
    }

    class Cow : Animal, IAnimal, IOutput
    {
        public Cow(string name, bool output)
        {
            this.name = name;
            type = "Корова";
            say = "му-у-у-у";
            this.output = output;
        }
        public void FileOutput(StreamWriter f)
        {
            f.WriteLine($"{type} {name}: {say}, {output}");
        }
    }

    interface IAnimal
    {
        void Say();
    }

    interface IOutput
    {
        void FileOutput(StreamWriter f);
    }

    class Cell
    {
        
        private List<IAnimal> Animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }

        public void RemoveAnimal(IAnimal animal)
        {
            foreach (var item in Animals)
            {
                if (((Animal)animal).name == ((Animal)item).name)
                {
                    Animals.Remove(item);
                    break;
                }
            }
        }

        public void GetAnimal()
        {
            StreamWriter f = new StreamWriter("Roar.txt", false);
            foreach (var item in Animals)
            {
                if (((Animal)item).output)
                    ((IOutput)item).FileOutput(f);
                else
                    item.Say();
            }
            f.Close();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cell cell = new Cell();

            while (true)
            {
                Console.WriteLine("Выбирай:");
                Console.WriteLine("1. Добавить быка");
                Console.WriteLine("2. Добавить корову");
                Console.WriteLine("3. Посмотреть всех животных");
                Console.WriteLine("4. Удалить животное");
                Console.WriteLine("5. Выйти из программы");

                int temp = Convert.ToInt32(Console.ReadLine());

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
                        cell.RemoveAnimal(new Ram(NewAnimal(), Output()));
                        break;
                    case 5:
                        Environment.Exit(15);
                        break;
                    default:
                        break;
                }
            }
        }

        static string NewAnimal()
        {
            Console.Clear();
            Console.WriteLine("Назовите животного");
            return Console.ReadLine();
        }

        static bool Output()
        {
            Console.WriteLine("Куда будет выводиться звук? 1 / 0 (фаил / консоль) соответственно");
            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "0":
                    return false;
                default:
                    return false;
            }
        }
    }
}
