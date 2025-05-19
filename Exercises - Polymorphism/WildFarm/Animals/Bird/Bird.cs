namespace PolymorphismExercises.WildFarm.Animals.Bird
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; }

        protected Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}