using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    public class Ram : Animal, IAnimal, IOutput
    {

        public Ram(string name, bool output)
        {
            this.name = name;
            type = "Баран";
            say = "бе-е-е-е";
            this.output = output;
        }

        public Ram(string name)
        {
            this.name = name;
        }

        public void FileOutput(StreamWriter f)
        {
            f.WriteLine($"{type} {name}: {say}");
        }
    }
}
