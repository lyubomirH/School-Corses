namespace PolymorphismExercises.WildFarm.Animals
{
    public abstract class Animal
    {
        public string Name { get; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food.Food food);
    }
}