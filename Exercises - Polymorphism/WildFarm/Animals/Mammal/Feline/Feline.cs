﻿namespace PolymorphismExercises.WildFarm.Animals.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; }

        protected Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}