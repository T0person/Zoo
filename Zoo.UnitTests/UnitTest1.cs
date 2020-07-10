using NUnit.Framework;

namespace Zoo.UnitTests
{
    public class Tests
    {
        [Test]
        public void AddAnimnal_AnimalsCountreturned()// �������� �� ���������� ���������
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("����", false);
            Animal animal = ram;

            cell.AddAnimal(animal);

            Assert.AreEqual(len + 1, cell.GetAnimalsCount());
        }

        [Test]
        public void RemoveAnimnal_AnimalsCountreturned() // �������� �� �������� ���������
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("����", false);
            Animal animal = ram;

            cell.AddAnimal(animal);

            cell.RemoveAnimal(animal);

            Assert.AreEqual(len, cell.GetAnimalsCount());
        }

        [Test]
        public void RemoveFalseAnimnal_AnimalsCountreturned() // �������� �� �������� ������������� ���������
        {
            Cell cell = new Cell();

            int len = cell.GetAnimalsCount();

            Ram ram = new Ram("����", false);

            cell.AddAnimal((Animal)ram);

            Cow cow = new Cow("����");
            cell.RemoveAnimal((Animal)cow);

            Assert.AreNotEqual(len - 1, cell.GetAnimalsCount());
        }
    }
}