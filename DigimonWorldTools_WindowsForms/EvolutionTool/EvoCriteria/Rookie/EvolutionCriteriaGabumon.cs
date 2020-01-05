using DigimonWorldTools_WindowsForms.EvolutionTool.Common.Digimon;
using DigimonWorldTools_WindowsForms.EvolutionTool.Common.EvoCriteria;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Rookie
{
    class EvolutionCriteriaGabumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Rookie;

        public DigimonType DigimonType => DigimonType.Gabumon;

        public EvoCriteriaCombatStats CombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 1
            , speed: 0
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
            amtBattles: -2
            , isMax: false
        );

        public EvoCriteriaTech Tech { get; } = new EvoCriteriaTech(
            amtTech: 0
        );

        public DigimonType? PrecursorDigimonType => DigimonType.Koromon;
    }
}
