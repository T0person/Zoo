using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    public class Cell
    {

        private List<IAnimal> Animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }

        public int GetAnimalsCount()
        {
            return Animals.Count;
        }

        public void RemoveAnimal(IAnimal animal)
        {
            bool no_animal = false;
            foreach (var item in Animals)
            {
                if (((Animal)animal).name == ((Animal)item).name)
                {
                    Animals.Remove(item);
                    no_animal = true;
                    break;
                }
            }
            if (!no_animal)
                Console.WriteLine("\nНет такого животного!!!\n\n");
        }

        public void GetAnimal()
        {
            StreamWriter f = new StreamWriter("Roar.txt", false);
            Console.Clear();
            foreach (var item in Animals)
            {
                if (((Animal)item).output)
                    ((IOutput)item).FileOutput(f);
                else
                    item.Say();
            }
            if (Animals.Count == 0)
                Console.WriteLine("\nНет животных!\n\n");
            f.Close();
        }

    }
}
