using NUnit.Framework;

namespace Zoo.UnitTests
{
    public class Tests
    {
        [Test]
        public void AddAnimnal_AnimalsCountreturned()// Проверка на добавление животного
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("Петя", false);
            Animal animal = ram;

            cell.AddAnimal(animal);

            Assert.AreEqual(len + 1, cell.GetAnimalsCount());
        }

        [Test]
        public void RemoveAnimnal_AnimalsCountreturned() // Проверка на удаление животного
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("Петя", false);
            Animal animal = ram;

            cell.AddAnimal(animal);

            cell.RemoveAnimal(animal);

            Assert.AreEqual(len, cell.GetAnimalsCount());
        }

        [Test]
        public void RemoveFalseAnimnal_AnimalsCountreturned() // Проверка на удаление неправильного животного
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("Петя", false);

            cell.AddAnimal((Animal)ram);

            Cow cow = new Cow("Толя");
            cell.RemoveAnimal((Animal)cow);

            Assert.AreNotEqual(len - 1, cell.GetAnimalsCount());
        }
    }
}