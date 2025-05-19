using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises.WildFarm.Animals.Mammal.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed) { }

        public override void MakeSound()
        {
            System.Console.WriteLine("ROAR!!!");
        }

        public override void Eat(Food.Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += 1.00 * food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}