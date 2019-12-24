using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Digimon.Champion
{
    public class EvolutionCriteriaMonochromon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Monochromon;

        public EvoCriteriaCombatStats EvoCriteriaCombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 1000
            , mp: 0
            , off: 0
            , def: 100
            , speed: 0
            , brains: 100
        );

        public EvoCriteriaCareMistakes EvoCriteriaCareMistakes { get; } = new EvoCriteriaCareMistakes(
            isCareMistakesCriteriaMaximum: true
            , careMistakes: 3
        );

        public EvoCriteriaWeight EvoCriteriaWeight { get; } = new EvoCriteriaWeight(
            weight: 40
            , maxDeviationFromWeightBoundsIncluded: 5
        );

        public int Happiness => 0;

        public int Discipline => 0;

        public EvoCriteriaBattles EvoCriteriaBattles { get; } = new EvoCriteriaBattles(
            isBattlesCriteriaAMaximum: true
            , battles: 5
        );

        public int Tech => 35;

        public DigimonType? PrecursorDigimonType => null;
    }
}
