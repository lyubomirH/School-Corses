namespace PolymorphismExercises.Raiding
{
    public static class HeroFactory
    {
        public static BaseHero CreateHero(string heroType, string heroName)
        {
            return heroType switch
            {
                "Druid" => new Druid(heroName),
                "Paladin" => new Paladin(heroName),
                "Rogue" => new Rogue(heroName),
                "Warrior" => new Warrior(heroName),
                _ => throw new ArgumentException("Invalid hero!")
            };
        }
    }
}