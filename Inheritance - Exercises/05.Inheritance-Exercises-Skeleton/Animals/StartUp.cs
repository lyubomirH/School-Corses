using Animals.classes;
using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = Console.ReadLine();
            string[] animalData = Console.ReadLine().Split();
            var animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                switch(animalType)
                {
                    case "Dog":
                        animals.Add(new Dog(animalData[0], int.Parse(animalData[1]), animalData[2] == "Female" ? Gender.Female: Gender.Male));
                        break;

                    case "Frog":
                        animals.Add(new Frog(animalData[0], int.Parse(animalData[1]), animalData[2] == "Female" ? Gender.Female : Gender.Male));
                        break;

                    case "Cat":
                        animals.Add(new Cat(animalData[0], int.Parse(animalData[1]), animalData[2] == "Female" ? Gender.Female : Gender.Male));
                        break;

                    case "Kitten":
                        animals.Add(new Kitten(animalData[0], int.Parse(animalData[1])));
                        break;

                    case "Tomcat":
                        animals.Add(new Tomcat(animalData[0], int.Parse(animalData[1])));
                        break;
                }
                animalData = Console.ReadLine().Split();
                animalType = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }
        }
    }
}
