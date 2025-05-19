namespace PolymorphismExercises.Raiding
{
    public class Paladin : BaseHero
    {
        public override int Power => 100;

        public Paladin(string name) : base(name) { }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
