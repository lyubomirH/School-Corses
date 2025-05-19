using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises.WildFarm.Animals.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        public override void MakeSound()
        {
            System.Console.WriteLine("Squeak");
        }

        public override void Eat(Food.Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                FoodEaten += food.Quantity;
                Weight += 0.10 * food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}