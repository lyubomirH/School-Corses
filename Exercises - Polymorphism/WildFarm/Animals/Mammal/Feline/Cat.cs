using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises.WildFarm.Animals.Mammal.Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        public override void MakeSound()
        {
            System.Console.WriteLine("Meow");
        }

        public override void Eat(Food.Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += 0.30 * food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}