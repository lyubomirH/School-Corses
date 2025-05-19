using System;
using System.Collections.Generic;
using PolymorphismExercises.WildFarm.Animals;
using PolymorphismExercises.WildFarm.Animals.Bird;
using PolymorphismExercises.WildFarm.Animals.Mammal;
using PolymorphismExercises.WildFarm.Animals.Mammal.Feline;
using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] animalInfo = input.Split();
                string animalType = animalInfo[0];
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                Animal animal = null;

                try
                {
                    switch (animalType)
                    {
                        case "Cat":
                            string livingRegion = animalInfo[3];
                            string breed = animalInfo[4];
                            animal = new Cat(name, weight, livingRegion, breed);
                            break;
                        case "Tiger":
                            livingRegion = animalInfo[3];
                            breed = animalInfo[4];
                            animal = new Tiger(name, weight, livingRegion, breed);
                            break;
                        case "Mouse":
                            livingRegion = animalInfo[3];
                            animal = new Mouse(name, weight, livingRegion);
                            break;
                        case "Dog":
                            livingRegion = animalInfo[3];
                            animal = new Dog(name, weight, livingRegion);
                            break;
                        case "Hen":
                            double wingSize = double.Parse(animalInfo[3]);
                            animal = new Hen(name, weight, wingSize);
                            break;
                        case "Owl":
                            wingSize = double.Parse(animalInfo[3]);
                            animal = new Owl(name, weight, wingSize);
                            break;
                        default:
                            continue;
                    }

                    animals.Add(animal);

                    string[] foodInfo = Console.ReadLine().Split();
                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    Food food = null;
                    switch (foodType)
                    {
                        case "Vegetable":
                            food = new Vegetable(quantity);
                            break;
                        case "Fruit":
                            food = new Fruit(quantity);
                            break;
                        case "Meat":
                            food = new Meat(quantity);
                            break;
                        case "Seeds":
                            food = new Seeds(quantity);
                            break;
                        default:
                            continue;
                    }

                    animal.MakeSound();
                    animal.Eat(food);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}