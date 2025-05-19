namespace PolymorphismExercises.Raiding
{
    public class Rogue : BaseHero
    {
        public override int Power => 80;

        public Rogue(string name) : base(name) { }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}   