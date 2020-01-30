using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion
{
    public class EvoCriteriaBirdramon : IEvoCriteria
    {
        public EvoStage EvoStage => EvoStage.Champion;

        public DigimonType DigimonType => DigimonType.Birdramon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 100
            , brains: 0
        );

        public EvoCriteriaCareMistakes CareMistakes { get; } = new EvoCriteriaCareMistakes(
            amtCareMistakes: 3
            , isMax: false
        );
        public EvoCriteriaWeight Weight { get; } = new EvoCriteriaWeight(
            amtWeight: 20
            , amtMaxDeviation: 5
        );

        public EvoCriteriaHappiness Happiness { get; } = new EvoCriteriaHappiness(
            amtHappiness: 0
        );

        public EvoCriteriaDiscipline Discipline { get; } = new EvoCriteriaDiscipline(
            amtDiscipline: 0
        );

        public EvoCriteriaBattles Battles { get; } = new EvoCriteriaBattles(
            amtBattles: 0
            , isMax: false
        );

        public EvoCriteriaTech Tech { get; } = new EvoCriteriaTech(
            amtTech: 35
        );

        public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;

        public EvoCriteriaMain EvoCriteriaMain
        {
            get
            {
                return new EvoCriteriaMain()
                {
                    CombatStats = CombatStats,
                    CareMistakes = CareMistakes,
                    Weight = Weight
                };
            }
        }

        public EvoCriteriaBonus EvoCriteriaBonus
        {
            get
            {
                return new EvoCriteriaBonus()
                {
                    Happiness = Happiness,
                    Discipline = Discipline,
                    Battles = Battles,
                    Tech = Tech,
                    PrecursorDigimonType = DigimonType
                };
            }
        }
    }
}
