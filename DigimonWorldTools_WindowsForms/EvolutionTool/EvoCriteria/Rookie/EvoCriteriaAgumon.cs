using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Rookie
{
    class EvoCriteriaAgumon : IEvoCriteria
    {
        public EvoStage EvoStage => EvoStage.Rookie;

        public DigimonType DigimonType => DigimonType.Agumon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 10
            , mp: 10
            , off: 1
            , def: 0
            ,speed: 0
            , brains: 0
        );

        public EvoCriteriaCareMistakes CareMistakes { get; } = new EvoCriteriaCareMistakes(
            amtCareMistakes: 0
            , isMax: false
        );

        public EvoCriteriaWeight Weight { get; } = new EvoCriteriaWeight(
            amtWeight: 15
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
            amtTech: 0
        );

        public DigimonType? PrecursorDigimonType => DigimonType.Koromon;

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
                    PrecursorDigimonType = PrecursorDigimonType
                };
            }
        }
    }
}
