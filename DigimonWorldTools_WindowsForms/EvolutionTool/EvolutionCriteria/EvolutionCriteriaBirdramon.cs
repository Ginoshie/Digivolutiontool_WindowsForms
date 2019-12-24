using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria
{
    public class EvolutionCriteriaBirdramon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Birdramon;

        public EvoCriteriaCombatStats EvoCriteriaCombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 100
            , brains: 0
        );

        public EvoCriteriaCareMistakes EvoCriteriaCareMistakes { get; } = new EvoCriteriaCareMistakes(
            isCareMistakesCriteriaMaximum: false
            , careMistakes: 3
        );
        public EvoCriteriaWeight EvoCriteriaWeight { get; } = new EvoCriteriaWeight(
            weight: 20
            , maxDeviationFromWeightBoundsIncluded: 5
        );

        public int Happiness => 0;

        public int Discipline => 0;

        public EvoCriteriaBattles EvoCriteriaBattles { get; } = new EvoCriteriaBattles(
            isBattlesCriteriaAMaximum: false
            , battles: 0
        );

        public int Tech => 35;

        public DigimonType? PrecursorDigimonType => DigimonType.Biyomon;
    }
}
