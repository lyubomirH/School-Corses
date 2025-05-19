namespace PolymorphismExercises.Raiding
{
    public abstract class BaseHero
    {
        public string Name { get; }
        public virtual int Power { get; }

        protected BaseHero(string name)
        {
            Name = name;
        }

        public abstract string CastAbility();
    }
}