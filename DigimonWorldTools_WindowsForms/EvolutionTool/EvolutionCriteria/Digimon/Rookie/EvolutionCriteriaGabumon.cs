using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Digimon.Rookie
{
    class EvolutionCriteriaGabumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Rookie;

        public DigimonType DigimonType => DigimonType.Gabumon;

        public EvoCriteriaCombatStats EvoCriteriaCombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 1
            , speed: 0
            , brains: 0
        );

        public EvoCriteriaCareMistakes EvoCriteriaCareMistakes { get; } = new EvoCriteriaCareMistakes(
            isCareMistakesCriteriaMaximum: false
            , careMistakes: 0
        );

        public EvoCriteriaWeight EvoCriteriaWeight { get; } = new EvoCriteriaWeight(
            weight: 15
            , maxDeviationFromWeightBoundsIncluded: 5
        );

        public int Happiness => 0;

        public int Discipline => 0;

        public EvoCriteriaBattles EvoCriteriaBattles { get; } = new EvoCriteriaBattles(
            isBattlesCriteriaAMaximum: false
            , battles: -2
        );

        public int Tech => 0;

        public DigimonType? PrecursorDigimonType => DigimonType.Koromon;
    }
}
