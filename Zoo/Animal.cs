using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal : IAnimal
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
}
