using System;

namespace Zoo
{

    class Ram
    {
        private string type = "Баран", say = "бе-е-е-е", name;

        public Ram(string name)
        {
            this.name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{type} {name}: {say}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ram ram1 = new Ram("Степа");
            Ram ram2 = new Ram("Вася");
            Ram ram3 = new Ram("Миша");
            Ram ram4 = new Ram("Гена");

            ram1.GetInfo();
            ram2.GetInfo();
            ram3.GetInfo();
            ram4.GetInfo();

            Console.WriteLine("Введи любой символ");
            Console.ReadKey();

        }
    }
}
