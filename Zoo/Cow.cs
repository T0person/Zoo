using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    public class Cow : Animal, IAnimal, IOutput
    {
        public Cow(string name, bool output)
        {
            this.name = name;
            type = "Корова";
            say = "му-у-у-у";
            this.output = output;
        }
        public Cow(string name)
        {
            this.name = name;
        }

        public void FileOutput(StreamWriter f)
        {
            f.WriteLine($"{type} {name}: {say}, {output}");
        }
    }
}
