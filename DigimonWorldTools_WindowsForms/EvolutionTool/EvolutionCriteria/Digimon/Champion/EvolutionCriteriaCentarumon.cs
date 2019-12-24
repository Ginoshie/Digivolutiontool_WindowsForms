using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.BonusCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.EvoCriteria.MainCriteria;
using DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.Digimon;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.EvolutionCriteria.Digimon.Champion
{
    public class EvolutionCriteriaCentarumon : IEvolutionCriteria
    {
        public EvolutionStage EvolutionStage => EvolutionStage.Champion;

        public DigimonType DigimonType => DigimonType.Centarumon;

        public EvoCriteriaCombatStats EvoCriteriaCombatStats { get; } = new EvoCriteriaCombatStats(
            hp: 0
            , mp: 0
            , off: 0
            , def: 0
            , speed: 0
            , brains: 100
        );

        public EvoCriteriaCareMistakes EvoCriteriaCareMistakes { get; } = new EvoCriteriaCareMistakes(
            isCareMistakesCriteriaMaximum: true
            , careMistakes: 3
        );

        public EvoCriteriaWeight EvoCriteriaWeight { get; } = new EvoCriteriaWeight(
            weight: 30
            , maxDeviationFromWeightBoundsIncluded: 5
        );

        public int Happiness => 0;

        public int Discipline => 60;

        public EvoCriteriaBattles EvoCriteriaBattles { get; } = new EvoCriteriaBattles(
            isBattlesCriteriaAMaximum: false
            , battles: 0
        );

        public int Tech => 28;

        public DigimonType? PrecursorDigimonType => null;
    }
}
