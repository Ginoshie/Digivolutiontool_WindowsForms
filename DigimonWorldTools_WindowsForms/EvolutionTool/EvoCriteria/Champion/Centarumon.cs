using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;
using DigimonWorldTools_WindowsForms.EvoTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvoTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvoTool.EvoCriteria.Champion
{
    public class Centarumon : IEvoCriteria
    {
        public EvoStage EvoStage => EvoStage.Champion;

        public DigimonType DigimonType => DigimonType.Centarumon;

        public EvoCriterionCombatStats CombatStats { get; } = new EvoCriterionCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 0
            , brains: 100
        );

        public EvoCriterionCareMistakes CareMistakes { get; } = new EvoCriterionCareMistakes(
            amtCareMistakes: 3
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
            amtDiscipline: 60
        );

        public EvoCriterionBattles Battles { get; } = new EvoCriterionBattles(
            amtBattles: 0
            , isMax: false
        );

        public EvoCriterionTech Tech { get; } = new EvoCriterionTech(
            amtTech: 28
        );

        public DigimonType? PrecursorDigimonType => null;

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
