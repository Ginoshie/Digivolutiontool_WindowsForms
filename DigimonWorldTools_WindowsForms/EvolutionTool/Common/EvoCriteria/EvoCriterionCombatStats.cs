namespace DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria
{
    public class EvoCriterionCombatStats
    {
        public EvoCriterionCombatStats(
            int hp
            , int mp
            , int off
            , int def
            , int speed
            , int brains
        )
        {
            HP = hp;
            MP = mp;
            Off = off;
            Def = def;
            Speed = speed;
            Brains = brains;
        }

        public int HP { get; }

        public int MP { get; }

        public int Off { get; }

        public int Def { get; }

        public int Speed { get; }

        public int Brains { get; }
    }
}