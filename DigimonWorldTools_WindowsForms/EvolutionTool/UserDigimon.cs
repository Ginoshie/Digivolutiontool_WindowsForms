using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Stats;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Stats;

namespace DigimonWorldTools_WindowsForms.EvoTool
{
    public class UserDigimon
    {
        public DigimonType DigimonType { get; set; }

        public Stats Stats { get; set; }

        public MainCriteriaStats MainCritiaStats
        {
            get {
                return new MainCriteriaStats
                {
                    CombatStats = Stats.CombatStats,
                    CareMistakes = Stats.CareMistakes,
                    Weight = Stats.Weight
                };
            }
        }

        public BonusCritiaStats BonusCritiaStats
        {
            get
            {
                return new BonusCritiaStats
                {
                    Battles = Stats.Battles,
                    Happiness = Stats.Happiness,
                    Discipline = Stats.Discipline,
                    Tech = Stats.Tech,
                    DigimonType = DigimonType
                };
            }
        }
    }
}
