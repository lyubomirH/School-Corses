using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises.WildFarm.Animals.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize) { }

        public override void MakeSound()
        {
            System.Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(Food.Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += 0.25 * food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}