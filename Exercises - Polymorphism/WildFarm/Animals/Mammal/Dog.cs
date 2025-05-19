using PolymorphismExercises.WildFarm.Food;

namespace PolymorphismExercises.WildFarm.Animals.Mammal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion) { }

        public override void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }

        public override void Eat(Food.Food food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += 0.40 * food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}