using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion
{
    public class Tyrannomon : IEvoCriteria
    {
        public EvoStage EvoStage => EvoStage.Champion;

        public DigimonType DigimonType => DigimonType.Tyrannomon;

        public EvoCriterionCombatStats CombatStats { get; } = new EvoCriterionCombatStats(
            hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 0
        );

        public EvoCriterionCareMistakes CareMistakes { get; } = new EvoCriterionCareMistakes(
            amtCareMistakes: 5
            , isMax: true
        );

        public EvoCriterionWeight Weight { get; } = new EvoCriterionWeight(
            amtWeight: 30
            , amtMaxDeviation: 5
        );

        public EvoCriterionHappiness Happiness { get; } = new EvoCriterionHappiness(
            amtHappiness: 0
        );

        public EvoCriterionDiscipline Discipline { get; } = new EvoCriterionDiscipline(
            amtDiscipline: 0
        );

        public EvoCriterionBattles Battles { get; } = new EvoCriterionBattles(
            amtBattles: 5
            , isMax: true
        );

        public EvoCriterionTech Tech { get; } = new EvoCriterionTech(
            amtTech: 28
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